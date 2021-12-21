using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CloudFlareWARPTool
{
    public static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string name = Process.GetCurrentProcess().ProcessName;
            if (Process.GetProcessesByName(name).Length > 1)
            {
                MessageBox.Show("已經有其他程式實例正在執行", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Application.Run(new MainForm());
        }
    }
}