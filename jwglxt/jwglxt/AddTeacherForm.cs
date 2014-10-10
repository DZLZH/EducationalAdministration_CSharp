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
    public partial class AddTeacherForm : Form
    {
        private bool Input()
        {
            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名！", "提示");
                txtId.Focus();
                return false;
            }
            else if (txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！", "提示");
                txtPwd.Focus();
                return false;
            }
            else if (txtqrPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入确认密码！", "提示");
                txtqrPwd.Focus();
                return false;
            }
            else if (!txtPwd.Text.Trim().Equals(txtqrPwd.Text.Trim()))
            {
                MessageBox.Show("两次密码不一致，请重新输入！", "提示");
                txtPwd.Text = "";
                txtqrPwd.Text = "";
                txtPwd.Focus();
                return false;
            }
            else if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("请输入姓名！", "提示");
                txtName.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }


        public AddTeacherForm()
        {
            InitializeComponent();
        }


        private void AddTeacherForm_Load(object sender, EventArgs e)
        {
            rdohd.Checked = true;
            rdoM.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Input())
            {
                string Id = txtId.Text.Trim();
                string Pwd = txtPwd.Text.Trim();
                int State = rdohd.Checked ? 1 : 0;
                string Name = txtName.Text.Trim();
                int Sex = rdoM.Checked ? 1 : 0;
                string sql = string.Format("insert into Teacher (LoginId,LoginPwd,UserStateId,TeacherName,Sex) values('{0}','{1}',{2},'{3}',{4})", Id, Pwd, State, Name,Sex);
                try
                {
                    SqlCommand com = new SqlCommand(sql, DBHelper.con);
                    DBHelper.con.Open();
                    int count = com.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("添加成功！", "提示");
                    }
                    else
                    {
                        MessageBox.Show("添加失败！", "提示");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DBHelper.con.Close();
                }
            }
        }
    }
}
