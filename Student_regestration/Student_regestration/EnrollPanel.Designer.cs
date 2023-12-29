namespace Student_regestration
{
    partial class EnrollPanel
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
            comboBox1 = new ComboBox();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            femalerb = new RadioButton();
            malerb = new RadioButton();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            dateob = new DateTimePicker();
            name = new TextBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            comboBox2 = new ComboBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            email = new TextBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "September 2025", "January 2025" });
            comboBox1.Location = new Point(187, 211);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 23);
            comboBox1.TabIndex = 49;
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(60, 211);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(76, 19);
            materialLabel13.TabIndex = 51;
            materialLabel13.Text = "Start Date:";
            // 
            // panel1
            // 
            panel1.Controls.Add(femalerb);
            panel1.Controls.Add(malerb);
            panel1.Controls.Add(materialLabel8);
            panel1.Location = new Point(60, 240);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 32);
            panel1.TabIndex = 50;
            // 
            // femalerb
            // 
            femalerb.AutoSize = true;
            femalerb.Location = new Point(241, 8);
            femalerb.Name = "femalerb";
            femalerb.Size = new Size(63, 19);
            femalerb.TabIndex = 40;
            femalerb.TabStop = true;
            femalerb.Text = "Female";
            femalerb.UseVisualStyleBackColor = true;
            // 
            // malerb
            // 
            malerb.AutoSize = true;
            malerb.Location = new Point(141, 7);
            malerb.Name = "malerb";
            malerb.Size = new Size(51, 19);
            malerb.TabIndex = 39;
            malerb.TabStop = true;
            malerb.Text = "Male";
            malerb.UseVisualStyleBackColor = true;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(2, 8);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(55, 19);
            materialLabel8.TabIndex = 38;
            materialLabel8.Text = "Gender:";
            // 
            // dateob
            // 
            dateob.Location = new Point(187, 153);
            dateob.MaxDate = new DateTime(2023, 11, 25, 0, 0, 0, 0);
            dateob.Name = "dateob";
            dateob.Size = new Size(219, 23);
            dateob.TabIndex = 48;
            dateob.Value = new DateTime(2023, 11, 25, 0, 0, 0, 0);
            // 
            // name
            // 
            name.Location = new Point(187, 95);
            name.Name = "name";
            name.Size = new Size(219, 23);
            name.TabIndex = 47;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(60, 154);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(35, 19);
            materialLabel4.TabIndex = 46;
            materialLabel4.Text = "DoB:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(60, 97);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(75, 19);
            materialLabel2.TabIndex = 45;
            materialLabel2.Text = "Full name:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Architecture Engineering", "Artificial Intelligence", "Business Adminstration", "Communication Engineering", "Computer Engineering", "Computer Science", "Electrical Engineering", "Industrial Engineering", "Logistics", "Mechanic Engineering", "Medicine", "Nuclear Engineering", "Petrochemical Engineering", "Pharmacy", "Textile Engineering" });
            comboBox2.Location = new Point(187, 182);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(219, 23);
            comboBox2.TabIndex = 52;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(60, 182);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(114, 19);
            materialLabel1.TabIndex = 53;
            materialLabel1.Text = "Preferred Major:";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(60, 308);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(76, 36);
            materialButton1.TabIndex = 54;
            materialButton1.Text = "Enroll";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // email
            // 
            email.Location = new Point(187, 124);
            email.Name = "email";
            email.Size = new Size(219, 23);
            email.TabIndex = 55;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(60, 126);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(45, 19);
            materialLabel3.TabIndex = 56;
            materialLabel3.Text = "Email:";
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(342, 308);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(64, 36);
            materialButton2.TabIndex = 57;
            materialButton2.Text = "Back";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // EnrollPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 389);
            Controls.Add(materialButton2);
            Controls.Add(materialLabel3);
            Controls.Add(email);
            Controls.Add(materialButton1);
            Controls.Add(comboBox2);
            Controls.Add(materialLabel1);
            Controls.Add(comboBox1);
            Controls.Add(materialLabel13);
            Controls.Add(panel1);
            Controls.Add(dateob);
            Controls.Add(name);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel2);
            Name = "EnrollPanel";
            Text = "EnrollPanel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private Panel panel1;
        private RadioButton femalerb;
        private RadioButton malerb;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private DateTimePicker dateob;
        private TextBox name;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private ComboBox comboBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private TextBox email;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}