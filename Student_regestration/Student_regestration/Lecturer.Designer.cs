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
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label8 = new Label();
            errormes = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 66);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 105);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 1;
            label1.Text = "7th";
            // 
            // text7
            // 
            text7.Location = new Point(102, 103);
            text7.Margin = new Padding(3, 2, 3, 2);
            text7.Name = "text7";
            text7.Size = new Size(85, 23);
            text7.TabIndex = 2;
            // 
            // text12
            // 
            text12.Location = new Point(102, 132);
            text12.Margin = new Padding(3, 2, 3, 2);
            text12.Name = "text12";
            text12.Size = new Size(85, 23);
            text12.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 134);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "12th";
            // 
            // textwork
            // 
            textwork.Location = new Point(102, 161);
            textwork.Margin = new Padding(3, 2, 3, 2);
            textwork.Name = "textwork";
            textwork.Size = new Size(85, 23);
            textwork.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 164);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
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
            materialButton1.Location = new Point(21, 265);
            materialButton1.Margin = new Padding(4);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(103, 36);
            materialButton1.TabIndex = 8;
            materialButton1.Text = "Calculate";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // grade
            // 
            grade.AutoSize = true;
            grade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grade.Location = new Point(21, 226);
            grade.Name = "grade";
            grade.Size = new Size(80, 15);
            grade.TabIndex = 8;
            grade.Text = "Final Grade - ";
            // 
            // textfinal
            // 
            textfinal.Location = new Point(102, 190);
            textfinal.Margin = new Padding(3, 2, 3, 2);
            textfinal.Name = "textfinal";
            textfinal.Size = new Size(85, 23);
            textfinal.TabIndex = 7;
            textfinal.Text = "0";
            textfinal.TextChanged += textfinal_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 192);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
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
            materialButton2.Location = new Point(21, 309);
            materialButton2.Margin = new Padding(4);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(77, 36);
            materialButton2.TabIndex = 9;
            materialButton2.Text = "Update";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(206, 310);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(87, 36);
            materialButton3.TabIndex = 13;
            materialButton3.Text = "Sign out";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            materialButton3.Click += materialButton3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 105);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 14;
            label5.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(235, 134);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 15;
            label6.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(235, 164);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 16;
            label7.Text = "-";
            // 
            // button1
            // 
            button1.Location = new Point(238, 12);
            button1.Name = "button1";
            button1.Size = new Size(77, 26);
            button1.TabIndex = 25;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(53, 15);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(153, 23);
            comboBox2.TabIndex = 26;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(5, 19);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 27;
            label8.Text = "Course:";
            // 
            // errormes
            // 
            errormes.AutoSize = true;
            errormes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errormes.ForeColor = Color.Red;
            errormes.Location = new Point(23, 351);
            errormes.Name = "errormes";
            errormes.Size = new Size(256, 15);
            errormes.TabIndex = 28;
            errormes.Text = "Some of the inputs are wrong, check again....";
            errormes.Visible = false;
            // 
            // Lecturer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(327, 378);
            Controls.Add(errormes);
            Controls.Add(label8);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(materialButton3);
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
            Text = "Lecturer Panel";
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
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private ComboBox comboBox2;
        private Label label8;
        private Label errormes;
    }
}