using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections;

namespace DeskConnect.MenuController.MenuConfiguration
{
    [XmlRoot]
    [XmlType]
    public class MenuList:CollectionBase
    {
        public Menu this[int index]
        {
            get
            {
                return List[index] as Menu;
            }
        }
        public void Add(Menu NewMenuItem)
        {
            List.Add(NewMenuItem);
        }
    }
}
