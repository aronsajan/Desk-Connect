using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeskConnectMessageNotifier
{
    public partial class MessageNotifierWindow : Form
    {
        public MessageNotifierWindow()
        {
            InitializeComponent();
        }

      

        private void MessageNotifierWindow_Load(object sender, EventArgs e)
        {
            NotifyText.Text = Message;
        }
        public string Message
        {
            get;
            set;
        }

        private void NotifyText_TextChanged(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
