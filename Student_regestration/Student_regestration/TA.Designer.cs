namespace Student_regestration
{
    partial class TA
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
            textwork = new TextBox();
            label3 = new Label();
            text12 = new TextBox();
            label2 = new Label();
            text7 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // textwork
            // 
            textwork.Location = new Point(95, 195);
            textwork.Margin = new Padding(3, 2, 3, 2);
            textwork.Name = "textwork";
            textwork.Size = new Size(85, 23);
            textwork.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 198);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 12;
            label3.Text = "Coursework";
            // 
            // text12
            // 
            text12.Location = new Point(95, 166);
            text12.Margin = new Padding(3, 2, 3, 2);
            text12.Name = "text12";
            text12.Size = new Size(85, 23);
            text12.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 168);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 10;
            label2.Text = "12th";
            // 
            // text7
            // 
            text7.Location = new Point(95, 137);
            text7.Margin = new Padding(3, 2, 3, 2);
            text7.Name = "text7";
            text7.Size = new Size(85, 23);
            text7.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 139);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 8;
            label1.Text = "7th";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 100);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(225, 198);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 19;
            label7.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(225, 168);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 18;
            label6.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(225, 139);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 17;
            label5.Text = "-";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(13, 253);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(77, 36);
            materialButton1.TabIndex = 22;
            materialButton1.Text = "Update";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialButton4
            // 
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(178, 253);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(87, 36);
            materialButton4.TabIndex = 23;
            materialButton4.Text = "Sign Out";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            materialButton4.Click += materialButton4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(189, 5);
            button1.Name = "button1";
            button1.Size = new Size(77, 26);
            button1.TabIndex = 24;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(95, 56);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(166, 23);
            comboBox2.TabIndex = 25;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 59);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 26;
            label4.Text = "Course:";
            // 
            // TA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 300);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(materialButton4);
            Controls.Add(materialButton1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textwork);
            Controls.Add(label3);
            Controls.Add(text12);
            Controls.Add(label2);
            Controls.Add(text7);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "TA";
            Text = "Teaching Assistant Panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textwork;
        private Label label3;
        private TextBox text12;
        private Label label2;
        private TextBox text7;
        private Label label1;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private Button button1;
        private ComboBox comboBox2;
        private Label label4;
    }
}