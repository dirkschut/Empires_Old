namespace Empires.forms
{
    partial class LoadGame
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
            this.lb_GameList = new System.Windows.Forms.ListBox();
            this.btn_LoadGame = new System.Windows.Forms.Button();
            this.btn_DeleteGame = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_GameList
            // 
            this.lb_GameList.FormattingEnabled = true;
            this.lb_GameList.Location = new System.Drawing.Point(13, 13);
            this.lb_GameList.Name = "lb_GameList";
            this.lb_GameList.Size = new System.Drawing.Size(210, 186);
            this.lb_GameList.TabIndex = 0;
            // 
            // btn_LoadGame
            // 
            this.btn_LoadGame.Location = new System.Drawing.Point(12, 205);
            this.btn_LoadGame.Name = "btn_LoadGame";
            this.btn_LoadGame.Size = new System.Drawing.Size(210, 23);
            this.btn_LoadGame.TabIndex = 1;
            this.btn_LoadGame.Text = "Load Game";
            this.btn_LoadGame.UseVisualStyleBackColor = true;
            this.btn_LoadGame.Click += new System.EventHandler(this.btn_LoadGame_Click);
            // 
            // btn_DeleteGame
            // 
            this.btn_DeleteGame.Location = new System.Drawing.Point(12, 236);
            this.btn_DeleteGame.Name = "btn_DeleteGame";
            this.btn_DeleteGame.Size = new System.Drawing.Size(106, 23);
            this.btn_DeleteGame.TabIndex = 2;
            this.btn_DeleteGame.Text = "Delete Game";
            this.btn_DeleteGame.UseVisualStyleBackColor = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(125, 236);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(97, 23);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // LoadGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 271);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_DeleteGame);
            this.Controls.Add(this.btn_LoadGame);
            this.Controls.Add(this.lb_GameList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoadGame";
            this.Text = "Load Game";
            this.Load += new System.EventHandler(this.LoadGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_GameList;
        private System.Windows.Forms.Button btn_LoadGame;
        private System.Windows.Forms.Button btn_DeleteGame;
        private System.Windows.Forms.Button btn_Refresh;
    }
}