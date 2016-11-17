using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uddeholm.Core.Repositories;
using Uddeholm.Core.Entites;

namespace Coating_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CoatingRepository CR = new CoatingRepository();
            foreach (Coating c in CR.GetAllCoatings())
            {
                DropDown.Items.Add(c.name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
