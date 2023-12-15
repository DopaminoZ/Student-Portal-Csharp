namespace Student_regestration
{
    partial class CreateC
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
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            name = new TextBox();
            code = new TextBox();
            credit = new TextBox();
            SuspendLayout();
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(28, 221);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(76, 36);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "Create";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 105);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Course name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 136);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Course code:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 165);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 3;
            label3.Text = "Course credit hours:";
            // 
            // name
            // 
            name.Location = new Point(169, 97);
            name.Name = "name";
            name.Size = new Size(133, 23);
            name.TabIndex = 4;
            // 
            // code
            // 
            code.Location = new Point(169, 128);
            code.Name = "code";
            code.Size = new Size(133, 23);
            code.TabIndex = 5;
            // 
            // credit
            // 
            credit.Location = new Point(169, 157);
            credit.Name = "credit";
            credit.Size = new Size(133, 23);
            credit.TabIndex = 6;
            // 
            // CreateC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 337);
            Controls.Add(credit);
            Controls.Add(code);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(materialButton1);
            Name = "CreateC";
            Text = "CreateC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox code;
        private TextBox credit;
    }
}