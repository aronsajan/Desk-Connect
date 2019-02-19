using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Configuration;
using System.IO;

namespace DeskConnectEngine.CoreSystem.NetworkSubsystem.NetworkSender
{
    public class NetworkSend
    {
        TcpClient Client;
        int Port;
        public NetworkSend(int port)
        {
            Port = port;

        }
        public NetworkParameters NetworkParameters
        {
            get;
            set;
        }


        public void SendData(byte[] BufferData)
        {

            Client = new TcpClient(NetworkParameters.RemoteSystemName, Port);
            NetworkStream SendStream = Client.GetStream();

            SendStream.Write(BufferData, 0, BufferData.Length);
            SendStream.Flush();
            SendStream.Close();
            Client.Close();

        }
    }
}
