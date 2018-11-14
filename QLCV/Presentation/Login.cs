using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCV.Business.PlanData;

namespace QLCV.Presentation
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (cbx_phanloai.SelectedItem == "BOSS")
            {
                
                SqlConnection conn = new SqlConnection("Data Source=MANHHUNGPM;Initial Catalog=DoAn;Integrated Security=True"); //Database: TaiKhoan

                conn.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "select *from boss where BossMa = '" + tk + "' and BossPass = '" + mk + "'"; //Table: TaiKhoanDangNhap
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công, chào quản lí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form main = new Main();
                    this.Hide();
                    main.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công,boss", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (cbx_phanloai.SelectedItem == "STAFF")
            {
                txtMatKhau.Enabled = true;
                txtTaiKhoan.Enabled = true;
                SqlConnection conn = new SqlConnection("Data Source=MANHHUNGPM;Initial Catalog=DoAn;Integrated Security=True"); //Database: TaiKhoan

                conn.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "select *from staff where StaffMa = '" + tk + "' and StaffPass = '" + mk + "'"; //Table: TaiKhoanDangNhap
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công, chào nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form main = new Main();
                    this.Hide();
                    main.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công,nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            cbx_phanloai.Items.Add("BOSS");
            cbx_phanloai.Items.Add("STAFF");
        }
    }
}
