using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeskConnect.FormContentHandler
{
    class UserControlFactory
    {
        public UserControl InstantiatePage(string PageNamespace)
        {
            object PageObject =Activator.CreateInstance(Type.GetType(PageNamespace));
            return PageObject as UserControl;
        }
    }
}
