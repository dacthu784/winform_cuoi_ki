namespace Quanlyquanan
{
    partial class fAccount
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txbUsername = new TextBox();
            txbPassword = new TextBox();
            txbNewPassword = new TextBox();
            txbPasswordNL = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txbUsername
            // 
            txbUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbUsername.Location = new Point(138, 10);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(200, 25);
            txbUsername.TabIndex = 1;
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbPassword.Location = new Point(138, 41);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(200, 25);
            txbPassword.TabIndex = 2;
            // 
            // txbNewPassword
            // 
            txbNewPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbNewPassword.Location = new Point(138, 72);
            txbNewPassword.Name = "txbNewPassword";
            txbNewPassword.Size = new Size(200, 25);
            txbNewPassword.TabIndex = 3;
            // 
            // txbPasswordNL
            // 
            txbPasswordNL.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbPasswordNL.Location = new Point(138, 103);
            txbPasswordNL.Name = "txbPasswordNL";
            txbPasswordNL.Size = new Size(200, 25);
            txbPasswordNL.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 20);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 5;
            label1.Text = "Tên hiển thị";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 51);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 82);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 7;
            label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 113);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 8;
            label4.Text = "Nhập lại mật khẩu";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txbNewPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txbUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbPasswordNL);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 186);
            panel1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(263, 157);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(181, 157);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            // 
            // fAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 204);
            Controls.Add(panel1);
            Name = "fAccount";
            Text = "Đổi Mật khẩu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox txbUsername;
        private TextBox txbPassword;
        private TextBox txbNewPassword;
        private TextBox txbPasswordNL;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Button button2;
        private Button button1;
    }
}