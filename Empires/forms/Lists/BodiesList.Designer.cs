namespace Empires.forms
{
    partial class BodiesList
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
            this.lb_Bodies = new System.Windows.Forms.ListBox();
            this.btn_InspectBody = new System.Windows.Forms.Button();
            this.cb_SpecificUniverse = new System.Windows.Forms.CheckBox();
            this.cb_SpecificSolarSystem = new System.Windows.Forms.CheckBox();
            this.cb_SpecificGalaxy = new System.Windows.Forms.CheckBox();
            this.cb_Universe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_Bodies
            // 
            this.lb_Bodies.FormattingEnabled = true;
            this.lb_Bodies.Location = new System.Drawing.Point(13, 104);
            this.lb_Bodies.Name = "lb_Bodies";
            this.lb_Bodies.Size = new System.Drawing.Size(196, 420);
            this.lb_Bodies.TabIndex = 0;
            // 
            // btn_InspectBody
            // 
            this.btn_InspectBody.Location = new System.Drawing.Point(13, 531);
            this.btn_InspectBody.Name = "btn_InspectBody";
            this.btn_InspectBody.Size = new System.Drawing.Size(196, 23);
            this.btn_InspectBody.TabIndex = 1;
            this.btn_InspectBody.Text = "Inspect Body";
            this.btn_InspectBody.UseVisualStyleBackColor = true;
            // 
            // cb_SpecificUniverse
            // 
            this.cb_SpecificUniverse.AutoSize = true;
            this.cb_SpecificUniverse.Location = new System.Drawing.Point(12, 12);
            this.cb_SpecificUniverse.Name = "cb_SpecificUniverse";
            this.cb_SpecificUniverse.Size = new System.Drawing.Size(109, 17);
            this.cb_SpecificUniverse.TabIndex = 2;
            this.cb_SpecificUniverse.Text = "Specific Universe";
            this.cb_SpecificUniverse.UseVisualStyleBackColor = true;
            this.cb_SpecificUniverse.CheckedChanged += new System.EventHandler(this.cb_SpecificUniverse_CheckedChanged);
            // 
            // cb_SpecificSolarSystem
            // 
            this.cb_SpecificSolarSystem.AutoSize = true;
            this.cb_SpecificSolarSystem.Location = new System.Drawing.Point(12, 58);
            this.cb_SpecificSolarSystem.Name = "cb_SpecificSolarSystem";
            this.cb_SpecificSolarSystem.Size = new System.Drawing.Size(128, 17);
            this.cb_SpecificSolarSystem.TabIndex = 3;
            this.cb_SpecificSolarSystem.Text = "Specific Solar System";
            this.cb_SpecificSolarSystem.UseVisualStyleBackColor = true;
            this.cb_SpecificSolarSystem.CheckedChanged += new System.EventHandler(this.cb_SpecificSolarSystem_CheckedChanged);
            // 
            // cb_SpecificGalaxy
            // 
            this.cb_SpecificGalaxy.AutoSize = true;
            this.cb_SpecificGalaxy.Location = new System.Drawing.Point(12, 35);
            this.cb_SpecificGalaxy.Name = "cb_SpecificGalaxy";
            this.cb_SpecificGalaxy.Size = new System.Drawing.Size(99, 17);
            this.cb_SpecificGalaxy.TabIndex = 4;
            this.cb_SpecificGalaxy.Text = "Specific Galaxy";
            this.cb_SpecificGalaxy.UseVisualStyleBackColor = true;
            this.cb_SpecificGalaxy.CheckedChanged += new System.EventHandler(this.cb_SpecificGalaxy_CheckedChanged);
            // 
            // cb_Universe
            // 
            this.cb_Universe.FormattingEnabled = true;
            this.cb_Universe.Location = new System.Drawing.Point(12, 82);
            this.cb_Universe.Name = "cb_Universe";
            this.cb_Universe.Size = new System.Drawing.Size(197, 21);
            this.cb_Universe.TabIndex = 5;
            this.cb_Universe.SelectedIndexChanged += new System.EventHandler(this.cb_Universe_SelectedIndexChanged);
            // 
            // BodiesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 561);
            this.Controls.Add(this.cb_Universe);
            this.Controls.Add(this.cb_SpecificGalaxy);
            this.Controls.Add(this.cb_SpecificSolarSystem);
            this.Controls.Add(this.cb_SpecificUniverse);
            this.Controls.Add(this.btn_InspectBody);
            this.Controls.Add(this.lb_Bodies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BodiesList";
            this.Text = "Bodies List";
            this.Load += new System.EventHandler(this.BodiesList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Bodies;
        private System.Windows.Forms.Button btn_InspectBody;
        private System.Windows.Forms.CheckBox cb_SpecificUniverse;
        private System.Windows.Forms.CheckBox cb_SpecificSolarSystem;
        private System.Windows.Forms.CheckBox cb_SpecificGalaxy;
        private System.Windows.Forms.ComboBox cb_Universe;
    }
}