//using Quanlyquanan.Model;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Quanlyquanan
//{
//    public partial class ftablemanager : Form
//    {
//        private Account userLogin;

//        public Account UserLogin { get => userLogin; set { userLogin = value; ChechAccout(userLogin.IdRole); } }

//        public ftablemanager()
//        {
//            InitializeComponent();
//        }

//        private void ChechAccout(int? idrole)
//        {
//            thôngTinTàiKhoảnToolStripMenuItem.Text = $"thông tin tài khoản của ({UserLogin.Users})";
//            adminToolStripMenuItem.Enabled = idrole == 1;
//        }
//        private void button1_Click(object sender, EventArgs e)
//        {

//        }

//        private void groupBox1_Enter(object sender, EventArgs e)
//        {

//        }

//        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
//        {

//        }

//        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void button3_Click(object sender, EventArgs e)
//        {

//        }

//        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void ftablemanager_Load(object sender, EventArgs e)
//        {

//        }

//        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
//        {

//            fAdmin f = new fAdmin();
//            f.userlogin = UserLogin;
//            f.ShowDialog();

//        }

//        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            fAccount f = new fAccount();
//            f.ShowDialog();

//        }
//    }
//}
