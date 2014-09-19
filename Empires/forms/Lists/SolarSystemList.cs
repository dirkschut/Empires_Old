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
            loadAll();
        }

        public void setUniverse(int universe)
        {
            this.cb_SpecificGalaxy.Checked = false;
            this.cb_SpecificUniverse.Checked = true;
            loadUniverses();
            this.cb_Universe.SelectedIndex = universe;
            loadFromUniverse();
        }

        private void loadUniverses()
        {
            this.cb_Universe.Items.Clear();
            foreach (Universe universe in Objects.game.data.universes)
            {
                this.cb_Universe.Items.Add(universe.ID + " - " + universe.name);
            }
        }

        private void loadFromUniverse()
        {
            if (this.cb_Universe.SelectedIndex >= 0)
            {
                this.lb_SolarSystems.Items.Clear();
                foreach (SolarSystem solarSystem in Objects.game.data.solarSystems)
                {
                    if (Objects.game.data.galaxies[solarSystem.galaxy].universe == this.cb_Universe.SelectedIndex)
                    {
                        this.lb_SolarSystems.Items.Add(solarSystem.ID + " - " + solarSystem.name);
                    }
                }
            }
        }

        private void loadGalaxies()
        {
            this.cb_Universe.Items.Clear();
            foreach (Galaxy galaxy in Objects.game.data.galaxies)
            {
                this.cb_Universe.Items.Add(galaxy.ID + " - " + galaxy.name);
            }
        }

        private void loadFromGalaxy()
        {
            if (this.cb_Universe.SelectedIndex >= 0)
            {
                this.lb_SolarSystems.Items.Clear();
                foreach (SolarSystem solarSystem in Objects.game.data.solarSystems)
                {
                    if (solarSystem.galaxy == this.cb_Universe.SelectedIndex)
                    {
                        this.lb_SolarSystems.Items.Add(solarSystem.ID + " - " + solarSystem.name);
                    }
                }
            }
        }

        private void loadAll()
        {
            this.lb_SolarSystems.Items.Clear();
            foreach (SolarSystem solarSystem in Objects.game.data.solarSystems)
            {
                this.lb_SolarSystems.Items.Add(solarSystem.ID + " - " + solarSystem.name);
            }
        }

        private void reload()
        {
            if (cb_SpecificUniverse.Checked && cb_SpecificGalaxy.Checked)
            {

            }
            else if (cb_SpecificUniverse.Checked && !cb_SpecificGalaxy.Checked)
            {
                loadUniverses();
                loadFromUniverse();
            }
            else if (!cb_SpecificUniverse.Checked && cb_SpecificGalaxy.Checked)
            {
                loadGalaxies();
                loadFromGalaxy();
            }
            else
            {
                loadAll();
            }
        }

        private void cb_SpecificGalaxy_CheckedChanged(object sender, EventArgs e)
        {
            reload();
        }

        private void cb_SpecificUniverse_CheckedChanged(object sender, EventArgs e)
        {
            reload();
        }

        private void cb_Universe_SelectedIndexChanged(object sender, EventArgs e)
        {
            reload();
        }
    }
}
