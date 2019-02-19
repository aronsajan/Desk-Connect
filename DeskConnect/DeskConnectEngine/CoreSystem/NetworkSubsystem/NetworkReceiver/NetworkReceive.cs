using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Configuration;

namespace DeskConnectEngine.CoreSystem.NetworkSubsystem.NetworkReceiver
{
    public class NetworkReceive
    {
        TcpListener Listener;
        TcpClient Client;
        int Port;
        public NetworkReceive(int port)
        {
            Port = port;
        }

        public byte[] ReceiveData()
        {
            Listener = new TcpListener(Port);
            Listener.Start();
            Client = Listener.AcceptTcpClient();
            Listener.Stop();
            IPEndPoint Sender = Client.Client.RemoteEndPoint as IPEndPoint;
           SenderIP = Sender.Address.ToString();
            NetworkStream ReceiveStream = Client.GetStream();
            List<byte> RawDataList = new List<byte>();
            int data, index;
            while ((data = ReceiveStream.ReadByte()) != -1)
            {
                RawDataList.Add((byte)data);
            }
            byte[] RawData = new byte[RawDataList.Count];
            for (index = 0; index < RawDataList.Count; ++index)
            {
                RawData[index] = RawDataList[index];
            }
            ReceiveStream.Flush();
            ReceiveStream.Close();
            Client.Close();

            return RawData;
        }

        public string SenderIP
        {
            get;
            set;
        }
    }
}
