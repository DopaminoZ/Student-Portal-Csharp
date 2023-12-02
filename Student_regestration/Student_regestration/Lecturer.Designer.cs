namespace Student_regestration
{
    partial class Lecturer
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
            label1 = new Label();
            text7 = new TextBox();
            text12 = new TextBox();
            label2 = new Label();
            textwork = new TextBox();
            label3 = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            grade = new Label();
            textfinal = new TextBox();
            label4 = new Label();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(54, 30);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 69);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 1;
            label1.Text = "7th";
            // 
            // text7
            // 
            text7.Location = new Point(135, 67);
            text7.Margin = new Padding(3, 2, 3, 2);
            text7.Name = "text7";
            text7.Size = new Size(85, 23);
            text7.TabIndex = 2;
            // 
            // text12
            // 
            text12.Location = new Point(135, 96);
            text12.Margin = new Padding(3, 2, 3, 2);
            text12.Name = "text12";
            text12.Size = new Size(85, 23);
            text12.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 98);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "12th";
            // 
            // textwork
            // 
            textwork.Location = new Point(135, 125);
            textwork.Margin = new Padding(3, 2, 3, 2);
            textwork.Name = "textwork";
            textwork.Size = new Size(85, 23);
            textwork.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 128);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 5;
            label3.Text = "Coursework";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(54, 229);
            materialButton1.Margin = new Padding(4, 4, 4, 4);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(103, 36);
            materialButton1.TabIndex = 7;
            materialButton1.Text = "Calculate";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // grade
            // 
            grade.AutoSize = true;
            grade.Location = new Point(54, 190);
            grade.Name = "grade";
            grade.Size = new Size(77, 15);
            grade.TabIndex = 8;
            grade.Text = "Final Grade - ";
            // 
            // textfinal
            // 
            textfinal.Location = new Point(135, 154);
            textfinal.Margin = new Padding(3, 2, 3, 2);
            textfinal.Name = "textfinal";
            textfinal.Size = new Size(85, 23);
            textfinal.TabIndex = 10;
            textfinal.Text = "0";
            textfinal.TextChanged += textfinal_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 156);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 9;
            label4.Text = "Final Exam";
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(54, 273);
            materialButton2.Margin = new Padding(4, 4, 4, 4);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(77, 36);
            materialButton2.TabIndex = 11;
            materialButton2.Text = "Update";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // Lecturer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 338);
            Controls.Add(materialButton2);
            Controls.Add(textfinal);
            Controls.Add(label4);
            Controls.Add(grade);
            Controls.Add(materialButton1);
            Controls.Add(textwork);
            Controls.Add(label3);
            Controls.Add(text12);
            Controls.Add(label2);
            Controls.Add(text7);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Lecturer";
            Text = "Lecturer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private TextBox text7;
        private TextBox text12;
        private Label label2;
        private TextBox textwork;
        private Label label3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Label grade;
        private TextBox textfinal;
        private Label label4;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}