namespace Empires.forms
{
    partial class PackageManager
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
            this.lb_Packages = new System.Windows.Forms.ListBox();
            this.btn_NewPackage = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_PackageName = new System.Windows.Forms.Label();
            this.lbl_PackageNameValue = new System.Windows.Forms.Label();
            this.lbl_PackageIDValue = new System.Windows.Forms.Label();
            this.lbl_PackageID = new System.Windows.Forms.Label();
            this.lbl_PackageVersionValue = new System.Windows.Forms.Label();
            this.lbl_PackageVersion = new System.Windows.Forms.Label();
            this.lbl_PackageAuthorValue = new System.Windows.Forms.Label();
            this.lbl_PackageAuthor = new System.Windows.Forms.Label();
            this.btn_GetPackages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Packages
            // 
            this.lb_Packages.FormattingEnabled = true;
            this.lb_Packages.Location = new System.Drawing.Point(13, 13);
            this.lb_Packages.Name = "lb_Packages";
            this.lb_Packages.Size = new System.Drawing.Size(217, 511);
            this.lb_Packages.TabIndex = 0;
            // 
            // btn_NewPackage
            // 
            this.btn_NewPackage.Location = new System.Drawing.Point(13, 526);
            this.btn_NewPackage.Name = "btn_NewPackage";
            this.btn_NewPackage.Size = new System.Drawing.Size(106, 23);
            this.btn_NewPackage.TabIndex = 1;
            this.btn_NewPackage.Text = "New Package";
            this.btn_NewPackage.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(237, 13);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(535, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete Package";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // lbl_PackageName
            // 
            this.lbl_PackageName.AutoSize = true;
            this.lbl_PackageName.Location = new System.Drawing.Point(426, 43);
            this.lbl_PackageName.Name = "lbl_PackageName";
            this.lbl_PackageName.Size = new System.Drawing.Size(81, 13);
            this.lbl_PackageName.TabIndex = 3;
            this.lbl_PackageName.Text = "Package Name";
            // 
            // lbl_PackageNameValue
            // 
            this.lbl_PackageNameValue.AutoSize = true;
            this.lbl_PackageNameValue.Location = new System.Drawing.Point(513, 43);
            this.lbl_PackageNameValue.Name = "lbl_PackageNameValue";
            this.lbl_PackageNameValue.Size = new System.Drawing.Size(88, 13);
            this.lbl_PackageNameValue.TabIndex = 4;
            this.lbl_PackageNameValue.Text = "PACKAGENAME";
            // 
            // lbl_PackageIDValue
            // 
            this.lbl_PackageIDValue.AutoSize = true;
            this.lbl_PackageIDValue.Location = new System.Drawing.Point(513, 82);
            this.lbl_PackageIDValue.Name = "lbl_PackageIDValue";
            this.lbl_PackageIDValue.Size = new System.Drawing.Size(71, 13);
            this.lbl_PackageIDValue.TabIndex = 6;
            this.lbl_PackageIDValue.Text = "PACKAGE ID";
            // 
            // lbl_PackageID
            // 
            this.lbl_PackageID.AutoSize = true;
            this.lbl_PackageID.Location = new System.Drawing.Point(443, 82);
            this.lbl_PackageID.Name = "lbl_PackageID";
            this.lbl_PackageID.Size = new System.Drawing.Size(64, 13);
            this.lbl_PackageID.TabIndex = 7;
            this.lbl_PackageID.Text = "Package ID";
            // 
            // lbl_PackageVersionValue
            // 
            this.lbl_PackageVersionValue.AutoSize = true;
            this.lbl_PackageVersionValue.Location = new System.Drawing.Point(513, 69);
            this.lbl_PackageVersionValue.Name = "lbl_PackageVersionValue";
            this.lbl_PackageVersionValue.Size = new System.Drawing.Size(108, 13);
            this.lbl_PackageVersionValue.TabIndex = 8;
            this.lbl_PackageVersionValue.Text = "PACKAGE VERSION";
            // 
            // lbl_PackageVersion
            // 
            this.lbl_PackageVersion.AutoSize = true;
            this.lbl_PackageVersion.Location = new System.Drawing.Point(419, 69);
            this.lbl_PackageVersion.Name = "lbl_PackageVersion";
            this.lbl_PackageVersion.Size = new System.Drawing.Size(88, 13);
            this.lbl_PackageVersion.TabIndex = 9;
            this.lbl_PackageVersion.Text = "Package Version";
            // 
            // lbl_PackageAuthorValue
            // 
            this.lbl_PackageAuthorValue.AutoSize = true;
            this.lbl_PackageAuthorValue.Location = new System.Drawing.Point(513, 56);
            this.lbl_PackageAuthorValue.Name = "lbl_PackageAuthorValue";
            this.lbl_PackageAuthorValue.Size = new System.Drawing.Size(106, 13);
            this.lbl_PackageAuthorValue.TabIndex = 10;
            this.lbl_PackageAuthorValue.Text = "PACKAGE AUTHOR";
            // 
            // lbl_PackageAuthor
            // 
            this.lbl_PackageAuthor.AutoSize = true;
            this.lbl_PackageAuthor.Location = new System.Drawing.Point(423, 56);
            this.lbl_PackageAuthor.Name = "lbl_PackageAuthor";
            this.lbl_PackageAuthor.Size = new System.Drawing.Size(84, 13);
            this.lbl_PackageAuthor.TabIndex = 11;
            this.lbl_PackageAuthor.Text = "Package Author";
            // 
            // btn_GetPackages
            // 
            this.btn_GetPackages.Location = new System.Drawing.Point(125, 526);
            this.btn_GetPackages.Name = "btn_GetPackages";
            this.btn_GetPackages.Size = new System.Drawing.Size(105, 23);
            this.btn_GetPackages.TabIndex = 12;
            this.btn_GetPackages.Text = "Get Packages";
            this.btn_GetPackages.UseVisualStyleBackColor = true;
            // 
            // PackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_GetPackages);
            this.Controls.Add(this.lbl_PackageAuthor);
            this.Controls.Add(this.lbl_PackageAuthorValue);
            this.Controls.Add(this.lbl_PackageVersion);
            this.Controls.Add(this.lbl_PackageVersionValue);
            this.Controls.Add(this.lbl_PackageID);
            this.Controls.Add(this.lbl_PackageIDValue);
            this.Controls.Add(this.lbl_PackageNameValue);
            this.Controls.Add(this.lbl_PackageName);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_NewPackage);
            this.Controls.Add(this.lb_Packages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PackageManager";
            this.Text = "PackageManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Packages;
        private System.Windows.Forms.Button btn_NewPackage;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_PackageName;
        private System.Windows.Forms.Label lbl_PackageNameValue;
        private System.Windows.Forms.Label lbl_PackageIDValue;
        private System.Windows.Forms.Label lbl_PackageID;
        private System.Windows.Forms.Label lbl_PackageVersionValue;
        private System.Windows.Forms.Label lbl_PackageVersion;
        private System.Windows.Forms.Label lbl_PackageAuthorValue;
        private System.Windows.Forms.Label lbl_PackageAuthor;
        private System.Windows.Forms.Button btn_GetPackages;
    }
}