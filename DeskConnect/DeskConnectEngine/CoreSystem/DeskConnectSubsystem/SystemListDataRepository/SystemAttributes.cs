using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DeskConnectEngine.CoreSystem.DeskConnectSubsystem.SystemListDataRepository
{
    [XmlType]
    public class SystemAttributes
    {
        private string _systemName;
        [XmlAttribute]
        public string SystemName
        {
            get
            {
                return _systemName;
            }
            set
            {
                _systemName = value;
            }
        }
    }
}
