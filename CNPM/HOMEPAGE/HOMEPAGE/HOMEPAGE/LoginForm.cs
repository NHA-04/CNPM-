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

namespace HOMEPAGE
{
    public partial class LoginForm : Form
    {
        private SqlConnection sqlConnection;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                TB_UserName.Text = Properties.Settings.Default.Username;
                TB_Password.Text = Properties.Settings.Default.Password;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
        }

        private void gradientPanel1_Enter(object sender, EventArgs e)
        {

        }

        private void TB_UserName_Enter(object sender, EventArgs e)
        {
            if (TB_UserName.Text == "Tên đăng nhập")
            {
                TB_UserName.Text = "";
                TB_UserName.ForeColor = Color.Black;
            }
        }

        private void TB_UserName_Leave(object sender, EventArgs e)
        {
            if (TB_UserName.Text == "")
            {
                TB_UserName.Text = "Tên đăng nhập";
                TB_UserName.ForeColor = Color.Black;
            }
        }

        private void TB_Password_Enter(object sender, EventArgs e)
        {
            TB_Password.UseSystemPasswordChar = true;

            if (TB_Password.Text == "Mật khẩu")
            {
                TB_Password.Text = "";
                TB_Password.ForeColor = Color.Black;
            }
        }

        private void TB_Password_Leave(object sender, EventArgs e)
        {
            if (TB_Password.Text == "")
            {
                TB_Password.Text = "Mật khẩu";
                TB_Password.ForeColor = Color.Black;
            }
        }

        private void CB_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_ShowPass.Checked == false)
            {
                TB_Password.UseSystemPasswordChar = true;
            }
            else if (CB_ShowPass.Checked == true)
            {
                TB_Password.UseSystemPasswordChar = false;
            }
        }

        private void BT_Login_Click(object sender, EventArgs e)
        {
            if (TB_UserName.Text == "" || TB_Password.Text == "" || TB_UserName.Text == "Tên đăng nhập" || TB_Password.Text == "Mật khẩu")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu bị thiếu");
                return;
            }
            else
            {
                try
                {
                    sqlConnection ??= Connenction.GetSqlConnection("QuanLyTaiKhoan");

                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();

                    }
                    string user_id = TB_UserName.Text;
                    string query = "Select Users.Pass_word From Users where Users.UserID = @userId";

                    SqlCommand cmd = new(query, sqlConnection);
                    cmd.Parameters.AddWithValue("@userId", user_id);

                    // Lấy mật khẩu đã mã hóa từ database
                    string storedPassword = (string)cmd.ExecuteScalar();

                    if (storedPassword != null && PasswordHasher.VerifyPassword(TB_Password.Text, storedPassword))
                    {
                        MessageBox.Show("Login successful!");

                    }
                    else
                    {
                        MessageBox.Show("Wrong id or password");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
                finally
                {
                    Connenction.CloseConnection(sqlConnection);
                }
            }
            if (rememberMe.Checked == true)
            {
                Properties.Settings.Default.Username = TB_UserName.Text;
                Properties.Settings.Default.Password = TB_Password.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TB_UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
