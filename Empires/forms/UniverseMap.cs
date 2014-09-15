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
            if (this.cb_Universe.SelectedIndex >= 0)
            {
                Double sizePerPixelX = (Double)this.Width / (Finals.UNIVERSE_SIZE * 2);
                Double sizePerPixelY = (Double)this.Height / (Finals.UNIVERSE_SIZE * 2);

                System.Drawing.SolidBrush blackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                System.Drawing.SolidBrush greenBrush = new SolidBrush(System.Drawing.Color.Green);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();

                formGraphics.FillRectangle(blackBrush, new Rectangle(0, 0, this.Width, this.Height));

                foreach (Galaxy galaxy in Objects.game.data.galaxies)
                {

                    if (galaxy.universe == Objects.game.data.universes[this.cb_Universe.SelectedIndex].ID)
                    {
                        int drawAtX = (int)((galaxy.x + Finals.UNIVERSE_SIZE) * sizePerPixelX);
                        int drawAtY = (int)((galaxy.y + Finals.UNIVERSE_SIZE) * sizePerPixelY);

                        formGraphics.FillEllipse(greenBrush, drawAtX - 1, drawAtY - 1, 3, 3);
                    }
                    else
                    {
                        Debug.WriteLine("Test");
                    }
                }

                blackBrush.Dispose();
                formGraphics.Dispose();
            }
            
        }
    }
}
