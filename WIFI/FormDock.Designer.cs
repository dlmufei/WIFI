namespace WIFI
{
    partial class FormDock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDock));
            this.contextMSDock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUpValue = new System.Windows.Forms.Label();
            this.lbDownValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMSDock
            // 
            this.contextMSDock.Name = "contextMSDock";
            this.contextMSDock.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "上传";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "下载";
            // 
            // lbUpValue
            // 
            this.lbUpValue.AutoSize = true;
            this.lbUpValue.Location = new System.Drawing.Point(40, 6);
            this.lbUpValue.Name = "lbUpValue";
            this.lbUpValue.Size = new System.Drawing.Size(41, 12);
            this.lbUpValue.TabIndex = 3;
            this.lbUpValue.Text = "label3";
            // 
            // lbDownValue
            // 
            this.lbDownValue.AutoSize = true;
            this.lbDownValue.Location = new System.Drawing.Point(138, 6);
            this.lbDownValue.Name = "lbDownValue";
            this.lbDownValue.Size = new System.Drawing.Size(41, 12);
            this.lbDownValue.TabIndex = 4;
            this.lbDownValue.Text = "label3";
            // 
            // FormDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 23);
            this.ContextMenuStrip = this.contextMSDock;
            this.Controls.Add(this.lbDownValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUpValue);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormDock";
            this.TopMost = true;
            this.DoubleClick += new System.EventHandler(this.FormDock_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMSDock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUpValue;
        private System.Windows.Forms.Label lbDownValue;
    }
}