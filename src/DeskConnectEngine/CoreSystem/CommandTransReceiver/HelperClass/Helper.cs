using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeskConnectEngine.CoreSystem.CommandTransReceiver.HelperClass
{
    static class Helper
    {

        public static byte[] AddToByte(byte[] ContentStream, byte[] ExistingStream)
        {
            int StreamLength = ContentStream.Length + ExistingStream.Length;
            byte[] NewStream = new byte[StreamLength];
            int counter = 0;
            for (int index = 0; index < ExistingStream.Length; ++index)
            {
                NewStream[index] = ExistingStream[index];
            }

            for (int index = ExistingStream.Length; index < StreamLength; ++index)
            {
                NewStream[index] = ContentStream[counter];
                ++counter;
            }
            return NewStream;

        }

        public static byte[] ExtractBytes(int StartIndex, int EndIndex, byte[] DataStream)
        {
            int Length = (EndIndex - StartIndex) + 1;
            byte[] NewData = new byte[Length];
            int counter = 0;
            for (int index = StartIndex; index <= EndIndex; ++index)
            {
                NewData[counter] = DataStream[index];
                ++counter;
            }
            return NewData;
        }
    }
}
