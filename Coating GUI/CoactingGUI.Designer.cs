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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoactingGUI));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DropDown = new System.Windows.Forms.ComboBox();
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
            this.TotalAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Vådstråling = new System.Windows.Forms.CheckBox();
            this.Tørstråling = new System.Windows.Forms.CheckBox();
            this.StrålingAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TotalAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrålingAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // DropDown
            // 
            this.DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDown.FormattingEnabled = true;
            this.DropDown.Location = new System.Drawing.Point(28, 183);
            this.DropDown.Margin = new System.Windows.Forms.Padding(2);
            this.DropDown.Name = "DropDown";
            this.DropDown.Size = new System.Drawing.Size(508, 37);
            this.DropDown.Sorted = true;
            this.DropDown.TabIndex = 6;
            this.DropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(278, 11);
            this.Height.Margin = new System.Windows.Forms.Padding(2);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(100, 35);
            this.Height.TabIndex = 3;
            this.Height.TextChanged += new System.EventHandler(this.Højde_TextChanged);
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(150, 11);
            this.Length.Margin = new System.Windows.Forms.Padding(2);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(100, 35);
            this.Length.TabIndex = 2;
            this.Length.TextChanged += new System.EventHandler(this.Længde_TextChanged);
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(28, 11);
            this.Width.Margin = new System.Windows.Forms.Padding(2);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(100, 35);
            this.Width.TabIndex = 1;
            this.Width.TextChanged += new System.EventHandler(this.Bredde_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Højde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bredde/Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Længde";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(436, 11);
            this.Volume.Margin = new System.Windows.Forms.Padding(2);
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            this.Volume.Size = new System.Drawing.Size(100, 35);
            this.Volume.TabIndex = 4;
            this.Volume.TextChanged += new System.EventHandler(this.Volume_TextChanged);
            // 
            // Calculate_Volume
            // 
            this.Calculate_Volume.Location = new System.Drawing.Point(546, 11);
            this.Calculate_Volume.Margin = new System.Windows.Forms.Padding(2);
            this.Calculate_Volume.Name = "Calculate_Volume";
            this.Calculate_Volume.Size = new System.Drawing.Size(217, 47);
            this.Calculate_Volume.TabIndex = 5;
            this.Calculate_Volume.Text = "Beregn Volume";
            this.Calculate_Volume.UseVisualStyleBackColor = true;
            this.Calculate_Volume.Click += new System.EventHandler(this.Calculate_Volume_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(1052, 678);
            this.Price.Margin = new System.Windows.Forms.Padding(2);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(176, 35);
            this.Price.TabIndex = 12;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(882, 674);
            this.Calculate.Margin = new System.Windows.Forms.Padding(2);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(166, 54);
            this.Calculate.TabIndex = 10;
            this.Calculate.Text = "Beregn Pris";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(47, 678);
            this.Reset.Margin = new System.Windows.Forms.Padding(2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(166, 54);
            this.Reset.TabIndex = 14;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ClipButton
            // 
            this.ClipButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClipButton.Location = new System.Drawing.Point(1232, 674);
            this.ClipButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClipButton.Name = "ClipButton";
            this.ClipButton.Size = new System.Drawing.Size(128, 54);
            this.ClipButton.TabIndex = 11;
            this.ClipButton.Text = "Kopier";
            this.ClipButton.UseVisualStyleBackColor = true;
            this.ClipButton.Click += new System.EventHandler(this.ClipButton_Click);
            // 
            // custombox
            // 
            this.custombox.Location = new System.Drawing.Point(882, 183);
            this.custombox.Margin = new System.Windows.Forms.Padding(4);
            this.custombox.Name = "custombox";
            this.custombox.Size = new System.Drawing.Size(476, 35);
            this.custombox.TabIndex = 9;
            this.custombox.Text = "0";
            this.custombox.TextChanged += new System.EventHandler(this.custombox_TextChanged);
            // 
            // TotalAmount
            // 
            this.TotalAmount.Location = new System.Drawing.Point(840, 14);
            this.TotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.TotalAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(126, 35);
            this.TotalAmount.TabIndex = 19;
            this.TotalAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TotalAmount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(768, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Antal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(952, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Skriv evt. extra betalinger her";
            // 
            // Vådstråling
            // 
            this.Vådstråling.AutoSize = true;
            this.Vådstråling.Location = new System.Drawing.Point(28, 287);
            this.Vådstråling.Name = "Vådstråling";
            this.Vådstråling.Size = new System.Drawing.Size(165, 33);
            this.Vådstråling.TabIndex = 7;
            this.Vådstråling.Text = "Vådstråling";
            this.Vådstråling.UseVisualStyleBackColor = true;
            this.Vådstråling.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Tørstråling
            // 
            this.Tørstråling.AutoSize = true;
            this.Tørstråling.Location = new System.Drawing.Point(28, 326);
            this.Tørstråling.Name = "Tørstråling";
            this.Tørstråling.Size = new System.Drawing.Size(161, 33);
            this.Tørstråling.TabIndex = 8;
            this.Tørstråling.Text = "Tørstråling";
            this.Tørstråling.UseVisualStyleBackColor = true;
            // 
            // StrålingAmount
            // 
            this.StrålingAmount.Location = new System.Drawing.Point(28, 379);
            this.StrålingAmount.Margin = new System.Windows.Forms.Padding(4);
            this.StrålingAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.StrålingAmount.Name = "StrålingAmount";
            this.StrålingAmount.Size = new System.Drawing.Size(126, 35);
            this.StrålingAmount.TabIndex = 24;
            this.StrålingAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CoactingGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1437, 799);
            this.Controls.Add(this.StrålingAmount);
            this.Controls.Add(this.Tørstråling);
            this.Controls.Add(this.Vådstråling);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalAmount);
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
            this.Controls.Add(this.DropDown);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CoactingGUI";
            this.Text = "Coating Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrålingAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox DropDown;
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
        private System.Windows.Forms.NumericUpDown TotalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Vådstråling;
        private System.Windows.Forms.CheckBox Tørstråling;
        private System.Windows.Forms.NumericUpDown StrålingAmount;
    }
}

