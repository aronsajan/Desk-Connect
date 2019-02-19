using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Configuration;

namespace DeskConnectEngine.CoreSystem.DeskConnectSubsystem.SystemListDataRepository
{
    public class ConfigurationManager
    {
        string RepositoryFile;
        public ConfigurationManager()
        {
            RepositoryFile = Environment.CurrentDirectory + "\\" + ConfigurationSettings.AppSettings["RepositoryFile"];
        }
        public void AddToRepository(string SystemName)
        {
            SystemRepositoryRoot RepositoryManager = ReadRepository();
            SystemAttributes SystemAttrib = new SystemAttributes();
            SystemAttrib.SystemName = SystemName;
            RepositoryManager.SystemRepository.Add(SystemAttrib);
            SaveRepository(RepositoryManager);
           

        }

        private void SaveRepository(SystemRepositoryRoot RepositoryManager)
        {
            XmlSerializer Serializer = new XmlSerializer(typeof(SystemRepositoryRoot));
            FileStream RepositoryWrite = new FileStream(RepositoryFile, FileMode.Create, FileAccess.Write);
            Serializer.Serialize(RepositoryWrite, RepositoryManager);
            RepositoryWrite.Close();
        }

        public SystemRepositoryRoot ReadRepository()
        {
            XmlSerializer Deserialize = new XmlSerializer(typeof(SystemRepositoryRoot));
            
            SystemRepositoryRoot RepositoryManager = new SystemRepositoryRoot();
            try
            {
                if (File.Exists(RepositoryFile))
                {
                    FileStream RepositoryFileRead = new FileStream(RepositoryFile, FileMode.Open, FileAccess.Read);
                    RepositoryManager = Deserialize.Deserialize(RepositoryFileRead) as SystemRepositoryRoot;
                    RepositoryFileRead.Close();
                }
            }
            catch (Exception Ex)
            {
                RepositoryManager = new SystemRepositoryRoot(); 
            }
            return RepositoryManager;

        }

        public void RemoveFromRepository(string MachineName)
        {
            bool MachineFound = false;
            SystemRepositoryRoot SystemListRoot = ReadRepository();
            SystemAttributes TargetMachine = SystemListRoot.SystemRepository.RetrieveMachine(MachineName, ref MachineFound);
            if (MachineFound)
            {
                SystemListRoot.SystemRepository.Delete(TargetMachine);
                SaveRepository(SystemListRoot);
            }
        }


    }
}
