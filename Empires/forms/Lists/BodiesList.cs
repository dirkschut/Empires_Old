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
    public partial class BodiesList : Form
    {
        public BodiesList()
        {
            InitializeComponent();
        }

        private void BodiesList_Load(object sender, EventArgs e)
        {
            this.lb_Bodies.Items.Clear();
            foreach (Body body in Objects.game.data.bodies)
            {
                this.lb_Bodies.Items.Add(body.ID + " - " + body.name);
            }
        }

        public void setUniverse(int universe)
        {
            this.cb_SpecificGalaxy.Checked = false;
            this.cb_SpecificSolarSystem.Checked = false;
            this.cb_SpecificUniverse.Checked = true;
            loadUniverses();
            this.cb_Universe.SelectedIndex = universe;
            loadData();
        }

        private void loadData()
        {
            this.lb_Bodies.Items.Clear();
            foreach (Body body in Objects.game.data.bodies)
            {
                if (this.cb_Universe.SelectedIndex >= 0)
                {
                    int solarSystem = body.solarSystem;
                    int galaxy = Objects.game.data.solarSystems[solarSystem].galaxy;
                    int universe = Objects.game.data.galaxies[galaxy].universe;

                    if (this.cb_SpecificSolarSystem.Checked)
                    {
                        if (solarSystem == this.cb_Universe.SelectedIndex)
                        {
                            this.lb_Bodies.Items.Add(body.ID + " - " + body.name);
                        }
                    }
                    else if (this.cb_SpecificGalaxy.Checked)
                    {
                        if (galaxy == this.cb_Universe.SelectedIndex)
                        {
                            this.lb_Bodies.Items.Add(body.ID + " - " + body.name);
                        }
                    }
                    else if (this.cb_SpecificUniverse.Checked)
                    {
                        if (universe == this.cb_Universe.SelectedIndex)
                        {
                            this.lb_Bodies.Items.Add(body.ID + " - " + body.name);
                        }
                    }
                }
                else
                {
                    this.lb_Bodies.Items.Add(body.ID + " - " + body.name);
                }
            }
        }

        private void loadUniverses()
        {
            this.cb_Universe.Items.Clear();
            foreach (Universe universe in Objects.game.data.universes)
            {
                this.cb_Universe.Items.Add(universe.ID + " - " + universe.name);
            }
        }

        private void cb_SpecificUniverse_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_Universe.SelectedIndex >= 0)
            {
                loadData();
            }
        }

        private void cb_SpecificGalaxy_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_Universe.SelectedIndex >= 0)
            {
                loadData();
            }
        }

        private void cb_SpecificSolarSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_Universe.SelectedIndex >= 0)
            {
                loadData();
            }
        }

        private void cb_Universe_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
