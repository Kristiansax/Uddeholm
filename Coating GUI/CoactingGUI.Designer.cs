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
            this.Vådstråling = new System.Windows.Forms.CheckBox();
            this.Tørstråling = new System.Windows.Forms.CheckBox();
            this.StrålingAmount = new System.Windows.Forms.NumericUpDown();
            this.dropdown2 = new System.Windows.Forms.ComboBox();
            this.dropdown3 = new System.Windows.Forms.ComboBox();
            this.dropdown4 = new System.Windows.Forms.ComboBox();
            this.dropdown5 = new System.Windows.Forms.ComboBox();
            this.tooltypes1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StrålingAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dropdown1
            // 
            this.dropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown1.FormattingEnabled = true;
            this.dropdown1.Location = new System.Drawing.Point(29, 212);
            this.dropdown1.Margin = new System.Windows.Forms.Padding(1);
            this.dropdown1.Name = "dropdown1";
            this.dropdown1.Size = new System.Drawing.Size(292, 24);
            this.dropdown1.Sorted = true;
            this.dropdown1.TabIndex = 6;
            this.dropdown1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(16, 64);
            this.Height.Margin = new System.Windows.Forms.Padding(1);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(220, 22);
            this.Height.TabIndex = 3;
            this.Height.TextChanged += new System.EventHandler(this.Højde_TextChanged);
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(16, 35);
            this.Length.Margin = new System.Windows.Forms.Padding(1);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(220, 22);
            this.Length.TabIndex = 2;
            this.Length.TextChanged += new System.EventHandler(this.Længde_TextChanged);
            // 
            // Width
            // 
            this.Width.AccessibleDescription = "";
            this.Width.AccessibleName = "";
            this.Width.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Width.Location = new System.Drawing.Point(16, 6);
            this.Width.Margin = new System.Windows.Forms.Padding(1);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(220, 23);
            this.Width.TabIndex = 1;
            this.Width.TextChanged += new System.EventHandler(this.Bredde_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Højde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bredde/Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Længde";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(26, 159);
            this.Volume.Margin = new System.Windows.Forms.Padding(1);
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            this.Volume.Size = new System.Drawing.Size(59, 22);
            this.Volume.TabIndex = 4;
            this.Volume.TextChanged += new System.EventHandler(this.Volume_TextChanged);
            // 
            // Calculate_Volume
            // 
            this.Calculate_Volume.Location = new System.Drawing.Point(87, 157);
            this.Calculate_Volume.Margin = new System.Windows.Forms.Padding(1);
            this.Calculate_Volume.Name = "Calculate_Volume";
            this.Calculate_Volume.Size = new System.Drawing.Size(124, 26);
            this.Calculate_Volume.TabIndex = 5;
            this.Calculate_Volume.Text = "Beregn Volume";
            this.Calculate_Volume.UseVisualStyleBackColor = true;
            this.Calculate_Volume.Click += new System.EventHandler(this.Calculate_Volume_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(636, 579);
            this.Price.Margin = new System.Windows.Forms.Padding(1);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(102, 22);
            this.Price.TabIndex = 12;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(539, 577);
            this.Calculate.Margin = new System.Windows.Forms.Padding(1);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(95, 30);
            this.Calculate.TabIndex = 10;
            this.Calculate.Text = "Beregn Pris";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(62, 579);
            this.Reset.Margin = new System.Windows.Forms.Padding(1);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(95, 30);
            this.Reset.TabIndex = 14;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ClipButton
            // 
            this.ClipButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClipButton.Location = new System.Drawing.Point(739, 577);
            this.ClipButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClipButton.Name = "ClipButton";
            this.ClipButton.Size = new System.Drawing.Size(73, 30);
            this.ClipButton.TabIndex = 11;
            this.ClipButton.Text = "Kopier";
            this.ClipButton.UseVisualStyleBackColor = true;
            this.ClipButton.Click += new System.EventHandler(this.ClipButton_Click);
            // 
            // custombox
            // 
            this.custombox.Location = new System.Drawing.Point(540, 513);
            this.custombox.Margin = new System.Windows.Forms.Padding(2);
            this.custombox.Name = "custombox";
            this.custombox.Size = new System.Drawing.Size(274, 22);
            this.custombox.TabIndex = 9;
            this.custombox.Text = "0";
            this.custombox.TextChanged += new System.EventHandler(this.custombox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 495);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Skriv evt. extra betalinger her";
            // 
            // Vådstråling
            // 
            this.Vådstråling.AutoSize = true;
            this.Vådstråling.Location = new System.Drawing.Point(51, 458);
            this.Vådstråling.Margin = new System.Windows.Forms.Padding(2);
            this.Vådstråling.Name = "Vådstråling";
            this.Vådstråling.Size = new System.Drawing.Size(101, 21);
            this.Vådstråling.TabIndex = 7;
            this.Vådstråling.Text = "Vådstråling";
            this.Vådstråling.UseVisualStyleBackColor = true;
            this.Vådstråling.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Tørstråling
            // 
            this.Tørstråling.AutoSize = true;
            this.Tørstråling.Location = new System.Drawing.Point(51, 480);
            this.Tørstråling.Margin = new System.Windows.Forms.Padding(2);
            this.Tørstråling.Name = "Tørstråling";
            this.Tørstråling.Size = new System.Drawing.Size(98, 21);
            this.Tørstråling.TabIndex = 8;
            this.Tørstråling.Text = "Tørstråling";
            this.Tørstråling.UseVisualStyleBackColor = true;
            // 
            // StrålingAmount
            // 
            this.StrålingAmount.Location = new System.Drawing.Point(51, 509);
            this.StrålingAmount.Margin = new System.Windows.Forms.Padding(2);
            this.StrålingAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.StrålingAmount.Name = "StrålingAmount";
            this.StrålingAmount.Size = new System.Drawing.Size(72, 22);
            this.StrålingAmount.TabIndex = 24;
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
            this.dropdown2.Location = new System.Drawing.Point(29, 238);
            this.dropdown2.Margin = new System.Windows.Forms.Padding(1);
            this.dropdown2.Name = "dropdown2";
            this.dropdown2.Size = new System.Drawing.Size(292, 24);
            this.dropdown2.Sorted = true;
            this.dropdown2.TabIndex = 25;
            this.dropdown2.Visible = false;
            this.dropdown2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // dropdown3
            // 
            this.dropdown3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown3.FormattingEnabled = true;
            this.dropdown3.Location = new System.Drawing.Point(29, 264);
            this.dropdown3.Margin = new System.Windows.Forms.Padding(1);
            this.dropdown3.Name = "dropdown3";
            this.dropdown3.Size = new System.Drawing.Size(292, 24);
            this.dropdown3.Sorted = true;
            this.dropdown3.TabIndex = 26;
            this.dropdown3.Visible = false;
            this.dropdown3.SelectedIndexChanged += new System.EventHandler(this.dropdown3_SelectedIndexChanged);
            // 
            // dropdown4
            // 
            this.dropdown4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown4.FormattingEnabled = true;
            this.dropdown4.Location = new System.Drawing.Point(29, 290);
            this.dropdown4.Margin = new System.Windows.Forms.Padding(1);
            this.dropdown4.Name = "dropdown4";
            this.dropdown4.Size = new System.Drawing.Size(292, 24);
            this.dropdown4.Sorted = true;
            this.dropdown4.TabIndex = 27;
            this.dropdown4.Visible = false;
            this.dropdown4.SelectedIndexChanged += new System.EventHandler(this.dropdown4_SelectedIndexChanged);
            // 
            // dropdown5
            // 
            this.dropdown5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown5.FormattingEnabled = true;
            this.dropdown5.Location = new System.Drawing.Point(29, 316);
            this.dropdown5.Margin = new System.Windows.Forms.Padding(1);
            this.dropdown5.Name = "dropdown5";
            this.dropdown5.Size = new System.Drawing.Size(292, 24);
            this.dropdown5.Sorted = true;
            this.dropdown5.TabIndex = 28;
            this.dropdown5.Visible = false;
            // 
            // tooltypes1
            // 
            this.tooltypes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tooltypes1.FormattingEnabled = true;
            this.tooltypes1.Location = new System.Drawing.Point(481, 212);
            this.tooltypes1.Margin = new System.Windows.Forms.Padding(1);
            this.tooltypes1.Name = "tooltypes1";
            this.tooltypes1.Size = new System.Drawing.Size(292, 24);
            this.tooltypes1.Sorted = true;
            this.tooltypes1.TabIndex = 29;
            this.tooltypes1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // CoactingGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(961, 679);
            this.Controls.Add(this.tooltypes1);
            this.Controls.Add(this.dropdown5);
            this.Controls.Add(this.dropdown4);
            this.Controls.Add(this.dropdown3);
            this.Controls.Add(this.dropdown2);
            this.Controls.Add(this.StrålingAmount);
            this.Controls.Add(this.Tørstråling);
            this.Controls.Add(this.Vådstråling);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "CoactingGUI";
            this.Text = "Coating Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StrålingAmount)).EndInit();
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
        private System.Windows.Forms.CheckBox Vådstråling;
        private System.Windows.Forms.CheckBox Tørstråling;
        private System.Windows.Forms.NumericUpDown StrålingAmount;
        private System.Windows.Forms.ComboBox dropdown2;
        private System.Windows.Forms.ComboBox dropdown3;
        private System.Windows.Forms.ComboBox dropdown4;
        private System.Windows.Forms.ComboBox dropdown5;
        private System.Windows.Forms.ComboBox tooltypes1;
    }
}

