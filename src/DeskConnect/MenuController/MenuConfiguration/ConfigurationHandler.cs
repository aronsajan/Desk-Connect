using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Configuration;

namespace DeskConnect.MenuController.MenuConfiguration
{
    class ConfigurationHandler
    {
        public void Save(MenuList mnuList)
        {
            XmlSerializer Serialize = new XmlSerializer(typeof(MenuList));
            FileStream WriteConfig = new FileStream(Environment.CurrentDirectory + "\\" + ConfigurationSettings.AppSettings["MenuConfig"], FileMode.Create, FileAccess.Write);
            Serialize.Serialize(WriteConfig, mnuList);
            WriteConfig.Close();
        }

        public MenuList RetrieveConfiguration
        {
            get
            {
                XmlSerializer Deserialize = new XmlSerializer(typeof(MenuList));
                FileStream ReadConfig = new FileStream(Environment.CurrentDirectory + "\\" + ConfigurationSettings.AppSettings["MenuConfig"], FileMode.Open, FileAccess.Read);
                MenuList CurrentMenuList = Deserialize.Deserialize(ReadConfig) as MenuList;
                return CurrentMenuList;
            }
        }
    }
}
