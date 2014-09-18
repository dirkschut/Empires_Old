using Empires.Game.GameWorld;
using Empires.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            fillList();

            this.cb_Universe.Items.Clear();
            foreach (Universe universe in Objects.game.data.universes)
            {
                this.cb_Universe.Items.Add(universe.ID + " - " + universe.name);
            }
        }

        public GalaxyList setUniverse(int universe)
        {
            this.cb_SpecificUniverse.Checked = true;
            if (universe >= 0 && universe <= this.cb_Universe.Items.Count)
            {
                this.cb_Universe.SelectedIndex = universe;
            }
            
            return this;
        }

        private void fillList()
        {
            foreach (Galaxy galaxy in Objects.game.data.galaxies)
            {
                if (this.cb_SpecificUniverse.Checked)
                {
                    if (this.cb_Universe.SelectedIndex >= 0)
                    {
                        if (this.cb_Universe.SelectedIndex == galaxy.universe)
                        {
                            lb_Galaxies.Items.Add(galaxy.ID + " - " + galaxy.name);
                        }
                    }
                }
                else
                {
                    lb_Galaxies.Items.Add(galaxy.ID + " - " + galaxy.name);
                }
            }
        }
    }
}
