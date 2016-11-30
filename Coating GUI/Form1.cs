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
                steel.Height = Convert.ToDouble(Height.Text);
            }
            catch
            {

            }
        }

        private void Bredde_TextChanged(object sender, EventArgs e)
        {
            try
            {
                steel.Width = Convert.ToDouble(Width.Text);
            }
            catch { }
            
        }

        private void Længde_TextChanged(object sender, EventArgs e)
        {
            try
            {
                steel.Length = Convert.ToDouble(Length.Text);
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

        private void Calculate_Volume_Click(object sender, EventArgs e)
        {
            if (Height.Text == "")
                steel.IsRound = true;
            else
                steel.IsRound = false;

            Volume.Text = Math.Round(steel.GetVolume(), 2).ToString();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                Price price = PR.GetPrice(steel.GetVolume());
                Coating coating = CR.GetCoating(DropDown.SelectedItem.ToString());
                double totalprice = steel.GetPrice(coating, price);

                string [] custom = custombox.Text.Split('+');
                foreach (var item in custom)
                {
                    totalprice += Convert.ToInt32(item);
                }

                totalprice = Convert.ToDouble(TotalAmount.Value) * totalprice;

                this.Price.Text = Convert.ToString(totalprice);
            }
            catch { }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Height.Clear();
            custombox.Text = "0";
            TotalAmount.Value = 1;
            Width.Clear();
            Length.Clear();
            Price.Clear();
            Volume.Clear();
            DropDown.SelectedIndex = 0;
        }

        private void ClipButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Price.Text);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void custombox_TextChanged(object sender, EventArgs e)
        {
            Price.Text = "Custom box blev ændret";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
