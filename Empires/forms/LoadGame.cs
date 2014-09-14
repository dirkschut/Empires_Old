using Empires.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Empires.forms
{
    public partial class LoadGame : Form
    {
        String[] games;

        public LoadGame()
        {
            InitializeComponent();
        }

        private void LoadGame_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            String[] gameFiles = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Empires\\saves\\", "*.esav");
            games = new String[gameFiles.Length];
            lb_GameList.Items.Clear();

            for (int i = 0; i < gameFiles.Length; i++)
            {
                String[] pathParts = gameFiles[i].Split('\\');
                games[i] = pathParts[pathParts.Length - 1];
                lb_GameList.Items.Add(games[i]);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_LoadGame_Click(object sender, EventArgs e)
        {
            if (lb_GameList.SelectedIndex >= 0)
            {
                Objects.game = new Game.Game(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Empires\\saves\\" + games[lb_GameList.SelectedIndex]);
                Objects.game.load();
                new GameMenu().Show();
                this.Close();
            }
        }
    }
}
