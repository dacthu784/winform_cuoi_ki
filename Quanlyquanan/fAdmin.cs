
//using Microsoft.EntityFrameworkCore;
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
//using System.Xml;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//namespace Quanlyquanan
//{
//    public partial class fAdmin : Form
//    {
//        public Account userlogin;
//        QlquanCafeContext dbcontext;
//        BindingSource ListAccount = new BindingSource();
//        BindingSource listTable = new BindingSource();
//        public fAdmin()
//        {
//            dbcontext = new QlquanCafeContext();

//            InitializeComponent();
//            Load();

//        }
//        private void Load()
//        {
//            LoadAccount();
//            dtgvAccount.DataSource = ListAccount;
//            dtgvTable.DataSource = listTable;
//            LoadListFood();
//            LoadCbCategory();
//            Databinding();
//            LoadCbRole();
//            LoadTable();
//            databindingTable();
//        }


//        private void LoadCbCategory()
//        {
//            var cate = (from a in dbcontext.Categorys select a).ToList();
//            cmbCategory.DataSource = cate;
//            cmbCategory.DisplayMember = "NameCategory";
//            cmbCategory.ValueMember = "idCategory";

//        }
//        private void LoadListFood()
//        {
//            var foods = (from a in dbcontext.Foods
//                         select new
//                         {
//                             a.NameFood,
//                             a.IdCategoryNavigation.NameCategory,
//                             a.Price
//                         }).ToList();
//            dtgvListFood.DataSource = foods;
//        }
//        private void LoadAccount()
//        {
//            var accounts = (from a in dbcontext.Accounts
//                            select new
//                            {
//                                a.Id,
//                                a.Username,
//                                a.Users,
//                                a.IdRoleNavigation.NameRole
//                            }).ToList();
//            ListAccount.DataSource = accounts;
//        }
//        private void LoadCbRole()
//        {
//            var role = (from r in dbcontext.Roles select r).ToList();
//            cbRole.DataSource = role;
//            cbRole.DisplayMember = "NameRole";
//        }

//        private void Databinding()
//        {
//            //Account
//            txbIdAccout.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Id"));
//            txbUsername.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Username"));
//            txbUser.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Users"));

//        }
//        #region Sử lý Sự Kiện
//        private void fAdmin_Load(object sender, EventArgs e)
//        {

//        }

//        private void thứcĂnToolStripMenuItem_Click(object sender, EventArgs e)
//        {

//        }

//        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
//        {

//        }

//        private void tabPage5_Click(object sender, EventArgs e)
//        {

//        }

//        private void btnLoad_Click(object sender, EventArgs e)
//        {
//            LoadAccount();
//        }

//        private void btnXuat_Click(object sender, EventArgs e)
//        {

//            var foods = (from a in dbcontext.Foods
//                         select new
//                         {
//                             a.NameFood,
//                             a.IdCategoryNavigation.NameCategory,
//                             a.Price
//                         }).ToList();

//            dtgvListFood.DataSource = foods;
//        }
//        private void dtgvListFood_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (dtgvListFood.SelectedCells.Count > 0)
//            {
//                string namecategory = dtgvListFood.SelectedCells[0].OwningRow.Cells["NameCategory"].Value.ToString();
//                var cate = (from a in dbcontext.Categorys where a.NameCategory == namecategory select a).SingleOrDefault();


//                int index = -1;
//                int i = 0;
//                if (cate != null)
//                    foreach (Category item in cmbCategory.Items)
//                    {
//                        if (item.IdCategory == cate.IdCategory)
//                        {
//                            index = i;
//                            break;
//                        }
//                        i++;
//                    }
//                cmbCategory.SelectedIndex = index;
//            }
//        }
//        private void label4_Click(object sender, EventArgs e)
//        {

//        }

//        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (dtgvAccount.SelectedCells.Count > 0)
//            {
//                string nameRole = dtgvAccount.SelectedCells[0].OwningRow.Cells["NameRole"].Value.ToString();
//                var role = (from a in dbcontext.Roles where a.NameRole == nameRole select a).SingleOrDefault();

