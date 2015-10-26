using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WIFI
{
    public partial class FormDock : Form
    {
        public FormDock()
        {
            InitializeComponent();
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int x = ScreenWidth - this.Width - 5;
            int y = ScreenHeight - this.Height - 5;

            this.SetDesktopLocation(x, y);
            //this.Location = new Point(x, y);
        }

        public void ShowInfo(string strUp,string strDown)
        {
            lbUpValue.Text = strUp;
            lbDownValue.Text = strDown;
        }

        private void FormDock_DoubleClick(object sender, EventArgs e)
        {
            this.Parent.Show();
        }
    }
}
