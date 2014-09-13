using Empires.IO.Packages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Empires.forms
{
    public partial class PackageManager : Form
    {
        private Package[] packages;

        public PackageManager()
        {
            InitializeComponent();
        }

        private void PackageManager_Load(object sender, EventArgs e)
        {
            refresh();
            loadPackageData(0);
        }

        private void btn_NewPackage_Click(object sender, EventArgs e)
        {
            new EditPackage(new Package()).Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            packages = Packages.GetPackages();
            this.lb_Packages.Items.Clear();
            foreach (Package package in packages)
            {
                this.lb_Packages.Items.Add(package.data.name);
            }
        }

        private void loadPackageData(int packageID)
        {
            if (packageID <= packages.Length)
            {
                this.lbl_PackageNameValue.Text = packages[packageID].data.name;
                this.lbl_PackageAuthorValue.Text = packages[packageID].data.author;
                this.lbl_PackageVersionValue.Text = packages[packageID].data.version;
                this.lbl_PackageIDValue.Text = packages[packageID].data.packageID;
            }
        }

        private void lb_Packages_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPackageData(lb_Packages.SelectedIndex);
        }

        private void btn_EditPackage_Click(object sender, EventArgs e)
        {
            if(lb_Packages.SelectedIndex >= 0 && lb_Packages.SelectedIndex < packages.Length)
                new EditPackage(packages[lb_Packages.SelectedIndex]).Show();
        }
    }
}
