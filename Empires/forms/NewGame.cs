using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Empires.Game;
using Empires.IO.Packages;
using Empires.Lib;

namespace Empires.forms
{
    public partial class NewGame : Form
    {
        private Package[] packages;
        private Boolean[] packagesIn;

        public NewGame()
        {
            InitializeComponent();
        }

        private void NewGame_Load(object sender, EventArgs e)
        {
            refresh();

            this.tb_GameName.Text = "New Game";
            this.tb_ResourceModifier.Text = "1.0";
            this.tb_StartingPopulation.Text = "1000";
        }

        private void refresh()
        {
            packages = Packages.GetPackages();
            if (packagesIn != null)
            {
                if (packages.Length != packagesIn.Length)
                {
                    packagesIn = new Boolean[packages.Length];
                }
            }
            else
            {
                packagesIn = new Boolean[packages.Length];
            }

            lb_PackagesIn.Items.Clear();
            lb_PackagesNotIn.Items.Clear();

            for (int i = 0; i < packages.Length; i++)
            {
                if (packagesIn[i])
                {
                    lb_PackagesIn.Items.Add(packages[i].data.name);
                }
                else
                {
                    lb_PackagesNotIn.Items.Add(packages[i].data.name);
                }
            }
        }

        private void btn_CreateGame_Click(object sender, EventArgs e)
        {
            Game.Game game = new Game.Game();
            game.data.name = this.tb_GameName.Text;

            try
            {
                game.data.resourceModifier = Convert.ToDouble(this.tb_ResourceModifier.Text);
            }
            catch (Exception ex)
            {
                game.data.resourceModifier = 1.0;
            }

            try
            {
                game.data.startingPopulation = Convert.ToDouble(this.tb_StartingPopulation.Text);
            }
            catch (Exception ex)
            {
                game.data.startingPopulation = 1000;
            }

            int counter = 0;

            for (int i = 0; i < packages.Length; i++)
            {
                if (packagesIn[i])
                {
                    counter++;
                }
            }

            Package[] packagesToUse = new Package[counter];
            counter = 0;

            for (int i = 0; i < packages.Length; i++)
            {
                if (packagesIn[i])
                {
                    packagesToUse[counter] = packages[i];
                    counter++;
                }
            }

            game.data.packages = packagesToUse;

            Objects.game = game;
            Objects.game.onePackage();
            Objects.game.generate();
            Objects.game.save();
            Objects.game = null;
            this.Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_AddPackage_Click(object sender, EventArgs e)
        {
            if (lb_PackagesNotIn.SelectedIndex >= 0)
            {
                int counter = 0;
                for (int i = 0; i < packages.Length; i++)
                {
                    if (!packagesIn[i])
                    {
                        if (counter == lb_PackagesNotIn.SelectedIndex)
                        {
                            packagesIn[i] = true;
                            break;
                        }
                        counter++;
                    }
                }
            }
            refresh();
        }

        private void btn_RemovePackage_Click(object sender, EventArgs e)
        {
            if (lb_PackagesIn.SelectedIndex >= 0)
            {
                int counter = 0;
                for (int i = 0; i < packages.Length; i++)
                {
                    if (packagesIn[i])
                    {
                        if (counter == lb_PackagesIn.SelectedIndex)
                        {
                            packagesIn[i] = false;
                            break;
                        }
                        counter++;
                    }
                }
            }
            refresh();
        }
    }
}
