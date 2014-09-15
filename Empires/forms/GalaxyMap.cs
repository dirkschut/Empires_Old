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
    public partial class GalaxyMap : Form
    {
        public GalaxyMap()
        {
            InitializeComponent();
        }

        private void GalaxyMap_Load(object sender, EventArgs e)
        {
            this.cb_Galaxy.Items.Clear();
            foreach (Galaxy galaxy in Objects.game.data.galaxies)
            {
                this.cb_Galaxy.Items.Add(galaxy.ID + " - " + galaxy.name);
            }
        }
    }
}
