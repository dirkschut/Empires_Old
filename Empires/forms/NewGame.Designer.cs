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
            this.lb_PackagesIn = new System.Windows.Forms.ListBox();
            this.lb_PackagesNotIn = new System.Windows.Forms.ListBox();
            this.btn_AddPackage = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_RemovePackage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CreateGame
            // 
            this.btn_CreateGame.Location = new System.Drawing.Point(12, 318);
            this.btn_CreateGame.Name = "btn_CreateGame";
            this.btn_CreateGame.Size = new System.Drawing.Size(278, 23);
            this.btn_CreateGame.TabIndex = 0;
            this.btn_CreateGame.Text = "Create Game";
            this.btn_CreateGame.UseVisualStyleBackColor = true;
            this.btn_CreateGame.Click += new System.EventHandler(this.btn_CreateGame_Click);
            // 
            // lbl_GameName
            // 
            this.lbl_GameName.AutoSize = true;
            this.lbl_GameName.Location = new System.Drawing.Point(9, 15);
            this.lbl_GameName.Name = "lbl_GameName";
            this.lbl_GameName.Size = new System.Drawing.Size(66, 13);
            this.lbl_GameName.TabIndex = 1;
            this.lbl_GameName.Text = "Game Name";
            // 
            // lbl_startingPopulation
            // 
            this.lbl_startingPopulation.AutoSize = true;
            this.lbl_startingPopulation.Location = new System.Drawing.Point(9, 69);
            this.lbl_startingPopulation.Name = "lbl_startingPopulation";
            this.lbl_startingPopulation.Size = new System.Drawing.Size(94, 13);
            this.lbl_startingPopulation.TabIndex = 5;
            this.lbl_startingPopulation.Text = "Starting Popuation";
            // 
            // lbl_ResourceModifier
            // 
            this.lbl_ResourceModifier.AutoSize = true;
            this.lbl_ResourceModifier.Location = new System.Drawing.Point(9, 42);
            this.lbl_ResourceModifier.Name = "lbl_ResourceModifier";
            this.lbl_ResourceModifier.Size = new System.Drawing.Size(93, 13);
            this.lbl_ResourceModifier.TabIndex = 6;
            this.lbl_ResourceModifier.Text = "Resource Modifier";
            // 
            // tb_GameName
            // 
            this.tb_GameName.Location = new System.Drawing.Point(109, 12);
            this.tb_GameName.Name = "tb_GameName";
            this.tb_GameName.Size = new System.Drawing.Size(181, 20);
            this.tb_GameName.TabIndex = 7;
            // 
            // tb_ResourceModifier
            // 
            this.tb_ResourceModifier.Location = new System.Drawing.Point(109, 39);
            this.tb_ResourceModifier.Name = "tb_ResourceModifier";
            this.tb_ResourceModifier.Size = new System.Drawing.Size(181, 20);
            this.tb_ResourceModifier.TabIndex = 8;
            // 
            // tb_StartingPopulation
            // 
            this.tb_StartingPopulation.Location = new System.Drawing.Point(109, 66);
            this.tb_StartingPopulation.Name = "tb_StartingPopulation";
            this.tb_StartingPopulation.Size = new System.Drawing.Size(181, 20);
            this.tb_StartingPopulation.TabIndex = 9;
            // 
            // lb_PackagesIn
            // 
            this.lb_PackagesIn.FormattingEnabled = true;
            this.lb_PackagesIn.Location = new System.Drawing.Point(156, 94);
            this.lb_PackagesIn.Name = "lb_PackagesIn";
            this.lb_PackagesIn.Size = new System.Drawing.Size(134, 160);
            this.lb_PackagesIn.TabIndex = 10;
            // 
            // lb_PackagesNotIn
            // 
            this.lb_PackagesNotIn.FormattingEnabled = true;
            this.lb_PackagesNotIn.Location = new System.Drawing.Point(12, 94);
            this.lb_PackagesNotIn.Name = "lb_PackagesNotIn";
            this.lb_PackagesNotIn.Size = new System.Drawing.Size(138, 160);
            this.lb_PackagesNotIn.TabIndex = 11;
            // 
            // btn_AddPackage
            // 
            this.btn_AddPackage.Location = new System.Drawing.Point(12, 260);
            this.btn_AddPackage.Name = "btn_AddPackage";
            this.btn_AddPackage.Size = new System.Drawing.Size(138, 23);
            this.btn_AddPackage.TabIndex = 12;
            this.btn_AddPackage.Text = "Add Package";
            this.btn_AddPackage.UseVisualStyleBackColor = true;
            this.btn_AddPackage.Click += new System.EventHandler(this.btn_AddPackage_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(12, 289);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(278, 23);
            this.btn_Refresh.TabIndex = 13;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_RemovePackage
            // 
            this.btn_RemovePackage.Location = new System.Drawing.Point(157, 260);
            this.btn_RemovePackage.Name = "btn_RemovePackage";
            this.btn_RemovePackage.Size = new System.Drawing.Size(133, 23);
            this.btn_RemovePackage.TabIndex = 14;
            this.btn_RemovePackage.Text = "Remove Package";
            this.btn_RemovePackage.UseVisualStyleBackColor = true;
            this.btn_RemovePackage.Click += new System.EventHandler(this.btn_RemovePackage_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 351);
            this.Controls.Add(this.btn_RemovePackage);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_AddPackage);
            this.Controls.Add(this.lb_PackagesNotIn);
            this.Controls.Add(this.lb_PackagesIn);
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
        private System.Windows.Forms.ListBox lb_PackagesIn;
        private System.Windows.Forms.ListBox lb_PackagesNotIn;
        private System.Windows.Forms.Button btn_AddPackage;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_RemovePackage;
    }
}