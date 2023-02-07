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
    public partial class Management : Form
    {
        // Public variable
        Thread th;
        public int index; // Get data from gridtable for input
        public string connectStr = "Data Source=DESKTOP-DMLAI4E\\SQLEXPRESS;Initial Catalog=STUDENT_CRUD;Integrated Security=True";

        public Management()
        {
            InitializeComponent();
        }

        //private void tableViewConnect() {
        //    SqlConnection sqlConn = new SqlConnection(@connectStr);
        //    sqlConn.Open();
        //    string sqlQuery = "SELECT * FROM STUDENT";
        //    SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlConn); // Thực thi câu lệnh SQL
        //    SqlDataAdapter sqlDeliver = new SqlDataAdapter(sqlCmd); // Vận chuyển dữ liệu
        //    DataTable table = new DataTable(); // Tạo 1 bảng data ảo trong bộ nhớ
            
        //    sqlDeliver.Fill(table); // Thêm dữ liệu vào bảng data ảo

        //    if (table.Rows.Count != 0)
        //    {
        //        studentView.DataSource = table; // Thêm dữ liệu vào datagrid view
        //    }
        //    else
        //    {
        //        Console.WriteLine("Table is empty");
        //        studentView.DataSource = null;
        //    }
        //}

        private void tableViewConnect()
        {
            studentView.FullRowSelect = true;
            studentView.Items.Clear(); // Xóa dữ liệu cũ
            SqlConnection sqlConn = new SqlConnection(@connectStr);
            sqlConn.Open();
            string sqlQuery = "SELECT * FROM STUDENT";
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlConn); // Thực thi câu lệnh SQL
            SqlDataReader reader = sqlCmd.ExecuteReader();
            int index = 0;
            while(reader.Read())
            {
                studentView.Items.Add(reader[0].ToString());
                studentView.Items[index].SubItems.Add(reader[1].ToString());
                studentView.Items[index].SubItems.Add(reader[2].ToString());
                studentView.Items[index].SubItems.Add(reader[3].ToString());
                index++;
            }
            sqlConn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableViewConnect(); // Load student table from Database
        }

        private void setEmptyValue()
        {
            inputId.Text = string.Empty;
            inputName.Text = string.Empty;
            inputAge.Text = string.Empty;
            inputSex.Text = string.Empty;
        }

        // Set database view to input
        //private void studentView_Click(object sender, EventArgs e)
        //{
        //    index = studentView.CurrentRow.Index;
        //    inputId.Text = studentView.Rows[index].Cells[0].Value.ToString();
        //    inputName.Text = studentView.Rows[index].Cells[1].Value.ToString();
        //    inputAge.Text = studentView.Rows[index].Cells[2].Value.ToString();
        //    inputSex.Text = studentView.Rows[index].Cells[3].Value.ToString();
        //}

        private void studentView_Click_1(object sender, EventArgs e)
        {
            inputId.Text = studentView.SelectedItems[0].SubItems[0].Text;
            inputName.Text = studentView.SelectedItems[0].SubItems[1].Text;
            inputAge.Text = studentView.SelectedItems[0].SubItems[2].Text;
            inputSex.Text = studentView.SelectedItems[0].SubItems[3].Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Insert to database
            try
            {
                SqlConnection sqlConn = new SqlConnection(@connectStr);
                sqlConn.Open();
                string sqlQuery = "INSERT INTO STUDENT(ID, NAME, AGE, SEX) VALUES("+int.Parse(inputId.Text)+", '"+ inputName.Text + "', "+int.Parse(inputAge.Text)+", '"+inputSex.Text+"')";
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlConn);
                sqlCmd.ExecuteNonQuery();
                tableViewConnect();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setEmptyValue();
                SqlConnection sqlConn = new SqlConnection(@connectStr);
                sqlConn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete from database
            try
            {
                SqlConnection sqlConn = new SqlConnection(@connectStr);
                sqlConn.Open();
                string sqlQuery = "DELETE FROM STUDENT WHERE ID = '"+ int.Parse(inputId.Text) + "'";
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlConn);
                sqlCmd.ExecuteNonQuery();
                tableViewConnect();
            }
            catch
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setEmptyValue();
                SqlConnection sqlConn = new SqlConnection(@connectStr);
                sqlConn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Edit from database
            try
            {
                SqlConnection sqlConn = new SqlConnection(@connectStr);
                sqlConn.Open();
                string sqlQuery = "UPDATE STUDENT SET ID = " + int.Parse(inputId.Text) + ", NAME = '" + inputName.Text + "', AGE =  "+int.Parse(inputAge.Text)+ ", SEX = '" + inputSex.Text + "' WHERE ID = '" + int.Parse(inputId.Text) + "'";
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlConn);
                sqlCmd.ExecuteNonQuery();
                tableViewConnect();
            }
            catch
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setEmptyValue();
                SqlConnection sqlConn = new SqlConnection(@connectStr);
                sqlConn.Close();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openAccount);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openAccount(object obj)
        {
            Application.Run(new Account());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
