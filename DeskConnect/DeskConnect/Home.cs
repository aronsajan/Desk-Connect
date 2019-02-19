using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DeskConnect.MenuController.MenuConfiguration;
using DeskConnect.MenuController;
using System.Configuration;

namespace DeskConnect
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Initialize();
         
        }
        private void Initialize()
        {
            LoadProgramDetails();
            RenderMenu Render = new RenderMenu();
            Render.FrameworkForm = this;
            Render.Render();
            LoadFirstMenuItem();
        }

        private void LoadProgramDetails()
        {
            this.Text = "Desk Connect - Version : " + ConfigurationSettings.AppSettings["Version"];
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            HandleMenu HandleSelected = new HandleMenu();
            HandleSelected.SelectedMenu = e.ClickedItem.Text;
            HandleSelected.MainPage = this;
            HandleSelected.LoadPage();
        }

        private void LoadFirstMenuItem()
        {
            if (MenuStrip.Items.Count > 0)
            {
                HandleMenu MenuHandler = new HandleMenu();
                MenuHandler.MainPage = this;
                MenuHandler.SelectedMenu = MenuStrip.Items[0].Text;
                MenuHandler.LoadPage();
            }
        }

        private void Home_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                Initialize();
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
       

       
       
    }
}
