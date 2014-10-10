using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace jwglxt
{
    public partial class SelectSexForm : Form
    {
        DataSet allStudent = new DataSet();
        SqlDataAdapter adapter;

        private void SelectSex()
        {
            string sql = "select StudentId,LoginId,StudentName,StudentNO,Sex,Phone,Email from Student ";
            if (cboSex.Text.Trim() == "女")
            {
                sql += "where Sex=0";
            }
            else if (cboSex.Text.Trim() == "男")
            {
                sql += "where Sex = 1";
            }
            adapter = new SqlDataAdapter(sql, DBHelper.con);
            adapter.Fill(allStudent, "Student");
            dgvStudent.DataSource = allStudent.Tables["Student"];
        }

        public SelectSexForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectSexForm_Load(object sender, EventArgs e)
        {
            cboSex.Items.AddRange(new string[] { "全部", "男", "女" });
            cboSex.Text = "全部";
            SelectSex();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            allStudent.Tables[0].Clear();
            SelectSex();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(allStudent, "Student");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { }
            allStudent.Tables[0].Clear();
            SelectSex();
        }
    }
}
