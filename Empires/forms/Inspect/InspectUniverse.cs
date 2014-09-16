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
    public partial class InspectUniverse : Form
    {
        public int universe = 0;

        public InspectUniverse(int universe)
        {
            this.universe = universe;
            InitializeComponent();
        }

        private void InspectUniverse_Load(object sender, EventArgs e)
        {

        }
    }
}
