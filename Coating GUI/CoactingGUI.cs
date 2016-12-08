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
    public partial class CoactingGUI : Form
    {
        public PriceRepository          PR    = new PriceRepository();
        public CoatingRepository        CR    = new CoatingRepository();
        public WaterTreatmentRepository WTR   = new WaterTreatmentRepository();
        public DryTreatmentRepository   DTR   = new DryTreatmentRepository();
        public ToolTypeRepository TTR = new ToolTypeRepository();
        public Steel                    steel;

        // Empty values
        List<Coating> coatings;
        List<ToolType> tooltypes;
        DryTreatment drytreatment;
        WaterTreatment watertreatment;


        public CoactingGUI()
        {
            InitializeComponent();

            foreach (Coating c in CR.GetAllCoatings())
            {
                dropdown1.Items.Add(c.name);
                dropdown2.Items.Add(c.name);
                dropdown3.Items.Add(c.name);
                dropdown4.Items.Add(c.name);
                dropdown5.Items.Add(c.name);
            }

            tooltypes1.Items.Add(" ");
            foreach (ToolType tt in TTR.GetAllToolTypes())
            {
                tooltypes1.Items.Add(tt.Name);
            }

            steel = new Steel(PR);
        }

        public void InitializeEntities()
        {
            coatings = new List<Coating>();
            tooltypes = new List<ToolType>();
            drytreatment = new DryTreatment();
            watertreatment = new WaterTreatment();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropdown2.Visible = true;
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
            dropdown1.Items.Add(" ");
            dropdown2.Items.Add(" ");
            dropdown3.Items.Add(" ");
            dropdown4.Items.Add(" ");
            dropdown5.Items.Add(" ");
            steel.Quantity = 1;
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
            InitializeEntities();

            try
            {
                // Coating
                if (dropdown1.SelectedItem != null)
                    coatings.Add(CR.GetCoating(dropdown1.SelectedItem.ToString()));
                if (dropdown2.SelectedItem != null)
                    coatings.Add(CR.GetCoating(dropdown2.SelectedItem.ToString()));
                if (dropdown3.SelectedItem != null)
                    coatings.Add(CR.GetCoating(dropdown3.SelectedItem.ToString()));
                if (dropdown4.SelectedItem != null)
                    coatings.Add(CR.GetCoating(dropdown4.SelectedItem.ToString()));
                if (dropdown5.SelectedItem != null)
                    coatings.Add(CR.GetCoating(dropdown5.SelectedItem.ToString()));

                // Stråling
                if (Vådstråling.Checked)
                    watertreatment = WTR.GetWaterTreatment(steel);
                if (Tørstråling.Checked)
                    drytreatment   = DTR.GetDryTreatment(steel);

                // Tool types
                if (tooltypes1.SelectedItem != null)
                    tooltypes.Add(TTR.GetToolType(tooltypes1.SelectedItem.ToString()));

                double totalprice = 0;

                totalprice = steel.GetFinalPrice(coatings, watertreatment, drytreatment, tooltypes);

                string[] custom = custombox.Text.Split('+');
                foreach (var item in custom)
                {
                    totalprice += Convert.ToInt32(item);
                }

                this.Price.Text = Convert.ToString(totalprice);


            }
            catch { }
        }



        private void Reset_Click(object sender, EventArgs e)
        {
            Height.Clear();
            custombox.Text = "0";
            Width.Clear();
            Length.Clear();
            Price.Clear();
            Volume.Clear();
            dropdown1.SelectedIndex = 0;
            dropdown2.SelectedIndex = 0;
            dropdown3.SelectedIndex = 0;
            dropdown4.SelectedIndex = 0;
            dropdown5.SelectedIndex = 0;

            dropdown2.Visible = false;
            dropdown3.Visible = false;
            dropdown4.Visible = false;
            dropdown5.Visible = false;

            Vådstråling.Checked = false;
            Tørstråling.Checked = false;
            StrålingAmount.Value = 1;

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

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StrålingAmount_ValueChanged(object sender, EventArgs e)
        {
            steel.Quantity = Convert.ToInt32( StrålingAmount.Value );
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dropdown3.Visible = true;
        }

        private void dropdown3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropdown4.Visible = true;
        }

        private void dropdown4_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropdown5.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }
    }
}
