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
    public partial class UniverseMap : Form
    {
        public UniverseMap()
        {
            InitializeComponent();
        }

        private void UniverseMap_Load(object sender, EventArgs e)
        {
            this.cb_Universe.Items.Clear();
            foreach (Universe universe in Objects.game.data.universes)
            {
                cb_Universe.Items.Add(universe.ID + " - " + universe.name);
            }
        }

        private void cb_Universe_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawUniverse();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            drawUniverse();
        }

        private void drawUniverse()
        {
            int sizePerPixelX = Finals.UNIVERSE_SIZE * 2 / this.Width;
            int sizePerPixelY = Finals.UNIVERSE_SIZE * 2 / this.Height;

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();

            formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, this.Width, this.Height));

            myBrush.Dispose();
            formGraphics.Dispose();
        }
    }
}
