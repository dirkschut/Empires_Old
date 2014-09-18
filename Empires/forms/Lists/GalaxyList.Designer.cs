namespace Empires.forms
{
    partial class GalaxyList
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
            this.lb_Galaxies = new System.Windows.Forms.ListBox();
            this.btn_InspectGalaxy = new System.Windows.Forms.Button();
            this.cb_Universe = new System.Windows.Forms.ComboBox();
            this.cb_SpecificUniverse = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lb_Galaxies
            // 
            this.lb_Galaxies.FormattingEnabled = true;
            this.lb_Galaxies.Location = new System.Drawing.Point(12, 63);
            this.lb_Galaxies.Name = "lb_Galaxies";
            this.lb_Galaxies.Size = new System.Drawing.Size(196, 459);
            this.lb_Galaxies.TabIndex = 0;
            // 
            // btn_InspectGalaxy
            // 
            this.btn_InspectGalaxy.Location = new System.Drawing.Point(13, 531);
            this.btn_InspectGalaxy.Name = "btn_InspectGalaxy";
            this.btn_InspectGalaxy.Size = new System.Drawing.Size(196, 23);
            this.btn_InspectGalaxy.TabIndex = 1;
            this.btn_InspectGalaxy.Text = "Inspect Galaxy";
            this.btn_InspectGalaxy.UseVisualStyleBackColor = true;
            // 
            // cb_Universe
            // 
            this.cb_Universe.FormattingEnabled = true;
            this.cb_Universe.Location = new System.Drawing.Point(12, 36);
            this.cb_Universe.Name = "cb_Universe";
            this.cb_Universe.Size = new System.Drawing.Size(196, 21);
            this.cb_Universe.TabIndex = 2;
            // 
            // cb_SpecificUniverse
            // 
            this.cb_SpecificUniverse.AutoSize = true;
            this.cb_SpecificUniverse.Location = new System.Drawing.Point(13, 13);
            this.cb_SpecificUniverse.Name = "cb_SpecificUniverse";
            this.cb_SpecificUniverse.Size = new System.Drawing.Size(109, 17);
            this.cb_SpecificUniverse.TabIndex = 3;
            this.cb_SpecificUniverse.Text = "Specific Universe";
            this.cb_SpecificUniverse.UseVisualStyleBackColor = true;
            // 
            // GalaxyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 561);
            this.Controls.Add(this.cb_SpecificUniverse);
            this.Controls.Add(this.cb_Universe);
            this.Controls.Add(this.btn_InspectGalaxy);
            this.Controls.Add(this.lb_Galaxies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GalaxyList";
            this.Text = "Galaxy List";
            this.Load += new System.EventHandler(this.GalaxyList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Galaxies;
        private System.Windows.Forms.Button btn_InspectGalaxy;
        private System.Windows.Forms.ComboBox cb_Universe;
        private System.Windows.Forms.CheckBox cb_SpecificUniverse;
    }
}