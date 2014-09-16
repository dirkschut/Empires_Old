namespace Empires.forms
{
    partial class SolarSystemList
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
            this.lb_SolarSystems = new System.Windows.Forms.ListBox();
            this.btn_InspectSolarSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_SolarSystems
            // 
            this.lb_SolarSystems.FormattingEnabled = true;
            this.lb_SolarSystems.Location = new System.Drawing.Point(13, 13);
            this.lb_SolarSystems.Name = "lb_SolarSystems";
            this.lb_SolarSystems.Size = new System.Drawing.Size(196, 511);
            this.lb_SolarSystems.TabIndex = 0;
            // 
            // btn_InspectSolarSystem
            // 
            this.btn_InspectSolarSystem.Location = new System.Drawing.Point(13, 531);
            this.btn_InspectSolarSystem.Name = "btn_InspectSolarSystem";
            this.btn_InspectSolarSystem.Size = new System.Drawing.Size(196, 23);
            this.btn_InspectSolarSystem.TabIndex = 1;
            this.btn_InspectSolarSystem.Text = "Inspect Solar System";
            this.btn_InspectSolarSystem.UseVisualStyleBackColor = true;
            // 
            // SolarSystemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 561);
            this.Controls.Add(this.btn_InspectSolarSystem);
            this.Controls.Add(this.lb_SolarSystems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SolarSystemList";
            this.Text = "Solar System List";
            this.Load += new System.EventHandler(this.SolarSystemList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_SolarSystems;
        private System.Windows.Forms.Button btn_InspectSolarSystem;
    }
}