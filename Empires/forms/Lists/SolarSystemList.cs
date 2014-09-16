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
    public partial class SolarSystemList : Form
    {
        public SolarSystemList()
        {
            InitializeComponent();
        }

        private void SolarSystemList_Load(object sender, EventArgs e)
        {
            this.lb_SolarSystems.Items.Clear();
            foreach (SolarSystem solarSystem in Objects.game.data.solarSystems)
            {
                this.lb_SolarSystems.Items.Add(solarSystem.ID + " - " + solarSystem.name);
            }
        }
    }
}
