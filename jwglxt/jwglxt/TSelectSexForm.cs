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
    public partial class TSelectSexForm : Form
    {
        DataSet allTeacher = new DataSet();
        SqlDataAdapter adapter;
        private void SelectSex()
        {
            string sql = "select TeacherId,LoginId,TeacherName,Sex from Teacher ";
            if (cboSex.Text.Trim() == "女")
            {
                sql += "where Sex=0";
            }
            else if (cboSex.Text.Trim() == "男")
            {
                sql += "where Sex = 1";
            }
            adapter = new SqlDataAdapter(sql, DBHelper.con);
            adapter.Fill(allTeacher, "Teacher");
            dgvTeacher.DataSource = allTeacher.Tables["Teacher"];
        }

        public TSelectSexForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSelectSex_Load(object sender, EventArgs e)
        {
            cboSex.Items.AddRange(new string[] { "全部", "男", "女" });
            cboSex.Text = "全部";
            SelectSex();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            allTeacher.Tables[0].Clear();
            SelectSex();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(allTeacher, "Teacher");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { }
            allTeacher.Tables[0].Clear();
            SelectSex();
        }
    }
}
