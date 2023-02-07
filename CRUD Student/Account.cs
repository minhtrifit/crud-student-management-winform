using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace CRUD_Student
{
    public partial class Account : Form
    {
        public string connectStr = "Data Source=DESKTOP-DMLAI4E\\SQLEXPRESS;Initial Catalog=STUDENT_CRUD;Integrated Security=True";
        Thread th;

        public Account()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(inputUsername.Text == "" || inputPassword.Text == "")
            {
                MessageBox.Show("Nhập tài khoản và mật khẩu để đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection sqlConn = new SqlConnection(@connectStr);
                sqlConn.Open();
                string sqlQuery = "SELECT * FROM ACCOUNT";
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlConn); // Thực thi câu lệnh SQL

                SqlDataReader reader = sqlCmd.ExecuteReader();

                bool checkAccount = false;
                while (reader.Read())
                {
                    if (reader.GetString(0) == inputUsername.Text && reader.GetString(1) == inputPassword.Text)
                    {
                        checkAccount = true;
                    }

                }

                if (checkAccount == false)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    th = new Thread(openManagement);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }         
        }

        private void openManagement(object obj)
        {
            Application.Run(new Management());
        }

        private void inputUsername_TextChanged(object sender, EventArgs e)
        {

        }  
    }
}
