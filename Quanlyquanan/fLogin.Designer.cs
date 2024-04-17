//namespace Quanlyquanan
//{
//    partial class fLogin
//    {
//        /// <summary>
//        ///  Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        ///  Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        ///  Required method for Designer support - do not modify
//        ///  the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            txbUsername = new TextBox();
//            txbPassword = new TextBox();
//            panel1 = new Panel();
//            lbPassword = new Label();
//            btnLogin = new Button();
//            pictureBox2 = new PictureBox();
//            pictureBox1 = new PictureBox();
//            label3 = new Label();
//            label2 = new Label();
//            lblUsername = new Label();
//            pictureBox3 = new PictureBox();
//            panel1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
//            SuspendLayout();
//            // 
//            // txbUsername
//            // 
//            txbUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
//            txbUsername.Location = new Point(33, 105);
//            txbUsername.Margin = new Padding(3, 4, 3, 4);
//            txbUsername.Name = "txbUsername";
//            txbUsername.Size = new Size(345, 29);
//            txbUsername.TabIndex = 0;
//            // 
//            // txbPassword
//            // 
//            txbPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
//            txbPassword.Location = new Point(33, 179);
//            txbPassword.Margin = new Padding(3, 4, 3, 4);
//            txbPassword.Name = "txbPassword";
//            txbPassword.Size = new Size(345, 29);
//            txbPassword.TabIndex = 1;
//            txbPassword.UseSystemPasswordChar = true;
//            // 
//            // panel1
//            // 
//            panel1.Controls.Add(lbPassword);
//            panel1.Controls.Add(btnLogin);
//            panel1.Controls.Add(pictureBox2);
//            panel1.Controls.Add(pictureBox1);
//            panel1.Controls.Add(label3);
//            panel1.Controls.Add(label2);
//            panel1.Controls.Add(lblUsername);
//            panel1.Controls.Add(txbUsername);
//            panel1.Controls.Add(txbPassword);
//            panel1.Location = new Point(222, 16);
//            panel1.Margin = new Padding(3, 4, 3, 4);
//            panel1.Name = "panel1";
//            panel1.Size = new Size(390, 285);
//            panel1.TabIndex = 2;
//            // 
//            // lbPassword
//            // 
//            lbPassword.AutoSize = true;
//            lbPassword.Location = new Point(34, 215);
//            lbPassword.Name = "lbPassword";
//            lbPassword.Size = new Size(0, 20);
//            lbPassword.TabIndex = 6;
//            // 
//            // btnLogin
//            // 
//            btnLogin.Location = new Point(293, 220);
//            btnLogin.Margin = new Padding(3, 4, 3, 4);
//            btnLogin.Name = "btnLogin";
//            btnLogin.Size = new Size(86, 45);
//            btnLogin.TabIndex = 5;
//            btnLogin.Text = "Đăng nhập";
//            btnLogin.UseVisualStyleBackColor = true;
//            btnLogin.Click += btnLogin_Click;
//            // 
//            // pictureBox2
//            // 
//            pictureBox2.Image = Properties.Resources.z5122610956258_b7348734f361b3fd8ab14b30808cb82c;
//            pictureBox2.Location = new Point(3, 179);
//            pictureBox2.Margin = new Padding(3, 4, 3, 4);
//            pictureBox2.Name = "pictureBox2";
//            pictureBox2.Size = new Size(29, 33);
//            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
//            pictureBox2.TabIndex = 3;
//            pictureBox2.TabStop = false;
//            // 
//            // pictureBox1
//            // 
//            pictureBox1.Image = Properties.Resources.z5122610927750_0a548afd8f204a94b05f3704667ae3fa;
//            pictureBox1.Location = new Point(3, 105);
//            pictureBox1.Margin = new Padding(3, 4, 3, 4);
//            pictureBox1.Name = "pictureBox1";
//            pictureBox1.Size = new Size(29, 33);
//            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
//            pictureBox1.TabIndex = 3;
//            pictureBox1.TabStop = false;
//            // 
//            // label3
//            // 
//            label3.AutoSize = true;
//            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
//            label3.Location = new Point(130, 27);
//            label3.Name = "label3";
//            label3.Size = new Size(122, 32);
//            label3.TabIndex = 4;
//            label3.Text = "YAMIYAMI";
//            // 
//            // label2
//            // 
//            label2.AutoSize = true;
//            label2.Location = new Point(33, 155);
//            label2.Name = "label2";
//            label2.Size = new Size(72, 20);
//            label2.TabIndex = 3;
//            label2.Text = "Mật Khẩu";
//            // 
//            // lblUsername
//            // 
//            lblUsername.AutoSize = true;
//            lblUsername.Location = new Point(33, 81);
//            lblUsername.Name = "lblUsername";
//            lblUsername.Size = new Size(71, 20);
//            lblUsername.TabIndex = 2;
//            lblUsername.Text = "Tài khoản";
//            // 
//            // pictureBox3
//            // 
//            pictureBox3.Image = Properties.Resources.z5122610938446_526d806a20e83db10caf0b4d1a4715ba;
//            pictureBox3.Location = new Point(71, 121);
//            pictureBox3.Margin = new Padding(3, 4, 3, 4);
//            pictureBox3.Name = "pictureBox3";
//            pictureBox3.Size = new Size(80, 93);
//            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
//            pictureBox3.TabIndex = 3;
//            pictureBox3.TabStop = false;
//            // 
//            // fLogin
//            // 
//            AcceptButton = btnLogin;
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(614, 317);
//            Controls.Add(pictureBox3);
//            Controls.Add(panel1);
//            Margin = new Padding(3, 4, 3, 4);
//            Name = "fLogin";
//            Text = "Đăng nhập";
//            panel1.ResumeLayout(false);
//            panel1.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
//            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
//            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
//            ResumeLayout(false);
//        }

//        #endregion

//        private TextBox txbUsername;
//        private TextBox txbPassword;
//        private Panel panel1;
//        private Label label3;
//        private Label label2;
//        private Label lblUsername;
//        private PictureBox pictureBox2;
//        private PictureBox pictureBox1;
//        private PictureBox pictureBox3;
//        private Button btnLogin;
//        private Label lbPassword;
//    }
//}