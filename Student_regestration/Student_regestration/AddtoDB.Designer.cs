﻿namespace Student_regestration
{
    partial class AddtoDB
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            reg = new TextBox();
            name = new TextBox();
            term = new TextBox();
            dateob = new DateTimePicker();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            passbox = new TextBox();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            adminrb = new RadioButton();
            nonadminrb = new RadioButton();
            femalerb = new RadioButton();
            malerb = new RadioButton();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            typebox = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            checkedListBox1 = new CheckedListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(223, 422);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "Add";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(84, 121);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(108, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Registration #: ";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(84, 180);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(47, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Name:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(84, 238);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(42, 19);
            materialLabel3.TabIndex = 5;
            materialLabel3.Text = "Term:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(84, 208);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(94, 19);
            materialLabel4.TabIndex = 4;
            materialLabel4.Text = "Date of Birth:";
            // 
            // reg
            // 
            reg.Location = new Point(211, 119);
            reg.Name = "reg";
            reg.Size = new Size(219, 23);
            reg.TabIndex = 6;
            // 
            // name
            // 
            name.Location = new Point(211, 178);
            name.Name = "name";
            name.Size = new Size(219, 23);
            name.TabIndex = 8;
            // 
            // term
            // 
            term.Location = new Point(211, 238);
            term.Name = "term";
            term.Size = new Size(219, 23);
            term.TabIndex = 10;
            // 
            // dateob
            // 
            dateob.Location = new Point(211, 207);
            dateob.MaxDate = new DateTime(2023, 11, 25, 0, 0, 0, 0);
            dateob.Name = "dateob";
            dateob.Size = new Size(219, 23);
            dateob.TabIndex = 9;
            dateob.Value = new DateTime(2023, 11, 25, 0, 0, 0, 0);
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(13, 15);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(64, 36);
            materialButton2.TabIndex = 12;
            materialButton2.Text = "Back";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // passbox
            // 
            passbox.Location = new Point(211, 148);
            passbox.Name = "passbox";
            passbox.Size = new Size(219, 23);
            passbox.TabIndex = 7;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(84, 152);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(75, 19);
            materialLabel11.TabIndex = 31;
            materialLabel11.Text = "Password:";
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(84, 267);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(40, 19);
            materialLabel12.TabIndex = 33;
            materialLabel12.Text = "Type:";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(2, 5);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(123, 19);
            materialLabel7.TabIndex = 35;
            materialLabel7.Text = "Admin Privileges:";
            // 
            // adminrb
            // 
            adminrb.AutoSize = true;
            adminrb.Location = new Point(141, 5);
            adminrb.Name = "adminrb";
            adminrb.Size = new Size(61, 19);
            adminrb.TabIndex = 36;
            adminrb.TabStop = true;
            adminrb.Text = "Admin";
            adminrb.UseVisualStyleBackColor = true;
            // 
            // nonadminrb
            // 
            nonadminrb.AutoSize = true;
            nonadminrb.Location = new Point(241, 5);
            nonadminrb.Name = "nonadminrb";
            nonadminrb.Size = new Size(89, 19);
            nonadminrb.TabIndex = 37;
            nonadminrb.TabStop = true;
            nonadminrb.Text = "Non-Admin";
            nonadminrb.UseVisualStyleBackColor = true;
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
            // typebox
            // 
            typebox.FormattingEnabled = true;
            typebox.Items.AddRange(new object[] { "Undergrad", "Postgrad", "Lecturer", "Teaching Assistant" });
            typebox.Location = new Point(211, 267);
            typebox.Name = "typebox";
            typebox.Size = new Size(219, 23);
            typebox.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(femalerb);
            panel1.Controls.Add(malerb);
            panel1.Controls.Add(materialLabel8);
            panel1.Location = new Point(84, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 32);
            panel1.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.Controls.Add(nonadminrb);
            panel2.Controls.Add(adminrb);
            panel2.Controls.Add(materialLabel7);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(84, 320);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 27);
            panel2.TabIndex = 43;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "CC319", "CC317", "BA323", "EC339", "NE466", "EC320" });
            comboBox1.Location = new Point(211, 296);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 23);
            comboBox1.TabIndex = 12;
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(84, 296);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(58, 19);
            materialLabel13.TabIndex = 44;
            materialLabel13.Text = "Subject:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(458, 198);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(180, 184);
            checkedListBox1.TabIndex = 45;
            // 
            // AddtoDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(640, 506);
            Controls.Add(checkedListBox1);
            Controls.Add(comboBox1);
            Controls.Add(materialLabel13);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(typebox);
            Controls.Add(materialLabel12);
            Controls.Add(passbox);
            Controls.Add(materialLabel11);
            Controls.Add(materialButton2);
            Controls.Add(dateob);
            Controls.Add(term);
            Controls.Add(name);
            Controls.Add(reg);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(materialButton1);
            Name = "AddtoDB";
            Text = "Admin Panel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private TextBox reg;
        private TextBox name;
        private TextBox term;
        private DateTimePicker dateob;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private TextBox passbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private ComboBox typebox;
        private RadioButton Admin;
        private Panel panel1;
        private Panel panel2;
        private RadioButton adminrb;
        private RadioButton nonadminrb;
        private RadioButton femalerb;
        private RadioButton malerb;
        private ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private CheckedListBox checkedListBox1;
    }
}