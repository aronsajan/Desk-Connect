using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using DeskConnectActiveListener.Logger;

namespace DeskConnectActiveListener
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
           
            Application.Run(new ActivePage());
            
           
           
           
         
            
        }

        
    }
}
