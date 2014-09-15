namespace Empires.forms
{
    partial class GameMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ms_Menu = new System.Windows.Forms.MenuStrip();
            this.multiverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galaxiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solarSystemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.universeMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.universesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Menu
            // 
            this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multiverseToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.ms_Menu.Location = new System.Drawing.Point(0, 0);
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.Size = new System.Drawing.Size(128, 24);
            this.ms_Menu.TabIndex = 0;
            this.ms_Menu.Text = "menuStrip1";
            // 
            // multiverseToolStripMenuItem
            // 
            this.multiverseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.universesToolStripMenuItem,
            this.universeMapToolStripMenuItem,
            this.galaxiesToolStripMenuItem,
            this.solarSystemsToolStripMenuItem,
            this.bodiesToolStripMenuItem});
            this.multiverseToolStripMenuItem.Name = "multiverseToolStripMenuItem";
            this.multiverseToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.multiverseToolStripMenuItem.Text = "Multiverse";
            // 
            // galaxiesToolStripMenuItem
            // 
            this.galaxiesToolStripMenuItem.Name = "galaxiesToolStripMenuItem";
            this.galaxiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.galaxiesToolStripMenuItem.Text = "Galaxies";
            this.galaxiesToolStripMenuItem.Click += new System.EventHandler(this.galaxiesToolStripMenuItem_Click);
            // 
            // solarSystemsToolStripMenuItem
            // 
            this.solarSystemsToolStripMenuItem.Name = "solarSystemsToolStripMenuItem";
            this.solarSystemsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.solarSystemsToolStripMenuItem.Text = "Solar Systems";
            this.solarSystemsToolStripMenuItem.Click += new System.EventHandler(this.solarSystemsToolStripMenuItem_Click);
            // 
            // bodiesToolStripMenuItem
            // 
            this.bodiesToolStripMenuItem.Name = "bodiesToolStripMenuItem";
            this.bodiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bodiesToolStripMenuItem.Text = "Bodies";
            this.bodiesToolStripMenuItem.Click += new System.EventHandler(this.bodiesToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // universeMapToolStripMenuItem
            // 
            this.universeMapToolStripMenuItem.Name = "universeMapToolStripMenuItem";
            this.universeMapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.universeMapToolStripMenuItem.Text = "Universe Map";
            this.universeMapToolStripMenuItem.Click += new System.EventHandler(this.universeMapToolStripMenuItem_Click);
            // 
            // universesToolStripMenuItem
            // 
            this.universesToolStripMenuItem.Name = "universesToolStripMenuItem";
            this.universesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.universesToolStripMenuItem.Text = "Universe List";
            this.universesToolStripMenuItem.Click += new System.EventHandler(this.universesToolStripMenuItem_Click);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(128, 25);
            this.Controls.Add(this.ms_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameMenu";
            this.Text = "Game Menu";
            this.ms_Menu.ResumeLayout(false);
            this.ms_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_Menu;
        private System.Windows.Forms.ToolStripMenuItem multiverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galaxiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solarSystemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bodiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem universesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem universeMapToolStripMenuItem;

    }
}