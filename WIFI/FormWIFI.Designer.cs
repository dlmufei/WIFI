namespace WIFI
{
    partial class FormWIFI
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWIFI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Pwd = new System.Windows.Forms.TextBox();
            this.bt_Creat = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboxAdapters = new System.Windows.Forms.ComboBox();
            this.lb_Up = new System.Windows.Forms.Label();
            this.lb_Down = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnHide = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "热点名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码(8位)";
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(10, 148);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(102, 23);
            this.bt_start.TabIndex = 2;
            this.bt_start.Text = "启动";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_Stop
            // 
            this.bt_Stop.Location = new System.Drawing.Point(161, 148);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(102, 23);
            this.bt_Stop.TabIndex = 3;
            this.bt_Stop.Text = "停止";
            this.bt_Stop.UseVisualStyleBackColor = true;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(79, 15);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(184, 21);
            this.tb_Name.TabIndex = 4;
            // 
            // tb_Pwd
            // 
            this.tb_Pwd.Location = new System.Drawing.Point(79, 48);
            this.tb_Pwd.Name = "tb_Pwd";
            this.tb_Pwd.PasswordChar = '*';
            this.tb_Pwd.Size = new System.Drawing.Size(184, 21);
            this.tb_Pwd.TabIndex = 5;
            // 
            // bt_Creat
            // 
            this.bt_Creat.Location = new System.Drawing.Point(10, 119);
            this.bt_Creat.Name = "bt_Creat";
            this.bt_Creat.Size = new System.Drawing.Size(102, 23);
            this.bt_Creat.TabIndex = 6;
            this.bt_Creat.Text = "创建";
            this.bt_Creat.UseVisualStyleBackColor = true;
            this.bt_Creat.Click += new System.EventHandler(this.bt_Creat_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(161, 119);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(102, 23);
            this.bt_Exit.TabIndex = 7;
            this.bt_Exit.Text = "退出";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(482, 222);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cboxAdapters);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(474, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "流量监控";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboxAdapters
            // 
            this.cboxAdapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdapters.FormattingEnabled = true;
            this.cboxAdapters.Location = new System.Drawing.Point(77, 26);
            this.cboxAdapters.Name = "cboxAdapters";
            this.cboxAdapters.Size = new System.Drawing.Size(322, 20);
            this.cboxAdapters.TabIndex = 3;
            this.cboxAdapters.SelectedIndexChanged += new System.EventHandler(this.cboxAdapters_SelectedIndexChanged);
            // 
            // lb_Up
            // 
            this.lb_Up.AutoSize = true;
            this.lb_Up.Location = new System.Drawing.Point(112, 232);
            this.lb_Up.Name = "lb_Up";
            this.lb_Up.Size = new System.Drawing.Size(41, 12);
            this.lb_Up.TabIndex = 2;
            this.lb_Up.Text = "label4";
            // 
            // lb_Down
            // 
            this.lb_Down.AutoSize = true;
            this.lb_Down.Location = new System.Drawing.Point(19, 232);
            this.lb_Down.Name = "lb_Down";
            this.lb_Down.Size = new System.Drawing.Size(41, 12);
            this.lb_Down.TabIndex = 1;
            this.lb_Down.Text = "label3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bt_Stop);
            this.tabPage2.Controls.Add(this.bt_Exit);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.bt_Creat);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tb_Pwd);
            this.tabPage2.Controls.Add(this.bt_start);
            this.tabPage2.Controls.Add(this.tb_Name);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(474, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "热点控制";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "网络适配器";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "  网络监控";
            this.notifyIcon1.Visible = true;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(395, 228);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 5;
            this.btnHide.Text = "隐藏";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // FormWIFI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 256);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lb_Down);
            this.Controls.Add(this.lb_Up);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormWIFI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网络控制(FLY)";
            this.Load += new System.EventHandler(this.FormWIFI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_Stop;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Pwd;
        private System.Windows.Forms.Button bt_Creat;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_Up;
        private System.Windows.Forms.Label lb_Down;
        private System.Windows.Forms.ComboBox cboxAdapters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnHide;
    }
}

