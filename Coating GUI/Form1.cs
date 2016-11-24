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
using System.Runtime.Remoting.Contexts;

namespace Coating_GUI
{
    public partial class Form1 : Form
    {
        public Steel steel = new Steel();
        public PriceRepository PR = new PriceRepository();
        public CoatingRepository CR = new CoatingRepository();
        public Form1()
        {
            InitializeComponent();
            foreach (Coating c in CR.GetAllCoatings())
            {
                DropDown.Items.Add(c.name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Højde_TextChanged(object sender, EventArgs e)
        {
            try
            {
                steel.Height = Convert.ToDouble(Højde.Text);
            }
            catch
            {

            }
        }

        private void Bredde_TextChanged(object sender, EventArgs e)
        {
            try
            {
                steel.Width = Convert.ToDouble(Højde.Text);
            }
            catch { }
            
        }

        private void Længde_TextChanged(object sender, EventArgs e)
        {
            try
            {
                steel.Length = Convert.ToDouble(Højde.Text);
            }
            catch { }
        }

        private void Volume_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DropDown.Items.Add(" ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Volume.Text = steel.GetVolume().ToString();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Price price = PR.GetPrice(steel.GetVolume());
            Coating coating = CR.GetCoating(DropDown.SelectedItem.ToString());
            double totalprice = steel.GetPrice(coating, price);

            this.Price.Text = totalprice.ToString();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Højde.Clear();
            Bredde.Clear();
            Længde.Clear();
            Price.Clear();
            Volume.Clear();
            DropDown.SelectedIndex = 0;
        }

        private void ClipButton_Click(object sender, EventArgs e)
        {
           
            Clipboard.SetText(Price.Text);
        }
    }
}
