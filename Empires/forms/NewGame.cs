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
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }

        private void NewGame_Load(object sender, EventArgs e)
        {
            this.tb_GameName.Text = "New Game";
            this.tb_ResourceModifier.Text = "1.0";
            this.tb_StartingPopulation.Text = "1000";
        }
    }
}
