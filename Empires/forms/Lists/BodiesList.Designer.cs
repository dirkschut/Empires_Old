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
            this.SuspendLayout();
            // 
            // lb_Bodies
            // 
            this.lb_Bodies.FormattingEnabled = true;
            this.lb_Bodies.Location = new System.Drawing.Point(13, 13);
            this.lb_Bodies.Name = "lb_Bodies";
            this.lb_Bodies.Size = new System.Drawing.Size(196, 511);
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
            // BodiesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 561);
            this.Controls.Add(this.btn_InspectBody);
            this.Controls.Add(this.lb_Bodies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BodiesList";
            this.Text = "Bodies List";
            this.Load += new System.EventHandler(this.BodiesList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Bodies;
        private System.Windows.Forms.Button btn_InspectBody;
    }
}