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
    }
}
