namespace Coating_GUI
{
    partial class CoactingGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoactingGUI));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dropdown1 = new System.Windows.Forms.ComboBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.Length = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.TextBox();
            this.Calculate_Volume = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.ClipButton = new System.Windows.Forms.Button();
            this.custombox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VådstrålingFør = new System.Windows.Forms.CheckBox();
            this.TørstrålingFør = new System.Windows.Forms.CheckBox();
            this.StrålingAmount = new System.Windows.Forms.NumericUpDown();
            this.dropdown2 = new System.Windows.Forms.ComboBox();
            this.dropdown3 = new System.Windows.Forms.ComboBox();
            this.dropdown4 = new System.Windows.Forms.ComboBox();
            this.dropdown5 = new System.Windows.Forms.ComboBox();
            this.tooltypes1 = new System.Windows.Forms.ComboBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.treatments = new System.Windows.Forms.ComboBox();
            this.TørstrålingEfter = new System.Windows.Forms.CheckBox();
            this.VådstrålingEfter = new System.Windows.Forms.CheckBox();
            this.Førbehandling = new System.Windows.Forms.Label();
            this.Efterbehandling = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StrålingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dropdown1
            // 
            this.dropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown1.FormattingEnabled = true;
            resources.ApplyResources(this.dropdown1, "dropdown1");
            this.dropdown1.Name = "dropdown1";
            this.dropdown1.Sorted = true;
            this.dropdown1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Height
            // 
            resources.ApplyResources(this.Height, "Height");
            this.Height.Name = "Height";
            this.Height.TextChanged += new System.EventHandler(this.Højde_TextChanged);
            // 
            // Length
            // 
            resources.ApplyResources(this.Length, "Length");
            this.Length.Name = "Length";
            this.Length.TextChanged += new System.EventHandler(this.Længde_TextChanged);
            // 
            // Width
            // 
            resources.ApplyResources(this.Width, "Width");
            this.Width.Name = "Width";
            this.Width.TextChanged += new System.EventHandler(this.Bredde_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Volume
            // 
            resources.ApplyResources(this.Volume, "Volume");
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            this.Volume.TextChanged += new System.EventHandler(this.Volume_TextChanged);
            // 
            // Calculate_Volume
            // 
            resources.ApplyResources(this.Calculate_Volume, "Calculate_Volume");
            this.Calculate_Volume.Name = "Calculate_Volume";
            this.Calculate_Volume.UseVisualStyleBackColor = true;
            this.Calculate_Volume.Click += new System.EventHandler(this.Calculate_Volume_Click);
            // 
            // Price
            // 
            resources.ApplyResources(this.Price, "Price");
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Calculate
            // 
            resources.ApplyResources(this.Calculate, "Calculate");
            this.Calculate.Name = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Reset
            // 
            resources.ApplyResources(this.Reset, "Reset");
            this.Reset.Name = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ClipButton
            // 
            resources.ApplyResources(this.ClipButton, "ClipButton");
            this.ClipButton.Name = "ClipButton";
            this.ClipButton.UseVisualStyleBackColor = true;
            this.ClipButton.Click += new System.EventHandler(this.ClipButton_Click);
            // 
            // custombox
            // 
            resources.ApplyResources(this.custombox, "custombox");
            this.custombox.Name = "custombox";
            this.custombox.TextChanged += new System.EventHandler(this.custombox_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // VådstrålingFør
            // 
            resources.ApplyResources(this.VådstrålingFør, "VådstrålingFør");
            this.VådstrålingFør.Name = "VådstrålingFør";
            this.VådstrålingFør.UseVisualStyleBackColor = true;
            this.VådstrålingFør.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TørstrålingFør
            // 
            resources.ApplyResources(this.TørstrålingFør, "TørstrålingFør");
            this.TørstrålingFør.Name = "TørstrålingFør";
            this.TørstrålingFør.UseVisualStyleBackColor = true;
            // 
            // StrålingAmount
            // 
            resources.ApplyResources(this.StrålingAmount, "StrålingAmount");
            this.StrålingAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.StrålingAmount.Name = "StrålingAmount";
            this.StrålingAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StrålingAmount.ValueChanged += new System.EventHandler(this.StrålingAmount_ValueChanged);
            // 
            // dropdown2
            // 
            this.dropdown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown2.FormattingEnabled = true;
            resources.ApplyResources(this.dropdown2, "dropdown2");
            this.dropdown2.Name = "dropdown2";
            this.dropdown2.Sorted = true;
            this.dropdown2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // dropdown3
            // 
            this.dropdown3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown3.FormattingEnabled = true;
            resources.ApplyResources(this.dropdown3, "dropdown3");
            this.dropdown3.Name = "dropdown3";
            this.dropdown3.Sorted = true;
            this.dropdown3.SelectedIndexChanged += new System.EventHandler(this.dropdown3_SelectedIndexChanged);
            // 
            // dropdown4
            // 
            this.dropdown4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown4.FormattingEnabled = true;
            resources.ApplyResources(this.dropdown4, "dropdown4");
            this.dropdown4.Name = "dropdown4";
            this.dropdown4.Sorted = true;
            this.dropdown4.SelectedIndexChanged += new System.EventHandler(this.dropdown4_SelectedIndexChanged);
            // 
            // dropdown5
            // 
            this.dropdown5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown5.FormattingEnabled = true;
            resources.ApplyResources(this.dropdown5, "dropdown5");
            this.dropdown5.Name = "dropdown5";
            this.dropdown5.Sorted = true;
            // 
            // tooltypes1
            // 
            this.tooltypes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tooltypes1.FormattingEnabled = true;
            resources.ApplyResources(this.tooltypes1, "tooltypes1");
            this.tooltypes1.Name = "tooltypes1";
            this.tooltypes1.Sorted = true;
            this.tooltypes1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.White;
            this.imageList2.Images.SetKeyName(0, "UDDEHOLM_1-in-high-performance-tool-steel.png");
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList3, "imageList3");
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // treatments
            // 
            this.treatments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.treatments.FormattingEnabled = true;
            resources.ApplyResources(this.treatments, "treatments");
            this.treatments.Name = "treatments";
            this.treatments.Sorted = true;
            this.treatments.SelectedIndexChanged += new System.EventHandler(this.treatments_SelectedIndexChanged);
            // 
            // TørstrålingEfter
            // 
            resources.ApplyResources(this.TørstrålingEfter, "TørstrålingEfter");
            this.TørstrålingEfter.Name = "TørstrålingEfter";
            this.TørstrålingEfter.UseVisualStyleBackColor = true;
            // 
            // VådstrålingEfter
            // 
            resources.ApplyResources(this.VådstrålingEfter, "VådstrålingEfter");
            this.VådstrålingEfter.Name = "VådstrålingEfter";
            this.VådstrålingEfter.UseVisualStyleBackColor = true;
            // 
            // Førbehandling
            // 
            resources.ApplyResources(this.Førbehandling, "Førbehandling");
            this.Førbehandling.Name = "Førbehandling";
            // 
            // Efterbehandling
            // 
            resources.ApplyResources(this.Efterbehandling, "Efterbehandling");
            this.Efterbehandling.Name = "Efterbehandling";
            // 
            // CoactingGUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Efterbehandling);
            this.Controls.Add(this.Førbehandling);
            this.Controls.Add(this.TørstrålingEfter);
            this.Controls.Add(this.VådstrålingEfter);
            this.Controls.Add(this.treatments);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tooltypes1);
            this.Controls.Add(this.dropdown5);
            this.Controls.Add(this.dropdown4);
            this.Controls.Add(this.dropdown3);
            this.Controls.Add(this.dropdown2);
            this.Controls.Add(this.StrålingAmount);
            this.Controls.Add(this.TørstrålingFør);
            this.Controls.Add(this.VådstrålingFør);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.custombox);
            this.Controls.Add(this.ClipButton);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Calculate_Volume);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.dropdown1);
            this.DoubleBuffered = true;
            this.Name = "CoactingGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StrålingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox dropdown1;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Volume;
        private System.Windows.Forms.Button Calculate_Volume;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button ClipButton;
        private System.Windows.Forms.TextBox custombox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox VådstrålingFør;
        private System.Windows.Forms.CheckBox TørstrålingFør;
        private System.Windows.Forms.NumericUpDown StrålingAmount;
        private System.Windows.Forms.ComboBox dropdown2;
        private System.Windows.Forms.ComboBox dropdown3;
        private System.Windows.Forms.ComboBox dropdown4;
        private System.Windows.Forms.ComboBox dropdown5;
        private System.Windows.Forms.ComboBox tooltypes1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox treatments;
        private System.Windows.Forms.CheckBox TørstrålingEfter;
        private System.Windows.Forms.CheckBox VådstrålingEfter;
        private System.Windows.Forms.Label Førbehandling;
        private System.Windows.Forms.Label Efterbehandling;
    }
}

