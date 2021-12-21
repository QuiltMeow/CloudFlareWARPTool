namespace CloudFlareWARPTool
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpSingle = new System.Windows.Forms.TabPage();
            this.labelSingleStatus = new System.Windows.Forms.Label();
            this.gbSingleResult = new System.Windows.Forms.GroupBox();
            this.labelSingleAddFlow = new System.Windows.Forms.Label();
            this.labelSingleResult = new System.Windows.Forms.Label();
            this.chkSingleHideId = new System.Windows.Forms.CheckBox();
            this.txtSingleId = new System.Windows.Forms.TextBox();
            this.labelSingleId = new System.Windows.Forms.Label();
            this.btnSingleStop = new System.Windows.Forms.Button();
            this.btnSingleStart = new System.Windows.Forms.Button();
            this.tpMulti = new System.Windows.Forms.TabPage();
            this.numMultiThread = new System.Windows.Forms.NumericUpDown();
            this.gbMultiResult = new System.Windows.Forms.GroupBox();
            this.labelMultiAddFlow = new System.Windows.Forms.Label();
            this.labelMultiResult = new System.Windows.Forms.Label();
            this.btnMultiStop = new System.Windows.Forms.Button();
            this.btnMultiStart = new System.Windows.Forms.Button();
            this.labelMultiProxyCount = new System.Windows.Forms.Label();
            this.gbMultiProxy = new System.Windows.Forms.GroupBox();
            this.chkMultiAutomaticUpdateProxyListFromInternet = new System.Windows.Forms.CheckBox();
            this.rbMultiLoadFromInternet = new System.Windows.Forms.RadioButton();
            this.rbMultiLoadFromFile = new System.Windows.Forms.RadioButton();
            this.btnMultiLoadFromInternet = new System.Windows.Forms.Button();
            this.btnMultiLoadFromFile = new System.Windows.Forms.Button();
            this.labelMultiThread = new System.Windows.Forms.Label();
            this.chkMultiHideId = new System.Windows.Forms.CheckBox();
            this.txtMultiId = new System.Windows.Forms.TextBox();
            this.labelMultiId = new System.Windows.Forms.Label();
            this.tpOther = new System.Windows.Forms.TabPage();
            this.btnRestart = new System.Windows.Forms.Button();
            this.timerSingle = new System.Windows.Forms.Timer(this.components);
            this.tcMain.SuspendLayout();
            this.tpSingle.SuspendLayout();
            this.gbSingleResult.SuspendLayout();
            this.tpMulti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiThread)).BeginInit();
            this.gbMultiResult.SuspendLayout();
            this.gbMultiProxy.SuspendLayout();
            this.tpOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpSingle);
            this.tcMain.Controls.Add(this.tpMulti);
            this.tcMain.Controls.Add(this.tpOther);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(359, 506);
            this.tcMain.TabIndex = 0;
            this.tcMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcMain_Selecting);
            // 
            // tpSingle
            // 
            this.tpSingle.Controls.Add(this.labelSingleStatus);
            this.tpSingle.Controls.Add(this.gbSingleResult);
            this.tpSingle.Controls.Add(this.chkSingleHideId);
            this.tpSingle.Controls.Add(this.txtSingleId);
            this.tpSingle.Controls.Add(this.labelSingleId);
            this.tpSingle.Controls.Add(this.btnSingleStop);
            this.tpSingle.Controls.Add(this.btnSingleStart);
            this.tpSingle.Location = new System.Drawing.Point(4, 22);
            this.tpSingle.Name = "tpSingle";
            this.tpSingle.Padding = new System.Windows.Forms.Padding(3);
            this.tpSingle.Size = new System.Drawing.Size(351, 480);
            this.tpSingle.TabIndex = 0;
            this.tpSingle.Text = "單機單刷";
            this.tpSingle.UseVisualStyleBackColor = true;
            // 
            // labelSingleStatus
            // 
            this.labelSingleStatus.AutoSize = true;
            this.labelSingleStatus.Location = new System.Drawing.Point(15, 245);
            this.labelSingleStatus.Name = "labelSingleStatus";
            this.labelSingleStatus.Size = new System.Drawing.Size(86, 12);
            this.labelSingleStatus.TabIndex = 6;
            this.labelSingleStatus.Text = "執行狀態 : 就緒";
            // 
            // gbSingleResult
            // 
            this.gbSingleResult.Controls.Add(this.labelSingleAddFlow);
            this.gbSingleResult.Controls.Add(this.labelSingleResult);
            this.gbSingleResult.Location = new System.Drawing.Point(17, 125);
            this.gbSingleResult.Name = "gbSingleResult";
            this.gbSingleResult.Size = new System.Drawing.Size(315, 105);
            this.gbSingleResult.TabIndex = 5;
            this.gbSingleResult.TabStop = false;
            this.gbSingleResult.Text = "結果";
            // 
            // labelSingleAddFlow
            // 
            this.labelSingleAddFlow.AutoSize = true;
            this.labelSingleAddFlow.Location = new System.Drawing.Point(15, 80);
            this.labelSingleAddFlow.Name = "labelSingleAddFlow";
            this.labelSingleAddFlow.Size = new System.Drawing.Size(168, 12);
            this.labelSingleAddFlow.TabIndex = 1;
            this.labelSingleAddFlow.Text = "已新增 0 GB 流量到您的帳戶中";
            // 
            // labelSingleResult
            // 
            this.labelSingleResult.Location = new System.Drawing.Point(15, 25);
            this.labelSingleResult.Name = "labelSingleResult";
            this.labelSingleResult.Size = new System.Drawing.Size(285, 40);
            this.labelSingleResult.TabIndex = 0;
            this.labelSingleResult.Text = "執行次數 : 0\r\n成功次數 : 0\r\n失敗次數 : 0";
            // 
            // chkSingleHideId
            // 
            this.chkSingleHideId.AutoSize = true;
            this.chkSingleHideId.Location = new System.Drawing.Point(269, 13);
            this.chkSingleHideId.Name = "chkSingleHideId";
            this.chkSingleHideId.Size = new System.Drawing.Size(63, 16);
            this.chkSingleHideId.TabIndex = 1;
            this.chkSingleHideId.Text = "隱藏 ID";
            this.chkSingleHideId.UseVisualStyleBackColor = true;
            this.chkSingleHideId.CheckedChanged += new System.EventHandler(this.chkSingleHideId_CheckedChanged);
            // 
            // txtSingleId
            // 
            this.txtSingleId.Location = new System.Drawing.Point(17, 35);
            this.txtSingleId.Name = "txtSingleId";
            this.txtSingleId.Size = new System.Drawing.Size(315, 22);
            this.txtSingleId.TabIndex = 2;
            // 
            // labelSingleId
            // 
            this.labelSingleId.AutoSize = true;
            this.labelSingleId.Location = new System.Drawing.Point(15, 15);
            this.labelSingleId.Name = "labelSingleId";
            this.labelSingleId.Size = new System.Drawing.Size(53, 12);
            this.labelSingleId.TabIndex = 0;
            this.labelSingleId.Text = "WARP ID";
            // 
            // btnSingleStop
            // 
            this.btnSingleStop.BackColor = System.Drawing.Color.MistyRose;
            this.btnSingleStop.Enabled = false;
            this.btnSingleStop.Location = new System.Drawing.Point(180, 75);
            this.btnSingleStop.Name = "btnSingleStop";
            this.btnSingleStop.Size = new System.Drawing.Size(135, 35);
            this.btnSingleStop.TabIndex = 4;
            this.btnSingleStop.Text = "停止";
            this.btnSingleStop.UseVisualStyleBackColor = false;
            this.btnSingleStop.Click += new System.EventHandler(this.btnSingleStop_Click);
            // 
            // btnSingleStart
            // 
            this.btnSingleStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSingleStart.Location = new System.Drawing.Point(30, 75);
            this.btnSingleStart.Name = "btnSingleStart";
            this.btnSingleStart.Size = new System.Drawing.Size(135, 35);
            this.btnSingleStart.TabIndex = 3;
            this.btnSingleStart.Text = "開始";
            this.btnSingleStart.UseVisualStyleBackColor = false;
            this.btnSingleStart.Click += new System.EventHandler(this.btnSingleStart_Click);
            // 
            // tpMulti
            // 
            this.tpMulti.Controls.Add(this.numMultiThread);
            this.tpMulti.Controls.Add(this.gbMultiResult);
            this.tpMulti.Controls.Add(this.btnMultiStop);
            this.tpMulti.Controls.Add(this.btnMultiStart);
            this.tpMulti.Controls.Add(this.labelMultiProxyCount);
            this.tpMulti.Controls.Add(this.gbMultiProxy);
            this.tpMulti.Controls.Add(this.labelMultiThread);
            this.tpMulti.Controls.Add(this.chkMultiHideId);
            this.tpMulti.Controls.Add(this.txtMultiId);
            this.tpMulti.Controls.Add(this.labelMultiId);
            this.tpMulti.Location = new System.Drawing.Point(4, 22);
            this.tpMulti.Name = "tpMulti";
            this.tpMulti.Padding = new System.Windows.Forms.Padding(3);
            this.tpMulti.Size = new System.Drawing.Size(351, 480);
            this.tpMulti.TabIndex = 1;
            this.tpMulti.Text = "代理群刷";
            this.tpMulti.UseVisualStyleBackColor = true;
            // 
            // numMultiThread
            // 
            this.numMultiThread.Location = new System.Drawing.Point(17, 90);
            this.numMultiThread.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numMultiThread.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMultiThread.Name = "numMultiThread";
            this.numMultiThread.Size = new System.Drawing.Size(315, 22);
            this.numMultiThread.TabIndex = 4;
            this.numMultiThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMultiThread.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // gbMultiResult
            // 
            this.gbMultiResult.Controls.Add(this.labelMultiAddFlow);
            this.gbMultiResult.Controls.Add(this.labelMultiResult);
            this.gbMultiResult.Location = new System.Drawing.Point(17, 360);
            this.gbMultiResult.Name = "gbMultiResult";
            this.gbMultiResult.Size = new System.Drawing.Size(315, 105);
            this.gbMultiResult.TabIndex = 9;
            this.gbMultiResult.TabStop = false;
            this.gbMultiResult.Text = "結果";
            // 
            // labelMultiAddFlow
            // 
            this.labelMultiAddFlow.AutoSize = true;
            this.labelMultiAddFlow.Location = new System.Drawing.Point(15, 80);
            this.labelMultiAddFlow.Name = "labelMultiAddFlow";
            this.labelMultiAddFlow.Size = new System.Drawing.Size(168, 12);
            this.labelMultiAddFlow.TabIndex = 1;
            this.labelMultiAddFlow.Text = "已新增 0 GB 流量到您的帳戶中";
            // 
            // labelMultiResult
            // 
            this.labelMultiResult.Location = new System.Drawing.Point(15, 25);
            this.labelMultiResult.Name = "labelMultiResult";
            this.labelMultiResult.Size = new System.Drawing.Size(285, 40);
            this.labelMultiResult.TabIndex = 0;
            this.labelMultiResult.Text = "執行次數 : 0\r\n成功次數 : 0\r\n失敗次數 : 0";
            // 
            // btnMultiStop
            // 
            this.btnMultiStop.BackColor = System.Drawing.Color.MistyRose;
            this.btnMultiStop.Enabled = false;
            this.btnMultiStop.Location = new System.Drawing.Point(180, 305);
            this.btnMultiStop.Name = "btnMultiStop";
            this.btnMultiStop.Size = new System.Drawing.Size(135, 35);
            this.btnMultiStop.TabIndex = 8;
            this.btnMultiStop.Text = "停止";
            this.btnMultiStop.UseVisualStyleBackColor = false;
            this.btnMultiStop.Click += new System.EventHandler(this.btnMultiStop_Click);
            // 
            // btnMultiStart
            // 
            this.btnMultiStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMultiStart.Location = new System.Drawing.Point(30, 305);
            this.btnMultiStart.Name = "btnMultiStart";
            this.btnMultiStart.Size = new System.Drawing.Size(135, 35);
            this.btnMultiStart.TabIndex = 7;
            this.btnMultiStart.Text = "開始";
            this.btnMultiStart.UseVisualStyleBackColor = false;
            this.btnMultiStart.Click += new System.EventHandler(this.btnMultiStart_Click);
            // 
            // labelMultiProxyCount
            // 
            this.labelMultiProxyCount.AutoSize = true;
            this.labelMultiProxyCount.Location = new System.Drawing.Point(15, 280);
            this.labelMultiProxyCount.Name = "labelMultiProxyCount";
            this.labelMultiProxyCount.Size = new System.Drawing.Size(92, 12);
            this.labelMultiProxyCount.TabIndex = 6;
            this.labelMultiProxyCount.Text = "目前代理數量 : 0";
            // 
            // gbMultiProxy
            // 
            this.gbMultiProxy.Controls.Add(this.chkMultiAutomaticUpdateProxyListFromInternet);
            this.gbMultiProxy.Controls.Add(this.rbMultiLoadFromInternet);
            this.gbMultiProxy.Controls.Add(this.rbMultiLoadFromFile);
            this.gbMultiProxy.Controls.Add(this.btnMultiLoadFromInternet);
            this.gbMultiProxy.Controls.Add(this.btnMultiLoadFromFile);
            this.gbMultiProxy.Location = new System.Drawing.Point(17, 130);
            this.gbMultiProxy.Name = "gbMultiProxy";
            this.gbMultiProxy.Size = new System.Drawing.Size(315, 140);
            this.gbMultiProxy.TabIndex = 5;
            this.gbMultiProxy.TabStop = false;
            this.gbMultiProxy.Text = "代理列表";
            // 
            // chkMultiAutomaticUpdateProxyListFromInternet
            // 
            this.chkMultiAutomaticUpdateProxyListFromInternet.AutoSize = true;
            this.chkMultiAutomaticUpdateProxyListFromInternet.Checked = true;
            this.chkMultiAutomaticUpdateProxyListFromInternet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMultiAutomaticUpdateProxyListFromInternet.Location = new System.Drawing.Point(165, 115);
            this.chkMultiAutomaticUpdateProxyListFromInternet.Name = "chkMultiAutomaticUpdateProxyListFromInternet";
            this.chkMultiAutomaticUpdateProxyListFromInternet.Size = new System.Drawing.Size(72, 16);
            this.chkMultiAutomaticUpdateProxyListFromInternet.TabIndex = 4;
            this.chkMultiAutomaticUpdateProxyListFromInternet.Text = "自動更新";
            this.chkMultiAutomaticUpdateProxyListFromInternet.UseVisualStyleBackColor = true;
            // 
            // rbMultiLoadFromInternet
            // 
            this.rbMultiLoadFromInternet.AutoSize = true;
            this.rbMultiLoadFromInternet.Checked = true;
            this.rbMultiLoadFromInternet.Location = new System.Drawing.Point(165, 25);
            this.rbMultiLoadFromInternet.Name = "rbMultiLoadFromInternet";
            this.rbMultiLoadFromInternet.Size = new System.Drawing.Size(71, 16);
            this.rbMultiLoadFromInternet.TabIndex = 2;
            this.rbMultiLoadFromInternet.TabStop = true;
            this.rbMultiLoadFromInternet.Text = "網路下載";
            this.rbMultiLoadFromInternet.UseVisualStyleBackColor = true;
            this.rbMultiLoadFromInternet.CheckedChanged += new System.EventHandler(this.rbMultiLoadFromInternet_CheckedChanged);
            // 
            // rbMultiLoadFromFile
            // 
            this.rbMultiLoadFromFile.AutoSize = true;
            this.rbMultiLoadFromFile.Location = new System.Drawing.Point(15, 25);
            this.rbMultiLoadFromFile.Name = "rbMultiLoadFromFile";
            this.rbMultiLoadFromFile.Size = new System.Drawing.Size(71, 16);
            this.rbMultiLoadFromFile.TabIndex = 0;
            this.rbMultiLoadFromFile.Text = "檔案讀取";
            this.rbMultiLoadFromFile.UseVisualStyleBackColor = true;
            this.rbMultiLoadFromFile.CheckedChanged += new System.EventHandler(this.rbMultiLoadFromFile_CheckedChanged);
            // 
            // btnMultiLoadFromInternet
            // 
            this.btnMultiLoadFromInternet.Image = global::CloudFlareWARPTool.Properties.Resources.Download;
            this.btnMultiLoadFromInternet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMultiLoadFromInternet.Location = new System.Drawing.Point(165, 50);
            this.btnMultiLoadFromInternet.Name = "btnMultiLoadFromInternet";
            this.btnMultiLoadFromInternet.Size = new System.Drawing.Size(135, 60);
            this.btnMultiLoadFromInternet.TabIndex = 3;
            this.btnMultiLoadFromInternet.Text = "下載代理列表";
            this.btnMultiLoadFromInternet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMultiLoadFromInternet.UseVisualStyleBackColor = true;
            this.btnMultiLoadFromInternet.Click += new System.EventHandler(this.btnMultiLoadFromInternet_Click);
            // 
            // btnMultiLoadFromFile
            // 
            this.btnMultiLoadFromFile.Enabled = false;
            this.btnMultiLoadFromFile.Image = global::CloudFlareWARPTool.Properties.Resources.File;
            this.btnMultiLoadFromFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMultiLoadFromFile.Location = new System.Drawing.Point(15, 50);
            this.btnMultiLoadFromFile.Name = "btnMultiLoadFromFile";
            this.btnMultiLoadFromFile.Size = new System.Drawing.Size(135, 60);
            this.btnMultiLoadFromFile.TabIndex = 1;
            this.btnMultiLoadFromFile.Text = "讀取代理列表";
            this.btnMultiLoadFromFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMultiLoadFromFile.UseVisualStyleBackColor = true;
            this.btnMultiLoadFromFile.Click += new System.EventHandler(this.btnMultiLoadFromFile_Click);
            // 
            // labelMultiThread
            // 
            this.labelMultiThread.AutoSize = true;
            this.labelMultiThread.Location = new System.Drawing.Point(15, 70);
            this.labelMultiThread.Name = "labelMultiThread";
            this.labelMultiThread.Size = new System.Drawing.Size(65, 12);
            this.labelMultiThread.TabIndex = 3;
            this.labelMultiThread.Text = "執行緒數量";
            // 
            // chkMultiHideId
            // 
            this.chkMultiHideId.AutoSize = true;
            this.chkMultiHideId.Location = new System.Drawing.Point(269, 13);
            this.chkMultiHideId.Name = "chkMultiHideId";
            this.chkMultiHideId.Size = new System.Drawing.Size(63, 16);
            this.chkMultiHideId.TabIndex = 1;
            this.chkMultiHideId.Text = "隱藏 ID";
            this.chkMultiHideId.UseVisualStyleBackColor = true;
            this.chkMultiHideId.CheckedChanged += new System.EventHandler(this.chkMultiHideId_CheckedChanged);
            // 
            // txtMultiId
            // 
            this.txtMultiId.Location = new System.Drawing.Point(17, 35);
            this.txtMultiId.Name = "txtMultiId";
            this.txtMultiId.Size = new System.Drawing.Size(315, 22);
            this.txtMultiId.TabIndex = 2;
            // 
            // labelMultiId
            // 
            this.labelMultiId.AutoSize = true;
            this.labelMultiId.Location = new System.Drawing.Point(15, 15);
            this.labelMultiId.Name = "labelMultiId";
            this.labelMultiId.Size = new System.Drawing.Size(53, 12);
            this.labelMultiId.TabIndex = 0;
            this.labelMultiId.Text = "WARP ID";
            // 
            // tpOther
            // 
            this.tpOther.Controls.Add(this.btnRestart);
            this.tpOther.Location = new System.Drawing.Point(4, 22);
            this.tpOther.Name = "tpOther";
            this.tpOther.Size = new System.Drawing.Size(351, 480);
            this.tpOther.TabIndex = 2;
            this.tpOther.Text = "設定";
            this.tpOther.UseVisualStyleBackColor = true;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.LightYellow;
            this.btnRestart.Location = new System.Drawing.Point(75, 30);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(200, 30);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "重新啟動程式";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // timerSingle
            // 
            this.timerSingle.Interval = 1000;
            this.timerSingle.Tick += new System.EventHandler(this.timerSingle_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 506);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Cloud Flare WARP 流量工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tcMain.ResumeLayout(false);
            this.tpSingle.ResumeLayout(false);
            this.tpSingle.PerformLayout();
            this.gbSingleResult.ResumeLayout(false);
            this.gbSingleResult.PerformLayout();
            this.tpMulti.ResumeLayout(false);
            this.tpMulti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiThread)).EndInit();
            this.gbMultiResult.ResumeLayout(false);
            this.gbMultiResult.PerformLayout();
            this.gbMultiProxy.ResumeLayout(false);
            this.gbMultiProxy.PerformLayout();
            this.tpOther.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpSingle;
        private System.Windows.Forms.TabPage tpMulti;
        private System.Windows.Forms.NumericUpDown numMultiThread;
        private System.Windows.Forms.GroupBox gbMultiResult;
        private System.Windows.Forms.Label labelMultiAddFlow;
        private System.Windows.Forms.Label labelMultiResult;
        private System.Windows.Forms.Button btnMultiStop;
        private System.Windows.Forms.Button btnMultiStart;
        private System.Windows.Forms.Label labelMultiProxyCount;
        private System.Windows.Forms.GroupBox gbMultiProxy;
        private System.Windows.Forms.RadioButton rbMultiLoadFromInternet;
        private System.Windows.Forms.RadioButton rbMultiLoadFromFile;
        private System.Windows.Forms.Button btnMultiLoadFromInternet;
        private System.Windows.Forms.Button btnMultiLoadFromFile;
        private System.Windows.Forms.Label labelMultiThread;
        private System.Windows.Forms.CheckBox chkMultiHideId;
        private System.Windows.Forms.TextBox txtMultiId;
        private System.Windows.Forms.Label labelMultiId;
        private System.Windows.Forms.Button btnSingleStop;
        private System.Windows.Forms.Button btnSingleStart;
        private System.Windows.Forms.CheckBox chkSingleHideId;
        private System.Windows.Forms.TextBox txtSingleId;
        private System.Windows.Forms.Label labelSingleId;
        private System.Windows.Forms.Label labelSingleStatus;
        private System.Windows.Forms.GroupBox gbSingleResult;
        private System.Windows.Forms.Label labelSingleAddFlow;
        private System.Windows.Forms.Label labelSingleResult;
        private System.Windows.Forms.CheckBox chkMultiAutomaticUpdateProxyListFromInternet;
        private System.Windows.Forms.Timer timerSingle;
        private System.Windows.Forms.TabPage tpOther;
        private System.Windows.Forms.Button btnRestart;
    }
}

