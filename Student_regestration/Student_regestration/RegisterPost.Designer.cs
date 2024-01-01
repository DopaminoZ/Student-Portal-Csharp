namespace Student_regestration
{
    partial class RegisterPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPost));
            typebox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // typebox
            // 
            typebox.FormattingEnabled = true;
            typebox.ImeMode = ImeMode.Disable;
            typebox.Location = new Point(191, 219);
            typebox.Name = "typebox";
            typebox.Size = new Size(219, 23);
            typebox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 222);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 13;
            label1.Text = "Programme:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(47, 164);
            label2.Name = "label2";
            label2.Size = new Size(414, 32);
            label2.TabIndex = 14;
            label2.Text = "Postgraduate Studies Registeration";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(191, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 146);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(93, 295);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(67, 36);
            materialButton1.TabIndex = 16;
            materialButton1.Text = "Apply";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(323, 295);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(87, 36);
            materialButton2.TabIndex = 17;
            materialButton2.Text = "Sign out";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // RegisterPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(545, 383);
            Controls.Add(materialButton2);
            Controls.Add(materialButton1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(typebox);
            Name = "RegisterPost";
            Text = "Postgraduate Programmes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox typebox;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}