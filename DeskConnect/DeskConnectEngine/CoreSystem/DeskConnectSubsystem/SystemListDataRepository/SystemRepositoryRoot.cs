using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DeskConnectEngine.CoreSystem.DeskConnectSubsystem.SystemListDataRepository
{
    [XmlRoot]
    [XmlType]
    public class SystemRepositoryRoot
    {
        private SystemRepository _SysRepository = new SystemRepository();
        public SystemRepository SystemRepository
        {
            get
            {
                return _SysRepository;
            }
        }
    }
}
