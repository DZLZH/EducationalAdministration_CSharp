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
    public partial class AddStudentForm : Form
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
            else if (txtNo.Text.Trim() == "")
            {
                MessageBox.Show("请输入学号！", "提示");
                txtNo.Focus();
                return false;
            }
            else if (txtEmail.Text.Trim().Length > 0 && txtEmail.Text.Trim().IndexOf("@") == -1)
            {
                MessageBox.Show("请输入正确的电子邮件格式！", "提示");
                txtEmail.Focus();
                return false;
            }
            else if (cmbGrade.Text.Trim() == "")
            {
                MessageBox.Show("请选择年级！", "提示");
                cmbGrade.Focus();
                return false;
            }
            else if (cmbClass.Text.Trim() == "")
            {
                MessageBox.Show("请选择班级！", "提示");
                cmbClass.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void GetClassName(int id)
        {
            string sql = string.Format("select ClassName from Class where GradeId={0}", id);
            try
            {
                SqlCommand com = new SqlCommand(sql, DBHelper.con);
                DBHelper.con.Open();
                SqlDataReader className = com.ExecuteReader();
                while (className.Read())
                {
                    cmbClass.Items.Add(className["ClassName"]);
                }
                className.Close();
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

        private int GetClassId()
        {
            int CId = 0;
            string Cname = cmbClass.Text;
            string sql = string.Format("select ClassId from Class where ClassName='{0}'", Cname);
            try
            {
                SqlCommand com = new SqlCommand(sql, DBHelper.con);
                DBHelper.con.Open();
                SqlDataReader Cid = com.ExecuteReader();
                if (Cid.Read())
                {
                    CId = (int)Cid["ClassId"];
                }
                Cid.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.con.Close();
            }
            return CId;
        }

        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            rdohd.Checked = true;
            rdoM.Checked = true;
            cmbGrade.Items.Clear();
            string strsql = "select GradeName from Grade";
            try
            {
                SqlCommand com = new SqlCommand(strsql, DBHelper.con);
                DBHelper.con.Open();
                SqlDataReader grade = com.ExecuteReader();
                while (grade.Read())
                {
                    cmbGrade.Items.Add((string)grade["GradeName"]);
                }
                grade.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClass.Items.Clear();
            int id = 0;
            string strsql = string.Format("select GradeId from Grade where GradeName='{0}'", cmbGrade.Text.Trim());
            try
            {
                SqlCommand com = new SqlCommand(strsql, DBHelper.con);
                DBHelper.con.Open();
                SqlDataReader gradeId = com.ExecuteReader();
                if(gradeId.Read())
                {
                    id = (int)gradeId["GradeId"];
                }
                gradeId.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.con.Close();
            }
            GetClassName(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Input())
            {
                string Id = txtId.Text.Trim();
                string Pwd = txtPwd.Text.Trim();
                int State = rdohd.Checked ? 1 : 0;
                string Name = txtName.Text.Trim();
                string No = txtNo.Text.Trim();
                string Phone = txtPhone.Text.Trim();
                string Email = txtEmail.Text.Trim();
                int Sex = rdoM.Checked ? 1 : 0;
                int ClassId = GetClassId();
                string sql = string.Format("insert into Student(LoginId,LoginPwd,UserStateId,StudentName,StudentNO,Phone,Email,Sex,ClassId) values('{0}','{1}',{2},'{3}','{4}','{5}','{6}',{7},{8})",Id,Pwd,State,Name,No,Phone,Email,Sex,ClassId);
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
                catch(Exception ex)
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
