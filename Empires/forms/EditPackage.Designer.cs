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
            this.lbl_PackageAuthor = new System.Windows.Forms.Label();
            this.lbl_PackageVersion = new System.Windows.Forms.Label();
            this.lbl_PackageID = new System.Windows.Forms.Label();
            this.lbl_PackageName = new System.Windows.Forms.Label();
            this.tb_PackageName = new System.Windows.Forms.TextBox();
            this.tb_PackageAuthor = new System.Windows.Forms.TextBox();
            this.tb_PackageVersion = new System.Windows.Forms.TextBox();
            this.tb_PackageID = new System.Windows.Forms.TextBox();
            this.btn_SavePackage = new System.Windows.Forms.Button();
            this.tc_PackageEditor.SuspendLayout();
            this.tp_PackageDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_PackageEditor
            // 
            this.tc_PackageEditor.Controls.Add(this.tp_PackageDetails);
            this.tc_PackageEditor.Controls.Add(this.tp_Materials);
            this.tc_PackageEditor.Location = new System.Drawing.Point(13, 13);
            this.tc_PackageEditor.Name = "tc_PackageEditor";
            this.tc_PackageEditor.SelectedIndex = 0;
            this.tc_PackageEditor.Size = new System.Drawing.Size(759, 507);
            this.tc_PackageEditor.TabIndex = 0;
            // 
            // tp_PackageDetails
            // 
            this.tp_PackageDetails.Controls.Add(this.tb_PackageID);
            this.tp_PackageDetails.Controls.Add(this.tb_PackageVersion);
            this.tp_PackageDetails.Controls.Add(this.tb_PackageAuthor);
            this.tp_PackageDetails.Controls.Add(this.tb_PackageName);
            this.tp_PackageDetails.Controls.Add(this.lbl_PackageAuthor);
            this.tp_PackageDetails.Controls.Add(this.lbl_PackageVersion);
            this.tp_PackageDetails.Controls.Add(this.lbl_PackageID);
            this.tp_PackageDetails.Controls.Add(this.lbl_PackageName);
            this.tp_PackageDetails.Location = new System.Drawing.Point(4, 22);
            this.tp_PackageDetails.Name = "tp_PackageDetails";
            this.tp_PackageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tp_PackageDetails.Size = new System.Drawing.Size(751, 481);
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
            // lbl_PackageAuthor
            // 
            this.lbl_PackageAuthor.AutoSize = true;
            this.lbl_PackageAuthor.Location = new System.Drawing.Point(6, 36);
            this.lbl_PackageAuthor.Name = "lbl_PackageAuthor";
            this.lbl_PackageAuthor.Size = new System.Drawing.Size(84, 13);
            this.lbl_PackageAuthor.TabIndex = 19;
            this.lbl_PackageAuthor.Text = "Package Author";
            // 
            // lbl_PackageVersion
            // 
            this.lbl_PackageVersion.AutoSize = true;
            this.lbl_PackageVersion.Location = new System.Drawing.Point(6, 62);
            this.lbl_PackageVersion.Name = "lbl_PackageVersion";
            this.lbl_PackageVersion.Size = new System.Drawing.Size(88, 13);
            this.lbl_PackageVersion.TabIndex = 17;
            this.lbl_PackageVersion.Text = "Package Version";
            // 
            // lbl_PackageID
            // 
            this.lbl_PackageID.AutoSize = true;
            this.lbl_PackageID.Location = new System.Drawing.Point(6, 88);
            this.lbl_PackageID.Name = "lbl_PackageID";
            this.lbl_PackageID.Size = new System.Drawing.Size(64, 13);
            this.lbl_PackageID.TabIndex = 15;
            this.lbl_PackageID.Text = "Package ID";
            // 
            // lbl_PackageName
            // 
            this.lbl_PackageName.AutoSize = true;
            this.lbl_PackageName.Location = new System.Drawing.Point(6, 10);
            this.lbl_PackageName.Name = "lbl_PackageName";
            this.lbl_PackageName.Size = new System.Drawing.Size(81, 13);
            this.lbl_PackageName.TabIndex = 12;
            this.lbl_PackageName.Text = "Package Name";
            // 
            // tb_PackageName
            // 
            this.tb_PackageName.Location = new System.Drawing.Point(100, 7);
            this.tb_PackageName.Name = "tb_PackageName";
            this.tb_PackageName.Size = new System.Drawing.Size(645, 20);
            this.tb_PackageName.TabIndex = 20;
            // 
            // tb_PackageAuthor
            // 
            this.tb_PackageAuthor.Location = new System.Drawing.Point(100, 33);
            this.tb_PackageAuthor.Name = "tb_PackageAuthor";
            this.tb_PackageAuthor.Size = new System.Drawing.Size(645, 20);
            this.tb_PackageAuthor.TabIndex = 21;
            // 
            // tb_PackageVersion
            // 
            this.tb_PackageVersion.Location = new System.Drawing.Point(100, 59);
            this.tb_PackageVersion.Name = "tb_PackageVersion";
            this.tb_PackageVersion.Size = new System.Drawing.Size(645, 20);
            this.tb_PackageVersion.TabIndex = 22;
            // 
            // tb_PackageID
            // 
            this.tb_PackageID.Location = new System.Drawing.Point(100, 85);
            this.tb_PackageID.Name = "tb_PackageID";
            this.tb_PackageID.Size = new System.Drawing.Size(645, 20);
            this.tb_PackageID.TabIndex = 23;
            // 
            // btn_SavePackage
            // 
            this.btn_SavePackage.Location = new System.Drawing.Point(13, 526);
            this.btn_SavePackage.Name = "btn_SavePackage";
            this.btn_SavePackage.Size = new System.Drawing.Size(759, 23);
            this.btn_SavePackage.TabIndex = 1;
            this.btn_SavePackage.Text = "Save Package";
            this.btn_SavePackage.UseVisualStyleBackColor = true;
            this.btn_SavePackage.Click += new System.EventHandler(this.btn_SavePackage_Click);
            // 
            // EditPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_SavePackage);
            this.Controls.Add(this.tc_PackageEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditPackage";
            this.Text = "Package Editor";
            this.tc_PackageEditor.ResumeLayout(false);
            this.tp_PackageDetails.ResumeLayout(false);
            this.tp_PackageDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_PackageEditor;
        private System.Windows.Forms.TabPage tp_PackageDetails;
        private System.Windows.Forms.TabPage tp_Materials;
        private System.Windows.Forms.TextBox tb_PackageID;
        private System.Windows.Forms.TextBox tb_PackageVersion;
        private System.Windows.Forms.TextBox tb_PackageAuthor;
        private System.Windows.Forms.TextBox tb_PackageName;
        private System.Windows.Forms.Label lbl_PackageAuthor;
        private System.Windows.Forms.Label lbl_PackageVersion;
        private System.Windows.Forms.Label lbl_PackageID;
        private System.Windows.Forms.Label lbl_PackageName;
        private System.Windows.Forms.Button btn_SavePackage;
    }
}