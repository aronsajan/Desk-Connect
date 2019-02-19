using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections;


namespace DeskConnectEngine.CoreSystem.DeskConnectSubsystem.SystemListDataRepository
{
    [XmlType]
    public class SystemRepository : CollectionBase
    {
        public SystemAttributes this[int Index]
        {
            get
            {
                return List[Index] as SystemAttributes;
            }
        }


        public void Add(SystemAttributes SysAttribute)
        {
            List.Add(SysAttribute);
        }
        public void Delete(SystemAttributes SysAttribute)
        {
            List.Remove(SysAttribute);
        }
        public SystemAttributes RetrieveMachine(string SystemName, ref bool Found)
        {
            bool FoundFlag = false;
            SystemAttributes TargetMachine = new SystemAttributes(); 
            foreach (object MachineObj in List)
            {
                SystemAttributes MachineAttrib = MachineObj as SystemAttributes;
                if (MachineAttrib.SystemName.CompareTo(SystemName) == 0)
                {
                    FoundFlag = true;
                    TargetMachine = MachineAttrib;
                    break;
                }
            }
            Found = FoundFlag;
            return TargetMachine;
        }
        
    }
}
