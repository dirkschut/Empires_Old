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

        private void btn_NewMaterial_Click(object sender, EventArgs e)
        {
            this.tb_MaterialName.Clear();
            this.tb_MaterialGenerateInPlanets.Clear();
            this.tb_MaterialGenerateInPlanetsAmount.Clear();
            this.tb_MaterialGenerateInStars.Clear();
            this.tb_MaterialGenerateInStarsAmount.Clear();
        }

        private void btn_SaveMaterial_Click(object sender, EventArgs e)
        {
            Material mat = new Material();
            mat.name = tb_MaterialName.Text;
            try
            {
                mat.generateInPlanets = Convert.ToDouble(tb_MaterialGenerateInPlanets.Text);
            }
            catch (Exception ex)
            {
                mat.generateInPlanets = 0;
            }

            try
            {
                mat.generateInPlanetsAmount = Convert.ToDouble(tb_MaterialGenerateInPlanetsAmount.Text);
            }
            catch (Exception ex)
            {
                mat.generateInPlanetsAmount = 0;
            }

            try
            {
                mat.generateInStars = Convert.ToDouble(tb_MaterialGenerateInStars.Text);
            }
            catch (Exception ex)
            {
                mat.generateInStars = 0;
            }

            try
            {
                mat.generateInStarsAmount = Convert.ToDouble(tb_MaterialGenerateInStarsAmount.Text);
            }
            catch (Exception ex)
            {
                mat.generateInStarsAmount = 0;
            }

            package.data.materials.Add(mat);
            loadData();
        }

        private void lb_Materials_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMaterialData();
        }

        private void loadMaterialData()
        {
            this.tb_MaterialName.Text = package.data.materials[lb_Materials.SelectedIndex].name;
            this.tb_MaterialGenerateInPlanets.Text = package.data.materials[lb_Materials.SelectedIndex].generateInPlanets.ToString();
            this.tb_MaterialGenerateInPlanetsAmount.Text = package.data.materials[lb_Materials.SelectedIndex].generateInPlanetsAmount.ToString();
            this.tb_MaterialGenerateInStars.Text = package.data.materials[lb_Materials.SelectedIndex].generateInStars.ToString();
            this.tb_MaterialGenerateInStarsAmount.Text = package.data.materials[lb_Materials.SelectedIndex].generateInStarsAmount.ToString();
        }
    }
}
