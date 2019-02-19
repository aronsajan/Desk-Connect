using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Configuration;

namespace InterProcessCommunicator.ProcessCommunicator.Sender
{
   public class ExecuteSender
    {
        public SendingParameters Parameters
        {
            get;
            set;
        }
        public string LocalMachine
        {
            get
            {
                string LocalSystem=ConfigurationSettings.AppSettings["LocalSystem"];
                return LocalSystem;
            }

        }
        public void SendData()
        {
            
            TcpClient Client=new TcpClient(LocalMachine,Parameters.Channel);
            NetworkStream NetStream = Client.GetStream();
            UnicodeEncoding Unicode=new UnicodeEncoding();
            byte[] UnicodeMessage= Unicode.GetBytes(Parameters.MessageEntity);
            NetStream.Write(UnicodeMessage, 0, UnicodeMessage.Length);
            NetStream.Flush();
            NetStream.Close();
            Client.Close();
        }
    }
}
