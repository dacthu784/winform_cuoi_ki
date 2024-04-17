//namespace Quanlyquanan
//{
//    partial class ftablemanager
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
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
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            components = new System.ComponentModel.Container();
//            comboBox1 = new ComboBox();
//            contextMenuStrip1 = new ContextMenuStrip(components);
//            menuStrip2 = new MenuStrip();
//            adminToolStripMenuItem = new ToolStripMenuItem();
//            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
//            toolTip1 = new ToolTip(components);
//            button1 = new Button();
//            listView1 = new ListView();
//            numericUpDown1 = new NumericUpDown();
//            button2 = new Button();
//            button3 = new Button();
//            numericUpDown2 = new NumericUpDown();
//            comboBox2 = new ComboBox();
//            label1 = new Label();
//            comboBox3 = new ComboBox();
//            textBox1 = new TextBox();
//            button4 = new Button();
//            listView2 = new ListView();
//            menuStrip2.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
//            SuspendLayout();
//            // 
//            // comboBox1
//            // 
//            comboBox1.Cursor = Cursors.Hand;
//            comboBox1.FormattingEnabled = true;
//            comboBox1.Location = new Point(507, 25);
//            comboBox1.Margin = new Padding(3, 2, 3, 2);
//            comboBox1.Name = "comboBox1";
//            comboBox1.Size = new Size(196, 23);
//            comboBox1.TabIndex = 0;
//            comboBox1.Text = "Nguyen liệu";
//            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
//            // 
//            // contextMenuStrip1
//            // 
//            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
//            contextMenuStrip1.Name = "contextMenuStrip1";
//            contextMenuStrip1.Size = new Size(61, 4);
//            // 
//            // menuStrip2
//            // 
//            menuStrip2.ImageScalingSize = new Size(20, 20);
//            menuStrip2.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
//            menuStrip2.Location = new Point(0, 0);
//            menuStrip2.Name = "menuStrip2";
//            menuStrip2.Padding = new Padding(5, 2, 0, 2);
//            menuStrip2.Size = new Size(862, 24);
//            menuStrip2.TabIndex = 3;
//            menuStrip2.Text = "menuStrip2";
//            // 
//            // adminToolStripMenuItem
//            // 
//            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
//            adminToolStripMenuItem.Size = new Size(55, 20);
//            adminToolStripMenuItem.Text = "Admin";
//            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
//            // 
//            // thôngTinTàiKhoảnToolStripMenuItem
//            // 
//            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
//            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(122, 20);
//            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
//            thôngTinTàiKhoảnToolStripMenuItem.Click += thôngTinTàiKhoảnToolStripMenuItem_Click;
//            // 
//            // button1
//            // 
//            button1.Cursor = Cursors.Hand;
//            button1.Location = new Point(709, 25);
//            button1.Margin = new Padding(3, 2, 3, 2);
//            button1.Name = "button1";
//            button1.Size = new Size(82, 54);
//            button1.TabIndex = 6;
//            button1.Text = "Thêm món";
//            button1.UseVisualStyleBackColor = true;
//            // 
//            // listView1
//            // 
//            listView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
//            listView1.Location = new Point(12, 25);
//            listView1.Margin = new Padding(3, 2, 3, 2);
//            listView1.Name = "listView1";
//            listView1.Size = new Size(488, 434);
//            listView1.TabIndex = 8;
//            listView1.UseCompatibleStateImageBehavior = false;
//            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
//            // 
//            // numericUpDown1
//            // 
//            numericUpDown1.Cursor = Cursors.Hand;
//            numericUpDown1.Location = new Point(797, 26);
//            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
//            numericUpDown1.Name = "numericUpDown1";
//            numericUpDown1.Size = new Size(53, 23);
//            numericUpDown1.TabIndex = 9;
//            numericUpDown1.TextAlign = HorizontalAlignment.Center;
//            // 
//            // button2
//            // 
//            button2.Cursor = Cursors.Hand;
//            button2.Location = new Point(626, 420);
//            button2.Margin = new Padding(3, 2, 3, 2);
//            button2.Name = "button2";
//            button2.Size = new Size(100, 39);
//            button2.TabIndex = 10;
//            button2.Text = "Giảm giá ( % )";
//            button2.UseVisualStyleBackColor = true;
//            // 
//            // button3
//            // 
//            button3.Cursor = Cursors.Hand;
//            button3.Location = new Point(507, 420);
//            button3.Margin = new Padding(3, 2, 3, 2);
//            button3.Name = "button3";
//            button3.Size = new Size(82, 39);
//            button3.TabIndex = 11;
//            button3.Text = "Chuyển bàn";
//            button3.UseVisualStyleBackColor = true;
//            button3.Click += button3_Click;
//            // 
//            // numericUpDown2
//            // 
//            numericUpDown2.Cursor = Cursors.Hand;
//            numericUpDown2.Location = new Point(626, 395);
//            numericUpDown2.Margin = new Padding(3, 2, 3, 2);
//            numericUpDown2.Name = "numericUpDown2";
//            numericUpDown2.Size = new Size(100, 23);
//            numericUpDown2.TabIndex = 12;
//            numericUpDown2.TextAlign = HorizontalAlignment.Center;
//            // 
//            // comboBox2
//            // 
//            comboBox2.Cursor = Cursors.Hand;
//            comboBox2.FormattingEnabled = true;
//            comboBox2.Location = new Point(506, 393);
//            comboBox2.Margin = new Padding(3, 2, 3, 2);
//            comboBox2.Name = "comboBox2";
//            comboBox2.Size = new Size(83, 23);
//            comboBox2.TabIndex = 13;
//            comboBox2.Text = "Bàn 0";
//            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
//            // 
//            // label1
//            // 
//            label1.AutoSize = true;
//            label1.Location = new Point(760, 378);
//            label1.Name = "label1";
//            label1.Size = new Size(34, 15);
//            label1.TabIndex = 14;
//            label1.Text = "Tổng";
//            // 
//            // comboBox3
//            // 
//            comboBox3.Cursor = Cursors.Hand;
//            comboBox3.FormattingEnabled = true;
//            comboBox3.Location = new Point(507, 56);
//            comboBox3.Margin = new Padding(3, 2, 3, 2);
//            comboBox3.Name = "comboBox3";
//            comboBox3.Size = new Size(196, 23);
//            comboBox3.TabIndex = 15;
//            comboBox3.Text = "Sản phầm từ nguyên liệu";
//            // 
//            // textBox1
//            // 
//            textBox1.Location = new Point(760, 395);
//            textBox1.Margin = new Padding(3, 2, 3, 2);
//            textBox1.Name = "textBox1";
//            textBox1.Size = new Size(90, 23);
//            textBox1.TabIndex = 16;
//            textBox1.Text = "0";
//            textBox1.TextAlign = HorizontalAlignment.Right;
//            // 
//            // button4
//            // 
//            button4.Cursor = Cursors.Hand;
//            button4.Location = new Point(760, 420);
//            button4.Margin = new Padding(3, 2, 3, 2);
//            button4.Name = "button4";
//            button4.Size = new Size(90, 39);
//            button4.TabIndex = 17;
//            button4.Text = "Thanh toán";
//            button4.UseVisualStyleBackColor = true;
//            // 
//            // listView2
//            // 
//            listView2.Location = new Point(507, 93);
//            listView2.Margin = new Padding(3, 2, 3, 2);
//            listView2.Name = "listView2";
//            listView2.Size = new Size(342, 269);
//            listView2.TabIndex = 18;
//            listView2.UseCompatibleStateImageBehavior = false;
//            // 
//            // ftablemanager
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(862, 470);
//            Controls.Add(listView2);
//            Controls.Add(button4);
//            Controls.Add(textBox1);
//            Controls.Add(comboBox3);
//            Controls.Add(label1);
//            Controls.Add(comboBox2);
//            Controls.Add(numericUpDown2);
//            Controls.Add(button3);
//            Controls.Add(button2);
//            Controls.Add(numericUpDown1);
//            Controls.Add(listView1);
//            Controls.Add(button1);
//            Controls.Add(comboBox1);
//            Controls.Add(menuStrip2);
//            Margin = new Padding(3, 2, 3, 2);
//            Name = "ftablemanager";
//            Text = "ftablemanager";
//            Load += ftablemanager_Load;
//            menuStrip2.ResumeLayout(false);
//            menuStrip2.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
//            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private ComboBox comboBox1;
//        private ContextMenuStrip contextMenuStrip1;
//        private MenuStrip menuStrip2;
//        private ToolStripMenuItem adminToolStripMenuItem;
//        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
//        private ToolTip toolTip1;
//        private Button button1;
//        private ListView listView1;
//        private NumericUpDown numericUpDown1;
//        private Button button2;
//        private Button button3;
//        private NumericUpDown numericUpDown2;
//        private ComboBox comboBox2;
//        private Label label1;
//        private ComboBox comboBox3;
//        private TextBox textBox1;
//        private Button button4;
//        private ListView listView2;
//    }
//}