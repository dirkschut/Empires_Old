using Empires.Game.GameWorld;
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
    public partial class GalaxyList : Form
    {
        public GalaxyList()
        {
            InitializeComponent();
        }

        private void GalaxyList_Load(object sender, EventArgs e)
        {
            this.lb_Galaxies.Items.Clear();
            foreach (Galaxy galaxy in Objects.game.data.galaxies)
            {
                this.lb_Galaxies.Items.Add(galaxy.ID + " - " + galaxy.name);
            }
        }
    }
}
