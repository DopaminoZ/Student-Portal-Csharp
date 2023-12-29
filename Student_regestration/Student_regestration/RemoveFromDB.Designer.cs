namespace Student_regestration
{
    partial class RemoveFromDB
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
            deletename = new Label();
            Del = new MaterialSkin.Controls.MaterialButton();
            regdel = new TextBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // deletename
            // 
            deletename.AutoSize = true;
            deletename.Location = new Point(124, 235);
            deletename.Name = "deletename";
            deletename.Size = new Size(94, 15);
            deletename.TabIndex = 23;
            deletename.Text = "Student Name - ";
            // 
            // Del
            // 
            Del.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Del.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Del.Depth = 0;
            Del.HighEmphasis = true;
            Del.Icon = null;
            Del.Location = new Point(42, 399);
            Del.Margin = new Padding(4, 6, 4, 6);
            Del.MouseState = MaterialSkin.MouseState.HOVER;
            Del.Name = "Del";
            Del.NoAccentTextColor = Color.Empty;
            Del.Size = new Size(73, 36);
            Del.TabIndex = 22;
            Del.Text = "Delete";
            Del.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Del.UseAccentColor = false;
            Del.UseVisualStyleBackColor = true;
            Del.Click += Del_Click_1;
            // 
            // regdel
            // 
            regdel.Location = new Point(169, 185);
            regdel.Name = "regdel";
            regdel.Size = new Size(219, 23);
            regdel.TabIndex = 20;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(42, 187);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(108, 19);
            materialLabel6.TabIndex = 21;
            materialLabel6.Text = "Registration #: ";
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
            materialButton1.TabIndex = 24;
            materialButton1.Text = "Back";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // RemoveFromDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(447, 450);
            Controls.Add(materialButton1);
            Controls.Add(deletename);
            Controls.Add(Del);
            Controls.Add(regdel);
            Controls.Add(materialLabel6);
            Name = "RemoveFromDB";
            Text = "RemoveFromDB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label deletename;
        private MaterialSkin.Controls.MaterialButton Del;
        private TextBox regdel;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}