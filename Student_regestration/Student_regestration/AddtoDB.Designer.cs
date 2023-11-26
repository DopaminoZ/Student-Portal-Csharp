namespace Student_regestration
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
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            regdel = new TextBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            Del = new MaterialSkin.Controls.MaterialButton();
            deletename = new Label();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            datemod = new DateTimePicker();
            termmod = new TextBox();
            namemod = new TextBox();
            regmod = new TextBox();
            termdisplay = new MaterialSkin.Controls.MaterialLabel();
            datedisplay = new MaterialSkin.Controls.MaterialLabel();
            namedisplay = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            displaymod = new Label();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(161, 535);
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
            materialLabel1.Location = new Point(22, 265);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(116, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Registeration #: ";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(22, 295);
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
            materialLabel3.Location = new Point(22, 353);
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
            materialLabel4.Location = new Point(22, 323);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(35, 19);
            materialLabel4.TabIndex = 4;
            materialLabel4.Text = "DoB:";
            // 
            // reg
            // 
            reg.Location = new Point(149, 263);
            reg.Name = "reg";
            reg.Size = new Size(219, 23);
            reg.TabIndex = 6;
            // 
            // name
            // 
            name.Location = new Point(149, 293);
            name.Name = "name";
            name.Size = new Size(219, 23);
            name.TabIndex = 7;
            // 
            // term
            // 
            term.Location = new Point(149, 349);
            term.Name = "term";
            term.Size = new Size(219, 23);
            term.TabIndex = 9;
            // 
            // dateob
            // 
            dateob.Location = new Point(149, 322);
            dateob.MaxDate = new DateTime(2023, 11, 25, 0, 0, 0, 0);
            dateob.Name = "dateob";
            dateob.Size = new Size(219, 23);
            dateob.TabIndex = 10;
            dateob.Value = new DateTime(2023, 11, 25, 0, 0, 0, 0);
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(501, 110);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(199, 19);
            materialLabel5.TabIndex = 11;
            materialLabel5.Text = "Database Registration Form";
            materialLabel5.TextAlign = ContentAlignment.TopRight;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(22, 31);
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
            // 
            // regdel
            // 
            regdel.Location = new Point(546, 319);
            regdel.Name = "regdel";
            regdel.Size = new Size(219, 23);
            regdel.TabIndex = 14;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(419, 321);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(116, 19);
            materialLabel6.TabIndex = 13;
            materialLabel6.Text = "Registeration #: ";
            // 
            // Del
            // 
            Del.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Del.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Del.Depth = 0;
            Del.HighEmphasis = true;
            Del.Icon = null;
            Del.Location = new Point(577, 535);
            Del.Margin = new Padding(4, 6, 4, 6);
            Del.MouseState = MaterialSkin.MouseState.HOVER;
            Del.Name = "Del";
            Del.NoAccentTextColor = Color.Empty;
            Del.Size = new Size(73, 36);
            Del.TabIndex = 15;
            Del.Text = "Delete";
            Del.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Del.UseAccentColor = false;
            Del.UseVisualStyleBackColor = true;
            Del.Click += Del_Click;
            // 
            // deletename
            // 
            deletename.AutoSize = true;
            deletename.Location = new Point(501, 369);
            deletename.Name = "deletename";
            deletename.Size = new Size(94, 15);
            deletename.TabIndex = 18;
            deletename.Text = "Student Name - ";
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(985, 535);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(75, 36);
            materialButton3.TabIndex = 19;
            materialButton3.Text = "Modify";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            materialButton3.Click += materialButton3_Click;
            // 
            // datemod
            // 
            datemod.Location = new Point(970, 378);
            datemod.MaxDate = new DateTime(2023, 11, 25, 0, 0, 0, 0);
            datemod.Name = "datemod";
            datemod.Size = new Size(219, 23);
            datemod.TabIndex = 27;
            datemod.Value = new DateTime(2023, 11, 25, 0, 0, 0, 0);
            datemod.ValueChanged += datemod_ValueChanged;
            // 
            // termmod
            // 
            termmod.Location = new Point(970, 405);
            termmod.Name = "termmod";
            termmod.PlaceholderText = "ModifyTerm";
            termmod.Size = new Size(219, 23);
            termmod.TabIndex = 26;
            termmod.TextChanged += termmod_TextChanged;
            // 
            // namemod
            // 
            namemod.Location = new Point(970, 349);
            namemod.Name = "namemod";
            namemod.PlaceholderText = "ModifyName";
            namemod.Size = new Size(219, 23);
            namemod.TabIndex = 25;
            namemod.TextChanged += namemod_TextChanged;
            // 
            // regmod
            // 
            regmod.Location = new Point(970, 221);
            regmod.Name = "regmod";
            regmod.Size = new Size(153, 23);
            regmod.TabIndex = 24;
            // 
            // termdisplay
            // 
            termdisplay.AutoSize = true;
            termdisplay.Depth = 0;
            termdisplay.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            termdisplay.Location = new Point(880, 412);
            termdisplay.MouseState = MaterialSkin.MouseState.HOVER;
            termdisplay.Name = "termdisplay";
            termdisplay.Size = new Size(5, 19);
            termdisplay.TabIndex = 23;
            termdisplay.Text = "-";
            // 
            // datedisplay
            // 
            datedisplay.AutoSize = true;
            datedisplay.Depth = 0;
            datedisplay.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            datedisplay.Location = new Point(880, 382);
            datedisplay.MouseState = MaterialSkin.MouseState.HOVER;
            datedisplay.Name = "datedisplay";
            datedisplay.Size = new Size(5, 19);
            datedisplay.TabIndex = 22;
            datedisplay.Text = "-";
            // 
            // namedisplay
            // 
            namedisplay.AutoSize = true;
            namedisplay.Depth = 0;
            namedisplay.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            namedisplay.Location = new Point(880, 353);
            namedisplay.MouseState = MaterialSkin.MouseState.HOVER;
            namedisplay.Name = "namedisplay";
            namedisplay.Size = new Size(5, 19);
            namedisplay.TabIndex = 21;
            namedisplay.Text = "-";
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(843, 223);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(116, 19);
            materialLabel10.TabIndex = 20;
            materialLabel10.Text = "Registeration #: ";
            // 
            // displaymod
            // 
            displaymod.AutoSize = true;
            displaymod.Location = new Point(905, 263);
            displaymod.Name = "displaymod";
            displaymod.Size = new Size(94, 15);
            displaymod.TabIndex = 28;
            displaymod.Text = "Student Name - ";
            // 
            // materialButton4
            // 
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(1130, 213);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(64, 36);
            materialButton4.TabIndex = 30;
            materialButton4.Text = "Find";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            materialButton4.Click += materialButton4_Click;
            // 
            // AddtoDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1227, 643);
            Controls.Add(materialButton4);
            Controls.Add(displaymod);
            Controls.Add(datemod);
            Controls.Add(termmod);
            Controls.Add(namemod);
            Controls.Add(regmod);
            Controls.Add(termdisplay);
            Controls.Add(datedisplay);
            Controls.Add(namedisplay);
            Controls.Add(materialLabel10);
            Controls.Add(materialButton3);
            Controls.Add(deletename);
            Controls.Add(Del);
            Controls.Add(regdel);
            Controls.Add(materialLabel6);
            Controls.Add(materialButton2);
            Controls.Add(materialLabel5);
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
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private TextBox regdel;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton Del;
        private Label deletename;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private DateTimePicker datemod;
        private TextBox termmod;
        private TextBox namemod;
        private TextBox regmod;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private Label displaymod;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialLabel termdisplay;
        private MaterialSkin.Controls.MaterialLabel datedisplay;
        private MaterialSkin.Controls.MaterialLabel namedisplay;
    }
}