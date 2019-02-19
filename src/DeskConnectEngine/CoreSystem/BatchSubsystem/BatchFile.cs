using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DeskConnectEngine.CoreSystem.BatchSubsystem
{
    [Serializable]
    public class BatchFile
    {
        #region Constituents of a batch file
        private string BatchFileFullPath;
        private string FileContents;
        public string BatchFilename
        {
            get;
            set;
        }
        public BatchFile(string Filename)
        {
            this.BatchFileFullPath = Filename;
            BatchFilename = Path.GetFileName(Filename);
            ReadBatchFileContents(BatchFileFullPath);
        }

        private void ReadBatchFileContents(string Filename)
        {
            StreamReader ReadBatch = new StreamReader(Filename);
            string FileContents = ReadBatch.ReadToEnd();
            this.FileContents = FileContents;
            ReadBatch.Close();

        }


        public string BatchFileContents
        {
            get
            {
                return FileContents;
            }
        }
        
        #endregion
    }
}
