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
            this.SuspendLayout();
            // 
            // lb_Galaxies
            // 
            this.lb_Galaxies.FormattingEnabled = true;
            this.lb_Galaxies.Location = new System.Drawing.Point(13, 13);
            this.lb_Galaxies.Name = "lb_Galaxies";
            this.lb_Galaxies.Size = new System.Drawing.Size(196, 511);
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
            // GalaxyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 561);
            this.Controls.Add(this.btn_InspectGalaxy);
            this.Controls.Add(this.lb_Galaxies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GalaxyList";
            this.Text = "Galaxy List";
            this.Load += new System.EventHandler(this.GalaxyList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Galaxies;
        private System.Windows.Forms.Button btn_InspectGalaxy;
    }
}