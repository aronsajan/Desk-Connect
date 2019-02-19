using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Media;
using System.Diagnostics;

namespace ExitApplication
{
    public partial class ExitPage : UserControl
    {
        readonly string MediaDir;
        public ExitPage()
        {
            MediaDir = Environment.CurrentDirectory + ConfigurationSettings.AppSettings["MediaSource"];
            InitializeComponent();
        }

        private void ExitPage_Load(object sender, EventArgs e)
        {
            
            
        }

        
        private void YesButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Validate();
            YesButton.Enabled = false;
            this.ParentForm.Enabled = false;
           
            Process.GetCurrentProcess().Kill();
            Application.Exit();

        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Visible = false;
            this.ParentForm.Visible = true;
        }

       
    }
}
