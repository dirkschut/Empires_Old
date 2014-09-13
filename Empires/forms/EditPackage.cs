using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Empires.IO.Packages;

namespace Empires.forms
{
    public partial class EditPackage : Form
    {
        private Package package;

        public EditPackage(Package package)
        {
            this.package = package;
            InitializeComponent();
        }
    }
}
