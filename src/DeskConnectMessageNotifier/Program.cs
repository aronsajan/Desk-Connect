using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DeskConnectMessageNotifier
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MessageNotifierWindow NotifierWindow = new MessageNotifierWindow();
            NotifierWindow.Message = GenerateMessage(args);
            Application.Run(NotifierWindow);
        }

        private static string GenerateMessage(string[] MsgString)
        {
            string GeneratedMessage="";
            foreach (string MsgEntity in MsgString)
            {
                GeneratedMessage =GeneratedMessage+" "+MsgEntity;
            }
            return GeneratedMessage;
        }
    }
}
