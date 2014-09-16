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
    public partial class SolarSystemMap : Form
    {
        public SolarSystemMap()
        {
            InitializeComponent();
        }

        private void SolarSystemMap_Load(object sender, EventArgs e)
        {
            this.cb_SolarSystem.Items.Clear();
            foreach (SolarSystem solarSystem in Objects.game.data.solarSystems)
            {
                this.cb_SolarSystem.Items.Add(solarSystem.ID + " - " + solarSystem.name);
            }
        }
    }
}
