using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeskConnect.MenuController.MenuConfiguration
{
    class RetrieveMenu
    {
        MenuList menuList;
        public RetrieveMenu()
        {
            menuList = new ConfigurationHandler().RetrieveConfiguration;
        }
        public Menu Getmenu(string mnuName)
        {
            Menu TargetMenu = new Menu(); 
            foreach (Menu menu in menuList)
            {
                if (menu.Name.CompareTo(mnuName) == 0)
                {
                    TargetMenu = menu;
                    break;
                }
            }
            return TargetMenu;
        }
    }
}
