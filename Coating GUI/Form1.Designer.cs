namespace Coating_GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DropDown = new System.Windows.Forms.ComboBox();
            this.Højde = new System.Windows.Forms.TextBox();
            this.Længde = new System.Windows.Forms.TextBox();
            this.Bredde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.ClipButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DropDown
            // 
            this.DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDown.FormattingEnabled = true;
            this.DropDown.Location = new System.Drawing.Point(28, 183);
            this.DropDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DropDown.Name = "DropDown";
            this.DropDown.Size = new System.Drawing.Size(508, 37);
            this.DropDown.Sorted = true;
            this.DropDown.TabIndex = 1;
            this.DropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Højde
            // 
            this.Højde.Location = new System.Drawing.Point(23, 11);
            this.Højde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Højde.Name = "Højde";
            this.Højde.Size = new System.Drawing.Size(100, 35);
            this.Højde.TabIndex = 3;
            this.Højde.TextChanged += new System.EventHandler(this.Højde_TextChanged);
            // 
            // Længde
            // 
            this.Længde.Location = new System.Drawing.Point(275, 11);
            this.Længde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Længde.Name = "Længde";
            this.Længde.Size = new System.Drawing.Size(100, 35);
            this.Længde.TabIndex = 4;
            this.Længde.TextChanged += new System.EventHandler(this.Længde_TextChanged);
            // 
            // Bredde
            // 
            this.Bredde.Location = new System.Drawing.Point(145, 11);
            this.Bredde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bredde.Name = "Bredde";
            this.Bredde.Size = new System.Drawing.Size(100, 35);
            this.Bredde.TabIndex = 5;
            this.Bredde.TextChanged += new System.EventHandler(this.Bredde_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Højde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bredde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Længde";
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(436, 11);
            this.Volume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            this.Volume.Size = new System.Drawing.Size(100, 35);
            this.Volume.TabIndex = 9;
            this.Volume.TextChanged += new System.EventHandler(this.Volume_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 47);
            this.button2.TabIndex = 11;
            this.button2.Text = "Calculate Volume";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(1115, 689);
            this.Price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(146, 35);
            this.Price.TabIndex = 12;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(882, 674);
            this.Calculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(166, 54);
            this.Calculate.TabIndex = 13;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(47, 678);
            this.Reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.ClipButton.Image = ((System.Drawing.Image)(resources.GetObject("ClipButton.Image")));
            this.ClipButton.Location = new System.Drawing.Point(1266, 682);
            this.ClipButton.Name = "ClipButton";
            this.ClipButton.Size = new System.Drawing.Size(41, 47);
            this.ClipButton.TabIndex = 15;
            this.ClipButton.UseVisualStyleBackColor = true;
            this.ClipButton.Click += new System.EventHandler(this.ClipButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1013, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Work in Progress";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Førbehandling",
            "EfterBehandling"});
            this.checkedListBox1.Location = new System.Drawing.Point(882, 272);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(477, 94);
            this.checkedListBox1.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(882, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(477, 35);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Skriv evt. extra betalinger her";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1437, 799);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClipButton);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bredde);
            this.Controls.Add(this.Længde);
            this.Controls.Add(this.Højde);
            this.Controls.Add(this.DropDown);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Coating Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox DropDown;
        private System.Windows.Forms.TextBox Højde;
        private System.Windows.Forms.TextBox Længde;
        private System.Windows.Forms.TextBox Bredde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Volume;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button ClipButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

