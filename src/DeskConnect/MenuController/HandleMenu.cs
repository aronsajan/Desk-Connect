using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeskConnect.MenuController.MenuConfiguration;
using DeskConnect.FormContentHandler;
using System.Windows.Forms;

namespace DeskConnect.MenuController
{
    class HandleMenu
    {
        public string SelectedMenu
        {
            get;
            set;
        }

        public void LoadPage()
        {
            RetrieveMenu MenuObj = new RetrieveMenu();
            PageManager ReloadPage = new PageManager();
           
            UserControl NewPage = new UserControlFactory().InstantiatePage(MenuObj.Getmenu(SelectedMenu).HandlerDLL);
           
            ReloadPage.FillContent(NewPage,MainPage);
        }
        public Home MainPage
        {
            get;
            set;
        }
    }
}
