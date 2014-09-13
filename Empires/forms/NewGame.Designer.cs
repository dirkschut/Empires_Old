namespace Empires.forms
{
    partial class NewGame
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
            this.btn_CreateGame = new System.Windows.Forms.Button();
            this.lbl_GameName = new System.Windows.Forms.Label();
            this.lbl_startingPopulation = new System.Windows.Forms.Label();
            this.lbl_ResourceModifier = new System.Windows.Forms.Label();
            this.tb_GameName = new System.Windows.Forms.TextBox();
            this.tb_ResourceModifier = new System.Windows.Forms.TextBox();
            this.tb_StartingPopulation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_CreateGame
            // 
            this.btn_CreateGame.Location = new System.Drawing.Point(15, 200);
            this.btn_CreateGame.Name = "btn_CreateGame";
            this.btn_CreateGame.Size = new System.Drawing.Size(275, 23);
            this.btn_CreateGame.TabIndex = 0;
            this.btn_CreateGame.Text = "Create Game";
            this.btn_CreateGame.UseVisualStyleBackColor = true;
            // 
            // lbl_GameName
            // 
            this.lbl_GameName.AutoSize = true;
            this.lbl_GameName.Location = new System.Drawing.Point(12, 15);
            this.lbl_GameName.Name = "lbl_GameName";
            this.lbl_GameName.Size = new System.Drawing.Size(66, 13);
            this.lbl_GameName.TabIndex = 1;
            this.lbl_GameName.Text = "Game Name";
            // 
            // lbl_startingPopulation
            // 
            this.lbl_startingPopulation.AutoSize = true;
            this.lbl_startingPopulation.Location = new System.Drawing.Point(12, 69);
            this.lbl_startingPopulation.Name = "lbl_startingPopulation";
            this.lbl_startingPopulation.Size = new System.Drawing.Size(94, 13);
            this.lbl_startingPopulation.TabIndex = 5;
            this.lbl_startingPopulation.Text = "Starting Popuation";
            // 
            // lbl_ResourceModifier
            // 
            this.lbl_ResourceModifier.AutoSize = true;
            this.lbl_ResourceModifier.Location = new System.Drawing.Point(12, 42);
            this.lbl_ResourceModifier.Name = "lbl_ResourceModifier";
            this.lbl_ResourceModifier.Size = new System.Drawing.Size(93, 13);
            this.lbl_ResourceModifier.TabIndex = 6;
            this.lbl_ResourceModifier.Text = "Resource Modifier";
            // 
            // tb_GameName
            // 
            this.tb_GameName.Location = new System.Drawing.Point(112, 12);
            this.tb_GameName.Name = "tb_GameName";
            this.tb_GameName.Size = new System.Drawing.Size(178, 20);
            this.tb_GameName.TabIndex = 7;
            // 
            // tb_ResourceModifier
            // 
            this.tb_ResourceModifier.Location = new System.Drawing.Point(112, 39);
            this.tb_ResourceModifier.Name = "tb_ResourceModifier";
            this.tb_ResourceModifier.Size = new System.Drawing.Size(178, 20);
            this.tb_ResourceModifier.TabIndex = 8;
            // 
            // tb_StartingPopulation
            // 
            this.tb_StartingPopulation.Location = new System.Drawing.Point(112, 66);
            this.tb_StartingPopulation.Name = "tb_StartingPopulation";
            this.tb_StartingPopulation.Size = new System.Drawing.Size(178, 20);
            this.tb_StartingPopulation.TabIndex = 9;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 235);
            this.Controls.Add(this.tb_StartingPopulation);
            this.Controls.Add(this.tb_ResourceModifier);
            this.Controls.Add(this.tb_GameName);
            this.Controls.Add(this.lbl_ResourceModifier);
            this.Controls.Add(this.lbl_startingPopulation);
            this.Controls.Add(this.lbl_GameName);
            this.Controls.Add(this.btn_CreateGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewGame";
            this.Text = "New Game";
            this.Load += new System.EventHandler(this.NewGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateGame;
        private System.Windows.Forms.Label lbl_GameName;
        private System.Windows.Forms.Label lbl_startingPopulation;
        private System.Windows.Forms.Label lbl_ResourceModifier;
        private System.Windows.Forms.TextBox tb_GameName;
        private System.Windows.Forms.TextBox tb_ResourceModifier;
        private System.Windows.Forms.TextBox tb_StartingPopulation;
    }
}