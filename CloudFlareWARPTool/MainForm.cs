using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudFlareWARPTool
{
    public partial class MainForm : Form
    {
        private const int SINGLE_COUNT_DOWN_SECOND = 25;
        private const string SINGLE_TAB_NAME = "tpSingle";
        private const string MULTI_TAB_NAME = "tpMulti";

        private static readonly Size singleTabSize = new Size(375, 345);
        private static readonly Size multiTabSize = new Size(375, 545);

        private readonly Result singleResult, multiResult;
        private ProxyLocation proxyLocation;
        private int singleCountDown;
        private IList<string> proxyList;

        private bool multiThreadRun
        {
            get
            {
                lock (multiRunLock)
                {
                    return multiThreadRunVariable;
                }
            }

            set
            {
                lock (multiRunLock)
                {
                    multiThreadRunVariable = value;
                }
            }
        }

        private bool multiThreadRunVariable;
        private readonly object multiRunLock;

        public enum ProxyLocation
        {
            FILE,
            INTERNET
        }

        public MainForm()
        {
            InitializeComponent();
            Size = singleTabSize;

            proxyLocation = ProxyLocation.INTERNET;
            singleResult = new Result();
            multiResult = new Result();
            multiRunLock = new object();
        }

        private void tcMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage select = (sender as TabControl).SelectedTab;
            switch (select.Name)
            {
                case SINGLE_TAB_NAME:
                    {
                        Size = singleTabSize;
                        break;
                    }
                case MULTI_TAB_NAME:
                    {
                        Size = multiTabSize;
                        break;
                    }
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private static void updateResult(Label result, Label addFlow, (int, int) data)
        {
            int success = data.Item1;
            int fail = data.Item2;

            StringBuilder sb = new StringBuilder();
            sb.Append("執行次數 : ").AppendLine((success + fail).ToString());
            sb.Append("成功次數 : ").AppendLine(success.ToString());
            sb.Append("失敗次數 : ").AppendLine(fail.ToString());

            result.Invoke((MethodInvoker)delegate
            {
                result.Text = sb.ToString();
            });

            addFlow.Invoke((MethodInvoker)delegate
            {
                addFlow.Text = $"已新增 {success} GB 流量到您的帳戶中";
            });
        }

        private void runMulti(string userId, bool update)
        {
            multiThreadRun = true;
            ThreadStart work = () =>
            {
                while (multiThreadRun)
                {
                    CountdownEvent track = new CountdownEvent(proxyList.Count);
                    foreach (string proxy in proxyList)
                    {
                        ThreadPool.QueueUserWorkItem(state =>
                        {
                            try
                            {
                                Util.sendRegister(userId, proxy);
                                multiResult.addSuccess();
                            }
                            catch
                            {
                                multiResult.addFail();
                            }
                            updateResult(labelMultiResult, labelMultiAddFlow, multiResult.getStatus());
                            track.Signal();
                        });
                    }
                    track.Wait();

                    if (update)
                    {
                        try
                        {
                            loadProxyListFromInternet();
                        }
                        catch
                        {
                        }
                    }
                }
            };
            work += () =>
            {
                Invoke((MethodInvoker)delegate
                {
                    btnMultiStop.Text = "停止";
                    setMultiRun(false);
                });
            };
            new Thread(work).Start();
        }

        private void updateProxyCount()
        {
            labelMultiProxyCount.Invoke((MethodInvoker)delegate
            {
                labelMultiProxyCount.Text = $"目前代理數量 : {proxyList.Count}";
            });
        }

        private void setSingleRun(bool run)
        {
            txtSingleId.Enabled = btnSingleStart.Enabled = !run;
            btnSingleStop.Enabled = run;
        }

        private static bool checkId(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
            {
                MessageBox.Show("請輸入 WARP ID", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Util.isUUID(data))
            {
                MessageBox.Show("WARP ID 格式錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSingleStart_Click(object sender, EventArgs e)
        {
            string id = txtSingleId.Text;
            if (!checkId(id))
            {
                return;
            }
            setSingleRun(true);

            singleCountDown = SINGLE_COUNT_DOWN_SECOND;
            timerSingle.Start();
        }

        private void btnSingleStop_Click(object sender, EventArgs e)
        {
            timerSingle.Stop();
            labelSingleStatus.Text = "就緒";
            setSingleRun(false);
        }

        private void updateProxyLocation()
        {
            btnMultiLoadFromFile.Enabled = proxyLocation == ProxyLocation.FILE;
            btnMultiLoadFromInternet.Enabled = chkMultiAutomaticUpdateProxyListFromInternet.Enabled = proxyLocation == ProxyLocation.INTERNET;
        }

        private void rbMultiLoadFromFile_CheckedChanged(object sender, EventArgs e)
        {
            proxyLocation = ProxyLocation.FILE;
            updateProxyLocation();
        }

        private void rbMultiLoadFromInternet_CheckedChanged(object sender, EventArgs e)
        {
            proxyLocation = ProxyLocation.INTERNET;
            updateProxyLocation();
        }

        private void btnMultiLoadFromFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "文字檔案 (*.txt)|*.txt|所有檔案 (*.*)|*.*",
                Title = "請選擇支援 HTTPS 代理列表檔案"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<string> readProxyList = new List<string>();
                    try
                    {
                        readProxyList.AddRange(File.ReadAllLines(openFileDialog.FileName));
                        if (readProxyList.Count <= 0)
                        {
                            MessageBox.Show("代理列表不得為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        proxyList = readProxyList;
                        updateProxyCount();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"讀取代理列表時發生例外狀況 : {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool loadProxyListFromInternet()
        {
            IList<string> downloadProxyList = Util.getProxyList();
            if (downloadProxyList.Count <= 0)
            {
                return false;
            }
            proxyList = downloadProxyList;
            updateProxyCount();
            return true;
        }

        private async void btnMultiLoadFromInternet_Click(object sender, EventArgs e)
        {
            labelMultiProxyCount.Text = "正在取得代理列表 ...";

            setDownloadProxyList(true);
            await Task.Run(() =>
            {
                try
                {
                    if (!loadProxyListFromInternet())
                    {
                        setProxyCountMessage("下載到空代理列表資料");
                    }
                }
                catch
                {
                    setProxyCountMessage("代理列表取得失敗");
                }
            });
            setDownloadProxyList(false);

            void setProxyCountMessage(string message)
            {
                if (proxyList == null)
                {
                    labelMultiProxyCount.Invoke((MethodInvoker)delegate
                    {
                        labelMultiProxyCount.Text = message;
                    });
                    return;
                }
                MessageBox.Show($"{message}，使用先前代理列表", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static void setThreadPool(int thread)
        {
            ThreadPool.SetMinThreads(thread, thread);
            ThreadPool.SetMaxThreads(thread, thread);
        }

        private void setMultiRun(bool run)
        {
            txtMultiId.Enabled = numMultiThread.Enabled = rbMultiLoadFromFile.Enabled
                = btnMultiLoadFromFile.Enabled = rbMultiLoadFromInternet.Enabled = btnMultiLoadFromInternet.Enabled
                = chkMultiAutomaticUpdateProxyListFromInternet.Enabled = btnMultiStart.Enabled = !run;

            btnMultiStop.Enabled = run;
        }

        private void setDownloadProxyList(bool download)
        {
            rbMultiLoadFromFile.Enabled = rbMultiLoadFromInternet.Enabled = btnMultiLoadFromInternet.Enabled
                = btnMultiStart.Enabled = !download;
        }

        private void btnMultiStart_Click(object sender, EventArgs e)
        {
            string id = txtMultiId.Text;
            if (!checkId(id))
            {
                return;
            }

            int thread;
            try
            {
                thread = Convert.ToInt32(numMultiThread.Text);
            }
            catch
            {
                MessageBox.Show("請輸入執行緒數量", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (proxyList == null)
            {
                MessageBox.Show("請載入代理列表", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            setMultiRun(true);
            setThreadPool(thread);
            runMulti(id, proxyLocation == ProxyLocation.INTERNET ? chkMultiAutomaticUpdateProxyListFromInternet.Checked : false);
        }

        private void timerSingle_Tick(object sender, EventArgs e)
        {
            labelSingleStatus.Text = $"等待 {--singleCountDown} 秒後送出新請求 ...";
            if (singleCountDown <= 0)
            {
                timerSingle.Stop();
                labelSingleStatus.Text = "正在處理請求 ...";

                btnSingleStop.Enabled = false;
                string id = txtSingleId.Text;
                new Thread(() =>
                {
                    try
                    {
                        Util.sendRegister(id);
                        singleResult.addSuccess();
                    }
                    catch
                    {
                        singleResult.addFail();
                    }
                    updateResult(labelSingleResult, labelSingleAddFlow, singleResult.getStatus());

                    Invoke((MethodInvoker)delegate
                    {
                        btnSingleStop.Enabled = true;

                        singleCountDown = SINGLE_COUNT_DOWN_SECOND;
                        timerSingle.Start();
                    });
                }).Start();
            }
        }

        private void btnMultiStop_Click(object sender, EventArgs e)
        {
            btnMultiStop.Enabled = false;
            btnMultiStop.Text = "正在等待請求執行完畢";
            multiThreadRun = false;
        }

        private void chkSingleHideId_CheckedChanged(object sender, EventArgs e)
        {
            txtSingleId.UseSystemPasswordChar = chkSingleHideId.Checked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            AppDomain domain = AppDomain.CurrentDomain;
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                Arguments = $"/c ping 127.0.0.1 -n 2 && start {domain.FriendlyName}",
                WindowStyle = ProcessWindowStyle.Hidden,
                WorkingDirectory = domain.BaseDirectory,
                CreateNoWindow = true,
                FileName = "cmd.exe"
            };
            using (Process.Start(psi))
            {
            }
            Environment.Exit(Environment.ExitCode);
        }

        private void chkMultiHideId_CheckedChanged(object sender, EventArgs e)
        {
            txtMultiId.UseSystemPasswordChar = chkMultiHideId.Checked;
        }
    }
}