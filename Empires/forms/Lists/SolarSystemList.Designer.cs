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
            this.cb_SpecificUniverse = new System.Windows.Forms.CheckBox();
            this.cb_Universe = new System.Windows.Forms.ComboBox();
            this.cb_SpecificGalaxy = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lb_SolarSystems
            // 
            this.lb_SolarSystems.FormattingEnabled = true;
            this.lb_SolarSystems.Location = new System.Drawing.Point(13, 91);
            this.lb_SolarSystems.Name = "lb_SolarSystems";
            this.lb_SolarSystems.Size = new System.Drawing.Size(196, 433);
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
            // cb_SpecificUniverse
            // 
            this.cb_SpecificUniverse.AutoSize = true;
            this.cb_SpecificUniverse.Location = new System.Drawing.Point(13, 12);
            this.cb_SpecificUniverse.Name = "cb_SpecificUniverse";
            this.cb_SpecificUniverse.Size = new System.Drawing.Size(109, 17);
            this.cb_SpecificUniverse.TabIndex = 5;
            this.cb_SpecificUniverse.Text = "Specific Universe";
            this.cb_SpecificUniverse.UseVisualStyleBackColor = true;
            this.cb_SpecificUniverse.CheckedChanged += new System.EventHandler(this.cb_SpecificUniverse_CheckedChanged);
            // 
            // cb_Universe
            // 
            this.cb_Universe.FormattingEnabled = true;
            this.cb_Universe.Location = new System.Drawing.Point(12, 58);
            this.cb_Universe.Name = "cb_Universe";
            this.cb_Universe.Size = new System.Drawing.Size(196, 21);
            this.cb_Universe.TabIndex = 4;
            this.cb_Universe.SelectedIndexChanged += new System.EventHandler(this.cb_Universe_SelectedIndexChanged);
            // 
            // cb_SpecificGalaxy
            // 
            this.cb_SpecificGalaxy.AutoSize = true;
            this.cb_SpecificGalaxy.Location = new System.Drawing.Point(12, 35);
            this.cb_SpecificGalaxy.Name = "cb_SpecificGalaxy";
            this.cb_SpecificGalaxy.Size = new System.Drawing.Size(99, 17);
            this.cb_SpecificGalaxy.TabIndex = 6;
            this.cb_SpecificGalaxy.Text = "Specific Galaxy";
            this.cb_SpecificGalaxy.UseVisualStyleBackColor = true;
            this.cb_SpecificGalaxy.CheckedChanged += new System.EventHandler(this.cb_SpecificGalaxy_CheckedChanged);
            // 
            // SolarSystemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 561);
            this.Controls.Add(this.cb_SpecificGalaxy);
            this.Controls.Add(this.cb_SpecificUniverse);
            this.Controls.Add(this.cb_Universe);
            this.Controls.Add(this.btn_InspectSolarSystem);
            this.Controls.Add(this.lb_SolarSystems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SolarSystemList";
            this.Text = "Solar System List";
            this.Load += new System.EventHandler(this.SolarSystemList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_SolarSystems;
        private System.Windows.Forms.Button btn_InspectSolarSystem;
        private System.Windows.Forms.CheckBox cb_SpecificUniverse;
        private System.Windows.Forms.ComboBox cb_Universe;
        private System.Windows.Forms.CheckBox cb_SpecificGalaxy;
    }
}