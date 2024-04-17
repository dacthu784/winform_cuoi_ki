//using Quanlyquanan.Model;
//using System.Text;
//using System.Security.Cryptography;
//using BCrypt.Net;
//namespace Quanlyquanan
//{
//    public partial class fLogin : Form
//    {
//        private readonly QlquanCafeContext dbcontext;
//        public fLogin()
//        {
//            dbcontext = new QlquanCafeContext();
//            InitializeComponent();
//        }
//        string username = "";
//        string password = "";
//        private void btnLogin_Click(object sender, EventArgs e)
//        {
//            username = txbUsername.Text;
//            password = txbPassword.Text;
//            if (Login(username, password))
//            {
//                var a = (from account in dbcontext.Accounts where account.Username == username select account).SingleOrDefault();
//                ftablemanager f = new ftablemanager();
//                f.UserLogin = a;
//                this.Hide();
//                f.ShowDialog();
//                this.Show();
//            }
//            else
//            {
//                lbPassword.Text = "sai tài khoản hoặc mật khẩu";
//                lbPassword.ForeColor = Color.Red;
//            }
//        }

//        public bool Login(string username ,string password)
//        {
//            //byte[] bytes = ASCIIEncoding.ASCII.GetBytes(password);
//            //byte[] Hash = MD5.HashData(bytes);
//            //string slat = BCrypt.Net.BCrypt.GenerateSalt();
//            //string hash = BCrypt.Net.BCrypt.HashPassword(password, slat);
//            //MessageBox.Show(hash);
//            //return false;

//            var a = (from account in dbcontext.Accounts where account.Username == username select account).SingleOrDefault();
//            if (a != null)
//            {
//                var hashpassword = a.Passwords;
//                return BCrypt.Net.BCrypt.Verify(password, hashpassword);
//            }
//            return false;
//        }
//    }
//}