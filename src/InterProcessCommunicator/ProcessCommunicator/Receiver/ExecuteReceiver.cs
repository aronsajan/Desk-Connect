using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace InterProcessCommunicator.ProcessCommunicator.Receiver
{
   public class ExecuteReceiver
    {
       public ReceivingParams Parameters
       {
           get;
           set;
       }

       public string ReceivedMessage
       {
           get;
           set;
       }
       TcpListener Receiver;
       public TcpListener Listner
       {
           get
           {
               return Receiver;
           }
       }
       public void ReceiveData()
       {
           Receiver = new TcpListener(Parameters.Channel);
           Receiver.Start();
           TcpClient Client = Receiver.AcceptTcpClient();
           Receiver.Stop();
           NetworkStream ReceiveStream = Client.GetStream();
           int data;
           List<byte> RawDataList = new List<byte>(); 
           while ((data = ReceiveStream.ReadByte()) != -1)
           {
               RawDataList.Add((byte)data);
           }
           ReceiveStream.Flush();
           Client.Close();
           byte[] RawDataArray = new byte[RawDataList.Count];
           int DataIndex = 0;
           foreach (byte Data in RawDataList)
           {
               RawDataArray[DataIndex++] = Data;
           }
           UnicodeEncoding Unicode = new UnicodeEncoding();
           string UnicodeText = Unicode.GetString(RawDataArray);
           ReceivedMessage = UnicodeText;
           Parameters.DataReceived = true;   
       }
    }
}
