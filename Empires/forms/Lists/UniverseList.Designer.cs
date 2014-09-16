namespace Empires.forms
{
    partial class UniverseList
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
            this.lb_Universes = new System.Windows.Forms.ListBox();
            this.btn_InspectUniverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Universes
            // 
            this.lb_Universes.FormattingEnabled = true;
            this.lb_Universes.Location = new System.Drawing.Point(13, 13);
            this.lb_Universes.Name = "lb_Universes";
            this.lb_Universes.Size = new System.Drawing.Size(196, 212);
            this.lb_Universes.TabIndex = 0;
            // 
            // btn_InspectUniverse
            // 
            this.btn_InspectUniverse.Location = new System.Drawing.Point(13, 226);
            this.btn_InspectUniverse.Name = "btn_InspectUniverse";
            this.btn_InspectUniverse.Size = new System.Drawing.Size(196, 23);
            this.btn_InspectUniverse.TabIndex = 1;
            this.btn_InspectUniverse.Text = "Inspect Universe";
            this.btn_InspectUniverse.UseVisualStyleBackColor = true;
            this.btn_InspectUniverse.Click += new System.EventHandler(this.btn_InspectUniverse_Click);
            // 
            // UniverseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 261);
            this.Controls.Add(this.btn_InspectUniverse);
            this.Controls.Add(this.lb_Universes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UniverseList";
            this.Text = "Universe List";
            this.Load += new System.EventHandler(this.UniverseList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Universes;
        private System.Windows.Forms.Button btn_InspectUniverse;
    }
}