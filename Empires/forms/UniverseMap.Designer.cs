namespace Empires.forms
{
    partial class UniverseMap
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
            this.cb_Universe = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_MoveDown = new System.Windows.Forms.Button();
            this.btn_MoveLeft = new System.Windows.Forms.Button();
            this.btn_MoveRight = new System.Windows.Forms.Button();
            this.btn_ZoomOut = new System.Windows.Forms.Button();
            this.btn_MoveUp = new System.Windows.Forms.Button();
            this.btn_ZoomIn = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.tc_Controls = new System.Windows.Forms.TabControl();
            this.tp_Controls = new System.Windows.Forms.TabPage();
            this.cb_GalaxyNames = new System.Windows.Forms.CheckBox();
            this.tc_Controls.SuspendLayout();
            this.tp_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Universe
            // 
            this.cb_Universe.FormattingEnabled = true;
            this.cb_Universe.Location = new System.Drawing.Point(6, 7);
            this.cb_Universe.Name = "cb_Universe";
            this.cb_Universe.Size = new System.Drawing.Size(162, 21);
            this.cb_Universe.TabIndex = 0;
            this.cb_Universe.SelectedIndexChanged += new System.EventHandler(this.cb_Universe_SelectedIndexChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(6, 34);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(162, 23);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_MoveDown
            // 
            this.btn_MoveDown.Location = new System.Drawing.Point(62, 175);
            this.btn_MoveDown.Name = "btn_MoveDown";
            this.btn_MoveDown.Size = new System.Drawing.Size(50, 50);
            this.btn_MoveDown.TabIndex = 2;
            this.btn_MoveDown.Text = "Down";
            this.btn_MoveDown.UseVisualStyleBackColor = true;
            this.btn_MoveDown.Click += new System.EventHandler(this.btn_MoveDown_Click);
            // 
            // btn_MoveLeft
            // 
            this.btn_MoveLeft.Location = new System.Drawing.Point(6, 119);
            this.btn_MoveLeft.Name = "btn_MoveLeft";
            this.btn_MoveLeft.Size = new System.Drawing.Size(50, 50);
            this.btn_MoveLeft.TabIndex = 3;
            this.btn_MoveLeft.Text = "Left";
            this.btn_MoveLeft.UseVisualStyleBackColor = true;
            this.btn_MoveLeft.Click += new System.EventHandler(this.btn_MoveLeft_Click);
            // 
            // btn_MoveRight
            // 
            this.btn_MoveRight.Location = new System.Drawing.Point(118, 119);
            this.btn_MoveRight.Name = "btn_MoveRight";
            this.btn_MoveRight.Size = new System.Drawing.Size(50, 50);
            this.btn_MoveRight.TabIndex = 4;
            this.btn_MoveRight.Text = "Right";
            this.btn_MoveRight.UseVisualStyleBackColor = true;
            this.btn_MoveRight.Click += new System.EventHandler(this.btn_MoveRight_Click);
            // 
            // btn_ZoomOut
            // 
            this.btn_ZoomOut.Location = new System.Drawing.Point(118, 63);
            this.btn_ZoomOut.Name = "btn_ZoomOut";
            this.btn_ZoomOut.Size = new System.Drawing.Size(50, 50);
            this.btn_ZoomOut.TabIndex = 5;
            this.btn_ZoomOut.Text = "-";
            this.btn_ZoomOut.UseVisualStyleBackColor = true;
            this.btn_ZoomOut.Click += new System.EventHandler(this.btn_ZoomOut_Click);
            // 
            // btn_MoveUp
            // 
            this.btn_MoveUp.Location = new System.Drawing.Point(62, 63);
            this.btn_MoveUp.Name = "btn_MoveUp";
            this.btn_MoveUp.Size = new System.Drawing.Size(50, 50);
            this.btn_MoveUp.TabIndex = 6;
            this.btn_MoveUp.Text = "Up";
            this.btn_MoveUp.UseVisualStyleBackColor = true;
            this.btn_MoveUp.Click += new System.EventHandler(this.btn_MoveUp_Click);
            // 
            // btn_ZoomIn
            // 
            this.btn_ZoomIn.Location = new System.Drawing.Point(6, 63);
            this.btn_ZoomIn.Name = "btn_ZoomIn";
            this.btn_ZoomIn.Size = new System.Drawing.Size(50, 50);
            this.btn_ZoomIn.TabIndex = 7;
            this.btn_ZoomIn.Text = "+";
            this.btn_ZoomIn.UseVisualStyleBackColor = true;
            this.btn_ZoomIn.Click += new System.EventHandler(this.btn_ZoomIn_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(62, 119);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(50, 50);
            this.btn_Reset.TabIndex = 8;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // tc_Controls
            // 
            this.tc_Controls.Controls.Add(this.tp_Controls);
            this.tc_Controls.Location = new System.Drawing.Point(12, 12);
            this.tc_Controls.Name = "tc_Controls";
            this.tc_Controls.SelectedIndex = 0;
            this.tc_Controls.Size = new System.Drawing.Size(181, 278);
            this.tc_Controls.TabIndex = 9;
            // 
            // tp_Controls
            // 
            this.tp_Controls.Controls.Add(this.cb_GalaxyNames);
            this.tp_Controls.Controls.Add(this.cb_Universe);
            this.tp_Controls.Controls.Add(this.btn_Reset);
            this.tp_Controls.Controls.Add(this.btn_Refresh);
            this.tp_Controls.Controls.Add(this.btn_ZoomIn);
            this.tp_Controls.Controls.Add(this.btn_MoveUp);
            this.tp_Controls.Controls.Add(this.btn_MoveDown);
            this.tp_Controls.Controls.Add(this.btn_ZoomOut);
            this.tp_Controls.Controls.Add(this.btn_MoveLeft);
            this.tp_Controls.Controls.Add(this.btn_MoveRight);
            this.tp_Controls.Location = new System.Drawing.Point(4, 22);
            this.tp_Controls.Name = "tp_Controls";
            this.tp_Controls.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Controls.Size = new System.Drawing.Size(173, 252);
            this.tp_Controls.TabIndex = 0;
            this.tp_Controls.Text = "Map Controls";
            this.tp_Controls.UseVisualStyleBackColor = true;
            // 
            // cb_GalaxyNames
            // 
            this.cb_GalaxyNames.AutoSize = true;
            this.cb_GalaxyNames.Location = new System.Drawing.Point(7, 229);
            this.cb_GalaxyNames.Name = "cb_GalaxyNames";
            this.cb_GalaxyNames.Size = new System.Drawing.Size(94, 17);
            this.cb_GalaxyNames.TabIndex = 9;
            this.cb_GalaxyNames.Text = "Galaxy Names";
            this.cb_GalaxyNames.UseVisualStyleBackColor = true;
            this.cb_GalaxyNames.CheckedChanged += new System.EventHandler(this.cb_GalaxyNames_CheckedChanged);
            // 
            // UniverseMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tc_Controls);
            this.Name = "UniverseMap";
            this.Text = "Universe Map";
            this.Load += new System.EventHandler(this.UniverseMap_Load);
            this.tc_Controls.ResumeLayout(false);
            this.tp_Controls.ResumeLayout(false);
            this.tp_Controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Universe;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_MoveDown;
        private System.Windows.Forms.Button btn_MoveLeft;
        private System.Windows.Forms.Button btn_MoveRight;
        private System.Windows.Forms.Button btn_ZoomOut;
        private System.Windows.Forms.Button btn_MoveUp;
        private System.Windows.Forms.Button btn_ZoomIn;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TabControl tc_Controls;
        private System.Windows.Forms.TabPage tp_Controls;
        private System.Windows.Forms.CheckBox cb_GalaxyNames;
    }
}