//                int index = -1;
//                int i = 0;
//                if (role != null)
//                    foreach (TypeAccount item in cbRole.Items)
//                    {
//                        if (item.NameRole == role.NameRole)
//                        {
//                            index = i;
//                            break;
//                        }
//                        i++;
//                    }
//                cbRole.SelectedIndex = index;

//            }
//        }
//        // Thêm account
//        private void btnAdd_Click(object sender, EventArgs e)
//        {
//            //int id = int.Parse(txbIdAccout.Text);
//            string username = txbUsername.Text;
//            string user = txbUser.Text;
//            string password = "1";
//            TypeAccount role = (TypeAccount)cbRole.SelectedItem;

//            string slat = BCrypt.Net.BCrypt.GenerateSalt();
//            string hash = BCrypt.Net.BCrypt.HashPassword(password, slat);

//            Account account = new Account();
//            account.Username = username;
//            account.Users = user;
//            account.Passwords = hash;
//            account.IdRoleNavigation = role;

//            dbcontext.Add(account);
//            dbcontext.SaveChanges();
//            LoadAccount();
//        }
//        private void btnSearch_Click(object sender, EventArgs e)
//        {
//            txtIdTable.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Id"));
//            txtNameTable.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Username"));
//        }
//        //Update account
//        private void button2_Click(object sender, EventArgs e)
//        {
//            int id = int.Parse(txbIdAccout.Text);
//            string username = txbUsername.Text;
//            string user = txbUser.Text;
//            TypeAccount role = (TypeAccount)cbRole.SelectedItem;

//            var account = (from a in dbcontext.Accounts where a.Id == id select a).SingleOrDefault();
//            if (account != null)
//            {
//                account.Username = username;
//                account.Users = user;
//                account.IdRoleNavigation = role;
//                dbcontext.SaveChanges();
//            }
//            LoadAccount();
//        }
//        //Xóa account
//        private void button1_Click(object sender, EventArgs e)
//        {
//            int id = int.Parse(txbIdAccout.Text);
//            if (id != userlogin.Id)
//            {
//                Account? account = (from a in dbcontext.Accounts where a.Id == id select a).SingleOrDefault();

//                if (account != null)
//                {
//                    dbcontext.Accounts.Remove(account);
//                    dbcontext.SaveChanges();
//                }
//                LoadAccount();
//            }
//            else
//            {
//                MessageBox.Show("tài khoản đang được sử dụng !!!");
//            }

//        }
//        #endregion





//        private void btXuat_Click(object sender, EventArgs e)
//        {
//           LoadTable();
//        }
//        private void LoadTable()
//        {
//            var table = (from a in dbcontext.Bans
//                         select new
//                         {
//                             a.IdTable,
//                             a.NameTable,
//                         }).ToList();
//            listTable.DataSource = table;
//        }
//        private void databindingTable()
//        {
//            txtIdTable.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "IdTable"));
//            txtNameTable.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "NameTable"));

//        }



//        private void btxoa_Click(object sender, EventArgs e)
//        {
//            int id = int.Parse(txtIdTable.Text);

//            Table? ban = (from a in dbcontext.Bans where a.IdTable == id select a).SingleOrDefault();

//            if (ban != null)
//            {
//                dbcontext.Bans.Remove(ban);
//                dbcontext.SaveChanges();
//            }
//            LoadTable();

//        }

//        private void btsưa_Click(object sender, EventArgs e)
//        {
//            int id = int.Parse(txtIdTable.Text);
//            string username = txtNameTable.Text;

//            var ban = (from a in dbcontext.Bans where a.IdTable == id select a).SingleOrDefault();
//            if (ban != null)
//            {
//                ban.IdTable = id;
//                ban.NameTable = username;
//                dbcontext.SaveChanges();
//            }
//            LoadTable();
//        }

//        private void bttao_Click(object sender, EventArgs e)
//        {
//            string nametable = txtNameTable.Text;
           


//            Table bans = new Table();
//            bans.NameTable = nametable;
            

//            dbcontext.Add(bans);
//            dbcontext.SaveChanges();
//            LoadTable();
//        }
//    }
//}
