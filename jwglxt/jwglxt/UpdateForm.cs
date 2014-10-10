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
    public partial class UpdateForm : Form
    {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.con.Close();
            }
            return CId;
        }

        private int GetGradeId(int id)
        {
            int gradeid=-1;
            string sql = string.Format(" Select GradeId from Class where ClassId ={0}", id);
            try
            {
                SqlCommand com = new SqlCommand(sql, DBHelper.con);
                DBHelper.con.Open();
                SqlDataReader grade = com.ExecuteReader();
                if (grade.Read())
                {
                    gradeid = (int)grade["GradeId"];
                }
                grade.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.con.Close();
            }
            return gradeid;
        }

        private void GetClassName(int id, int classid)
        {
            string sql = string.Format("select ClassName,ClassId from Class where GradeId={0}", id);
            try
            {
                SqlCommand com = new SqlCommand(sql, DBHelper.con);
                DBHelper.con.Open();
                SqlDataReader className = com.ExecuteReader();
                while (className.Read())
                {
                    cmbClass.Items.Add(className["ClassName"]);
                    if (classid == (int)className["ClassId"])
                    {
                        cmbClass.Text = (string)className["ClassName"];
                    }
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

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            int classid=-1;
            string sql = string.Format("select * from Student where StudentId={0}",UserHelper.Index);
            try
            {
                SqlCommand com = new SqlCommand(sql, DBHelper.con);
                DBHelper.con.Open();
                SqlDataReader student = com.ExecuteReader();
                if (student.Read())
                {
                    txtId.Text = (string)student["LoginId"];
                    txtPwd.Text = (string)student["LoginPwd"];
                    if ((bool)student["UserStateId"])
                    {
                        rdoT.Checked = true;
                    }
                    else
                    {
                        rdoF.Checked = true;
                    }
                    txtName.Text = (string)student["StudentName"];
                    txtNo.Text = (string)student["StudentNO"];
                    if ((bool)student["sex"])
                    {
                        rdoM.Checked = true;
                    }
                    else
                    {
                        rdoW.Checked = true;
                    }
                    classid = (int)student["ClassId"];
                }
                student.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.con.Close();
            }
           int gradeid= GetGradeId(classid);
           GetClassName(gradeid,classid);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            int state = rdoT.Checked == true ? 1 : 0;
            string name = txtName.Text.Trim();
            string no = txtNo.Text.Trim();
            int sex = rdoM.Checked == true ? 1 : 0;
            int classid = GetClassId();
            string sql = string.Format("update Student set LoginId='{0}',LoginPwd='{1}',UserStateId={2},StudentName='{3}',StudentNO='{4}',Sex={5},ClassId={6} where StudentId = {7}",id, pwd, state, name, no, sex, classid, UserHelper.Index);
            try
            {
                SqlCommand com = new SqlCommand(sql, DBHelper.con);
                DBHelper.con.Open();
                int count = com.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("修改成功！", "提示");
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示");
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
