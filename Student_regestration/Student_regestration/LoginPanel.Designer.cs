namespace Student_regestration
{
    partial class LoginPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            loginButton = new MaterialSkin.Controls.MaterialButton();
            idbox = new TextBox();
            passwordbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loginButton.Depth = 0;
            loginButton.HighEmphasis = true;
            loginButton.Icon = null;
            loginButton.Location = new Point(417, 364);
            loginButton.Margin = new Padding(4, 6, 4, 6);
            loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            loginButton.Name = "loginButton";
            loginButton.NoAccentTextColor = Color.Empty;
            loginButton.Size = new Size(64, 36);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            loginButton.UseAccentColor = false;
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // idbox
            // 
            idbox.Location = new Point(522, 243);
            idbox.Name = "idbox";
            idbox.Size = new Size(275, 23);
            idbox.TabIndex = 1;
            // 
            // passwordbox
            // 
            passwordbox.Location = new Point(522, 286);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(275, 23);
            passwordbox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(417, 240);
            label1.Name = "label1";
            label1.Size = new Size(36, 22);
            label1.TabIndex = 3;
            label1.Text = "Id :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(417, 287);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 4;
            label2.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(418, 330);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(823, 425);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(76, 36);
            materialButton1.TabIndex = 6;
            materialButton1.Text = "Enroll";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(548, 425);
            label4.Name = "label4";
            label4.Size = new Size(268, 44);
            label4.TabIndex = 7;
            label4.Text = "Interested in applying to AAST? \r\nClick here to enroll...";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(346, 239);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(-1, 229);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(346, 240);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(334, -12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(11, 486);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(418, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(450, 160);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(0, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(342, 10);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // LoginPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(912, 469);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox3);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(materialButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordbox);
            Controls.Add(idbox);
            Controls.Add(loginButton);
            Name = "LoginPanel";
            Text = "Login Panel";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton loginButton;
        private TextBox idbox;
        private TextBox passwordbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private PictureBox pictureBox3;
        private GroupBox groupBox2;
    }
}