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
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Objects.game.save();
        }

        private void universesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UniverseList().Show();
        }

        private void galaxiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GalaxyList().Show();
        }

        private void solarSystemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SolarSystemList().Show();
        }

        private void bodiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BodiesList().Show();
        }

        private void universeMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UniverseMap().Show();
        }

        private void galaxyMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GalaxyMap().Show();
        }

        private void solarSystemMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SolarSystemMap().Show();
        }
    }
}
