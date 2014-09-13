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
            packages = Packages.GetPackages();
            foreach (Package package in packages)
            {
                this.lb_Packages.Items.Add(package.getPath());
            }
        }
    }
}
