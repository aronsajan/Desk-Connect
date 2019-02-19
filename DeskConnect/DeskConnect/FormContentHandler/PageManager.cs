using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeskConnect.FormContentHandler
{
    class PageManager
    {
        public void FillContent(UserControl NewContent,Home HomePage)
        {

            if (HomePage.ContentPanel.Controls.Count > 0)
            {
                UserControl CurrentControl = HomePage.ContentPanel.Controls[0] as UserControl;
                CurrentControl.Dispose();
            }
            HomePage.ContentPanel.Controls.Add(NewContent);

        }
        
    }
}
