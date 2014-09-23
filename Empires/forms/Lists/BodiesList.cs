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
            
        }
    }
}
