using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DeskConnect.MenuController.MenuConfiguration
{
    [XmlType]
    public class Menu
    {
        string _name, _dllnamespace, _icon;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string HandlerDLL
        {
            get
            {
                return _dllnamespace;
            }
            set
            {
                _dllnamespace = value;
            }
        }

        public string Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value;
            }
        }
    }
}
