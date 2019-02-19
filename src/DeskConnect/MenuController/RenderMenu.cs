using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeskConnect.MenuController.MenuConfiguration;
using System.Configuration;
using System.Drawing;

namespace DeskConnect.MenuController
{
    class RenderMenu
    {
        public void Render()
        {
            this.FrameworkForm.MenuStrip.Items.Clear();
            MenuList ContextMenu = new ConfigurationHandler().RetrieveConfiguration;
            int Index = -1;
            foreach (Menu mnuObject in ContextMenu)
            {
                ++Index;
                FrameworkForm.MenuStrip.Items.Add(mnuObject.Name);
                FrameworkForm.MenuStrip.Items[Index].Image = Image.FromFile(Environment.CurrentDirectory + ConfigurationSettings.AppSettings["MenuFolder"] + mnuObject.Icon);

            }
        }

        public Home FrameworkForm
        {
            get;
            set;

        }

    }
}
