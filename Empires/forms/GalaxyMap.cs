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
    public partial class GalaxyMap : Form
    {
        public static int zoomLevel = 1;
        public static int offsetX = 0;
        public static int offsetY = 0;

        public static Font font = new Font("Ariel", 8);

        public GalaxyMap()
        {
            InitializeComponent();
        }

        private void GalaxyMap_Load(object sender, EventArgs e)
        {
            this.cb_Galaxy.Items.Clear();
            foreach (Galaxy galaxy in Objects.game.data.galaxies)
            {
                this.cb_Galaxy.Items.Add(galaxy.ID + " - " + galaxy.name);
            }
        }

        private void drawGalaxy()
        {
            if (this.cb_Galaxy.SelectedIndex >= 0)
            {
                Double sizePerPixelX = (Double)this.Width / (Finals.UNIVERSE_SIZE * 2);
                Double sizePerPixelY = (Double)this.Height / (Finals.UNIVERSE_SIZE * 2);

                System.Drawing.SolidBrush blackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                System.Drawing.SolidBrush greenBrush = new SolidBrush(System.Drawing.Color.Green);
                Pen greenPen = new Pen(Color.Green);

                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();

                formGraphics.FillRectangle(blackBrush, new Rectangle(0, 0, this.Width, this.Height));

                foreach (Galaxy galaxy in Objects.game.data.galaxies)
                {

                    if (galaxy.universe == Objects.game.data.universes[this.cb_Galaxy.SelectedIndex].ID)
                    {
                        int drawAtX = (int)(((galaxy.x * zoomLevel) + Finals.GALAXY_SIZE) * sizePerPixelX) + offsetX * zoomLevel;
                        int drawAtY = (int)(((galaxy.y * zoomLevel) + Finals.GALAXY_SIZE) * sizePerPixelY) + offsetY * zoomLevel;

                        formGraphics.FillEllipse(greenBrush, drawAtX - 1, drawAtY - 1, 3, 3);

                        if (cb_SolarSystemNames.Checked)
                        {
                            formGraphics.DrawString(galaxy.ID + " - " + galaxy.name, font, greenBrush, drawAtX, drawAtY);
                        }

                        if (cb_SolarSystemOrbits.Checked)
                        {
                            formGraphics.DrawLine(greenPen, new Point(drawAtX, drawAtY), new Point(drawAtX + -(int)galaxy.xSpeed * 3, drawAtY + -(int)galaxy.ySpeed * 3));
                        }
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

        private void btn_ZoomIn_Click(object sender, EventArgs e)
        {
            zoomLevel++;
            drawGalaxy();
        }

        private void btn_ZoomOut_Click(object sender, EventArgs e)
        {
            if (zoomLevel > 1)
            {
                zoomLevel--;
                drawGalaxy();
            }
        }

        private void btn_MoveUp_Click(object sender, EventArgs e)
        {
            offsetY += 100;
            drawGalaxy();
        }

        private void btn_MoveDown_Click(object sender, EventArgs e)
        {
            offsetY -= 100;
            drawGalaxy();
        }

        private void btn_MoveLeft_Click(object sender, EventArgs e)
        {
            offsetX += 100;
            drawGalaxy();
        }

        private void btn_MoveRight_Click(object sender, EventArgs e)
        {
            offsetX -= 100;
            drawGalaxy();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            offsetX = 0;
            offsetY = 0;
            zoomLevel = 1;
            drawGalaxy();
        }
    }
}
