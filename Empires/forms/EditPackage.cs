using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Empires.IO.Packages;
using Empires.IO.Packages.Objects;

namespace Empires.forms
{
    public partial class EditPackage : Form
    {
        private Package package;

        public EditPackage(Package package)
        {
            this.package = package;
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            this.tb_PackageName.Text = package.data.name;
            this.tb_PackageAuthor.Text = package.data.author;
            this.tb_PackageVersion.Text = package.data.version;
            this.tb_PackageID.Text = package.data.packageID;

            this.lb_Materials.Items.Clear();
            foreach (Material material in package.data.materials)
            {
                this.lb_Materials.Items.Add(material.name);
            }
        }

        private void btn_SavePackage_Click(object sender, EventArgs e)
        {
            String name = this.tb_PackageAuthor.Text;

            package.data.name = this.tb_PackageName.Text;
            package.data.author = this.tb_PackageAuthor.Text;
            package.data.version = this.tb_PackageVersion.Text;
            package.data.packageID = this.tb_PackageID.Text;

            package.save();
        }
    }
}
