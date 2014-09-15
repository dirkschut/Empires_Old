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
            this.SuspendLayout();
            // 
            // cb_Universe
            // 
            this.cb_Universe.FormattingEnabled = true;
            this.cb_Universe.Location = new System.Drawing.Point(13, 13);
            this.cb_Universe.Name = "cb_Universe";
            this.cb_Universe.Size = new System.Drawing.Size(176, 21);
            this.cb_Universe.TabIndex = 0;
            this.cb_Universe.SelectedIndexChanged += new System.EventHandler(this.cb_Universe_SelectedIndexChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(195, 13);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(64, 23);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // UniverseMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cb_Universe);
            this.Name = "UniverseMap";
            this.Text = "Universe Map";
            this.Load += new System.EventHandler(this.UniverseMap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Universe;
        private System.Windows.Forms.Button btn_Refresh;
    }
}