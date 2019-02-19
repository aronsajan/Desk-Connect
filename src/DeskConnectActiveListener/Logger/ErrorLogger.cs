using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DeskConnectActiveListener.Logger
{
   static class ErrorLogger
    {
        public static void Log(string Filename, Exception ExceptionDetails)
        {
            FileStream WriteLog = new FileStream(Filename, FileMode.Append, FileAccess.Write);
            string ErrorData = DateTime.Now.ToString() + " : " + ExceptionDetails.Message;
            byte[] ErrorByte = new ASCIIEncoding().GetBytes(ErrorData);
            WriteLog.Write(ErrorByte, 0, ErrorByte.Length);
            WriteLog.Close();
        }
    }
}
