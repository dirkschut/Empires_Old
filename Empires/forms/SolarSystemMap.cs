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
    public partial class SolarSystemMap : Form
    {
        public static int zoomLevel = 1;
        public static int offsetX = 0;
        public static int offsetY = 0;

        public static Font font = new Font("Ariel", 8);

        public SolarSystemMap()
        {
            InitializeComponent();
        }

        private void SolarSystemMap_Load(object sender, EventArgs e)
        {
            this.cb_SolarSystem.Items.Clear();
            foreach (SolarSystem solarSystem in Objects.game.data.solarSystems)
            {
                this.cb_SolarSystem.Items.Add(solarSystem.ID + " - " + solarSystem.name);
            }
        }

        private void drawSolarSystem()
        {
            if (cb_SolarSystem.SelectedIndex >= 0)
            {
                Double sizePerPixelX = (Double)this.Width / (Finals.GALAXY_SIZE * 2);
                Double sizePerPixelY = (Double)this.Height / (Finals.GALAXY_SIZE * 2);

                System.Drawing.SolidBrush blackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                System.Drawing.SolidBrush greenBrush = new SolidBrush(System.Drawing.Color.Green);
                Pen greenPen = new Pen(Color.Green);

                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();

                formGraphics.FillRectangle(blackBrush, new Rectangle(0, 0, this.Width, this.Height));

                foreach (Body body in Objects.game.data.bodies)
                {
                    if (body.solarSystem == cb_SolarSystem.SelectedIndex)
                    {
                        int drawAtX = (int)(sizePerPixelX * (body.distanceFromCentre * (Math.Cos((body.position % 360) * Math.PI / 180)) * zoomLevel + Finals.GALAXY_SIZE)) + offsetX * zoomLevel;
                        int drawAtY = (int)(sizePerPixelY * (body.distanceFromCentre * (Math.Sin((body.position % 360) * Math.PI / 180)) * zoomLevel + Finals.GALAXY_SIZE)) + offsetY * zoomLevel;
                        Boolean drawBody = true;
                        Boolean drawName = false;
                        Boolean drawOrbit = false;

                        switch (body.type)
                        {
                            case Body.TYPE_PLANET:
                                if (cb_PlanetNames.Checked)
                                    drawName = true;
                                if (cb_PlanetOrbits.Checked)
                                    drawOrbit = true;
                                break;
                            case Body.TYPE_ASTROID:
                                if (cb_AsteroidNames.Checked)
                                    drawName = true;
                                if (cb_AsteroidOrbits.Checked)
                                    drawOrbit = true;
                                break;
                        }

                        if (drawBody)
                        {
                            formGraphics.FillEllipse(greenBrush, drawAtX - 1, drawAtY - 1, 3, 3);
                        }

                        if (drawName)
                        {
                            formGraphics.DrawString(body.ID + " - " + body.name, font, greenBrush, drawAtX, drawAtY);
                        }

                        if (drawOrbit)
                        {
                            int drawEllipseX = (int)((((Finals.GALAXY_SIZE - body.distanceFromCentre * zoomLevel)) * sizePerPixelX) + offsetX * zoomLevel);
                            int drawEllipseY = (int)((((Finals.GALAXY_SIZE - body.distanceFromCentre * zoomLevel)) * sizePerPixelY) + offsetY * zoomLevel);
                            formGraphics.DrawEllipse(greenPen, drawEllipseX, drawEllipseY, (int)((2 * body.distanceFromCentre) * sizePerPixelX) * zoomLevel, (int)((2 * body.distanceFromCentre) * sizePerPixelY) * zoomLevel);
                        }
                    }
                }

                greenPen.Dispose();
                blackBrush.Dispose();
                formGraphics.Dispose();
            }
        }

        private void cb_SolarSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawSolarSystem();
        }

        private void btn_ZoomIn_Click(object sender, EventArgs e)
        {
            zoomLevel++;
            drawSolarSystem();
        }

        private void btn_ZoomOut_Click(object sender, EventArgs e)
        {
            if (zoomLevel > 1)
            {
                zoomLevel--;
                drawSolarSystem();
            }
        }

        private void btn_MoveUp_Click(object sender, EventArgs e)
        {
            offsetY += 100;
            drawSolarSystem();
        }

        private void btn_MoveDown_Click(object sender, EventArgs e)
        {
            offsetY -= 100;
            drawSolarSystem();
        }

        private void btn_MoveLeft_Click(object sender, EventArgs e)
        {
            offsetX += 100;
            drawSolarSystem();
        }

        private void btn_MoveRight_Click(object sender, EventArgs e)
        {
            offsetX -= 100;
            drawSolarSystem();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            offsetX = 0;
            offsetY = 0;
            zoomLevel = 1;
            drawSolarSystem();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            drawSolarSystem();
        }

        private void cb_PlanetNames_CheckedChanged(object sender, EventArgs e)
        {
            drawSolarSystem();
        }

        private void cb_PlanetOrbits_CheckedChanged(object sender, EventArgs e)
        {
            drawSolarSystem();
        }

        private void cb_AsteroidNames_CheckedChanged(object sender, EventArgs e)
        {
            drawSolarSystem();
        }

        private void cb_AsteroidOrbits_CheckedChanged(object sender, EventArgs e)
        {
            drawSolarSystem();
        }

        private void cb_StarName_CheckedChanged(object sender, EventArgs e)
        {
            drawSolarSystem();
        }

        private void cb_PlanetDraw_CheckedChanged(object sender, EventArgs e)
        {
            drawSolarSystem();
        }

        private void cb_AsteroidDraw_CheckedChanged(object sender, EventArgs e)
        {
            drawSolarSystem();
        }
    }
}
