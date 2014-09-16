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
    public partial class UniverseList : Form
    {
        public UniverseList()
        {
            InitializeComponent();
        }

        private void UniverseList_Load(object sender, EventArgs e)
        {
            this.lb_Universes.Items.Clear();
            foreach (Universe universe in Objects.game.data.universes)
            {
                this.lb_Universes.Items.Add(universe.ID + " - " + universe.name);
            }
        }

        private void btn_InspectUniverse_Click(object sender, EventArgs e)
        {
            new InspectUniverse().Show();
        }
    }
}
