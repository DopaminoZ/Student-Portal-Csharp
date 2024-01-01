namespace Student_regestration
{
    partial class AddProg
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
            textBox1 = new TextBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 90);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Programme_Type Topic Time_of_start";
            textBox1.Size = new Size(268, 23);
            textBox1.TabIndex = 0;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(25, 165);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(146, 36);
            materialButton1.TabIndex = 1;
            materialButton1.Text = "Add Programme";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 93);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 2;
            label1.Text = "Programme Details:";
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(346, 165);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(64, 36);
            materialButton2.TabIndex = 3;
            materialButton2.Text = "Back";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // AddProg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(454, 227);
            Controls.Add(materialButton2);
            Controls.Add(label1);
            Controls.Add(materialButton1);
            Controls.Add(textBox1);
            Name = "AddProg";
            Text = "AddProg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}