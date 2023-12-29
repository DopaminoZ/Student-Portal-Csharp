namespace Student_regestration
{
    partial class ModifyDB
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
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            displaymod = new Label();
            datemod = new DateTimePicker();
            termmod = new TextBox();
            namemod = new TextBox();
            regmod = new TextBox();
            termdisplay = new MaterialSkin.Controls.MaterialLabel();
            datedisplay = new MaterialSkin.Controls.MaterialLabel();
            namedisplay = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialButton4
            // 
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(339, 85);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(64, 36);
            materialButton4.TabIndex = 41;
            materialButton4.Text = "Find";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            materialButton4.Click += materialButton4_Click;
            // 
            // displaymod
            // 
            displaymod.AutoSize = true;
            displaymod.Location = new Point(114, 135);
            displaymod.Name = "displaymod";
            displaymod.Size = new Size(94, 15);
            displaymod.TabIndex = 40;
            displaymod.Text = "Student Name - ";
            // 
            // datemod
            // 
            datemod.Location = new Point(184, 234);
            datemod.MaxDate = new DateTime(2023, 11, 25, 0, 0, 0, 0);
            datemod.Name = "datemod";
            datemod.Size = new Size(219, 23);
            datemod.TabIndex = 33;
            datemod.Value = new DateTime(2023, 11, 25, 0, 0, 0, 0);
            datemod.ValueChanged += datemod_ValueChanged;
            // 
            // termmod
            // 
            termmod.Location = new Point(184, 261);
            termmod.Name = "termmod";
            termmod.PlaceholderText = "ModifyTerm";
            termmod.Size = new Size(219, 23);
            termmod.TabIndex = 34;
            termmod.TextChanged += termmod_TextChanged_1;
            // 
            // namemod
            // 
            namemod.Location = new Point(184, 205);
            namemod.Name = "namemod";
            namemod.PlaceholderText = "ModifyName";
            namemod.Size = new Size(219, 23);
            namemod.TabIndex = 32;
            namemod.TextChanged += namemod_TextChanged;
            // 
            // regmod
            // 
            regmod.Location = new Point(179, 93);
            regmod.Name = "regmod";
            regmod.Size = new Size(153, 23);
            regmod.TabIndex = 31;
            // 
            // termdisplay
            // 
            termdisplay.AutoSize = true;
            termdisplay.Depth = 0;
            termdisplay.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            termdisplay.Location = new Point(67, 263);
            termdisplay.MouseState = MaterialSkin.MouseState.HOVER;
            termdisplay.Name = "termdisplay";
            termdisplay.Size = new Size(5, 19);
            termdisplay.TabIndex = 39;
            termdisplay.Text = "-";
            // 
            // datedisplay
            // 
            datedisplay.AutoSize = true;
            datedisplay.Depth = 0;
            datedisplay.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            datedisplay.Location = new Point(67, 233);
            datedisplay.MouseState = MaterialSkin.MouseState.HOVER;
            datedisplay.Name = "datedisplay";
            datedisplay.Size = new Size(5, 19);
            datedisplay.TabIndex = 38;
            datedisplay.Text = "-";
            // 
            // namedisplay
            // 
            namedisplay.AutoSize = true;
            namedisplay.Depth = 0;
            namedisplay.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            namedisplay.Location = new Point(67, 204);
            namedisplay.MouseState = MaterialSkin.MouseState.HOVER;
            namedisplay.Name = "namedisplay";
            namedisplay.Size = new Size(5, 19);
            namedisplay.TabIndex = 37;
            namedisplay.Text = "-";
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(52, 95);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(108, 19);
            materialLabel10.TabIndex = 36;
            materialLabel10.Text = "Registration #: ";
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(52, 330);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(75, 36);
            materialButton3.TabIndex = 35;
            materialButton3.Text = "Modify";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            materialButton3.Click += materialButton3_Click_1;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(13, 15);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 42;
            materialButton1.Text = "Back";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // ModifyDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(465, 394);
            Controls.Add(materialButton1);
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
            Name = "ModifyDB";
            Text = "ModifyDB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton4;
        private Label displaymod;
        private DateTimePicker datemod;
        private TextBox termmod;
        private TextBox namemod;
        private TextBox regmod;
        private MaterialSkin.Controls.MaterialLabel termdisplay;
        private MaterialSkin.Controls.MaterialLabel datedisplay;
        private MaterialSkin.Controls.MaterialLabel namedisplay;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}