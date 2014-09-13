using Empires.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Empires.forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Text = "Main Menu - " + Finals.PROJECT_NAME + " " + Finals.PROJECT_VERSION;
        }

        private void btn_ManagePackages_Click(object sender, EventArgs e)
        {
            new PackageManager().Show();
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            new NewGame().Show();
        }
    }
}
