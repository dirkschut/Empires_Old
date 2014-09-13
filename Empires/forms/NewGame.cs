using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Empires.Game;

namespace Empires.forms
{
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }

        private void NewGame_Load(object sender, EventArgs e)
        {
            this.tb_GameName.Text = "New Game";
            this.tb_ResourceModifier.Text = "1.0";
            this.tb_StartingPopulation.Text = "1000";
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

            game.save();
            this.Close();
        }
    }
}
