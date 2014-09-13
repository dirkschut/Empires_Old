namespace Empires.forms
{
    partial class EditPackage
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
            this.tc_PackageEditor = new System.Windows.Forms.TabControl();
            this.tp_PackageDetails = new System.Windows.Forms.TabPage();
            this.tp_Materials = new System.Windows.Forms.TabPage();
            this.tc_PackageEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_PackageEditor
            // 
            this.tc_PackageEditor.Controls.Add(this.tp_PackageDetails);
            this.tc_PackageEditor.Controls.Add(this.tp_Materials);
            this.tc_PackageEditor.Location = new System.Drawing.Point(13, 13);
            this.tc_PackageEditor.Name = "tc_PackageEditor";
            this.tc_PackageEditor.SelectedIndex = 0;
            this.tc_PackageEditor.Size = new System.Drawing.Size(759, 536);
            this.tc_PackageEditor.TabIndex = 0;
            // 
            // tp_PackageDetails
            // 
            this.tp_PackageDetails.Location = new System.Drawing.Point(4, 22);
            this.tp_PackageDetails.Name = "tp_PackageDetails";
            this.tp_PackageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tp_PackageDetails.Size = new System.Drawing.Size(751, 510);
            this.tp_PackageDetails.TabIndex = 0;
            this.tp_PackageDetails.Text = "Package Details";
            this.tp_PackageDetails.UseVisualStyleBackColor = true;
            // 
            // tp_Materials
            // 
            this.tp_Materials.Location = new System.Drawing.Point(4, 22);
            this.tp_Materials.Name = "tp_Materials";
            this.tp_Materials.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Materials.Size = new System.Drawing.Size(751, 510);
            this.tp_Materials.TabIndex = 1;
            this.tp_Materials.Text = "Materials";
            this.tp_Materials.UseVisualStyleBackColor = true;
            // 
            // EditPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tc_PackageEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditPackage";
            this.Text = "Package Editor";
            this.tc_PackageEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_PackageEditor;
        private System.Windows.Forms.TabPage tp_PackageDetails;
        private System.Windows.Forms.TabPage tp_Materials;
    }
}