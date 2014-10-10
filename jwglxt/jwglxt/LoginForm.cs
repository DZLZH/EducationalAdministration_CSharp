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
    public partial class LoginForm : Form
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
            else if (cmblx.Text.Trim()=="")
            {
                MessageBox.Show("请选择用户类型！", "提示");
                cmblx.Focus();
                return false;
            }
            else
            {
                return true;
            }
           
        }

        public bool User(string id, string pwd, string lx, ref string message)
        {
            int count = 0;
            bool isuser = false;
            string dbo="";
            switch (lx)
            {
                case "管理员":
                    dbo = "Admin";
                    break;
                case "教员":
                    dbo = "Teacher";
                    break;
                case "学生":
                    dbo = "Student";
                    break;
                default:
                    MessageBox.Show("请选择正确的用户类型！");
                    break;
            }
            if (dbo.Length > 0)
            {
                string strsql = string.Format("Select count(*) from {0} where LoginId='{1}' and LoginPwd='{2}'", dbo, id, pwd);
                try
                {
                    SqlCommand com = new SqlCommand(strsql, DBHelper.con);
                    DBHelper.con.Open();
                    count = (int)com.ExecuteScalar();
                    if (count == 1)
                    {
                        isuser = true;
                    }
                    else
                    {
                        message = "用户名不存在或密码不正确！";
                        isuser = false;
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
            return isuser;
        }

        public void ShowForm()
        {
            switch (cmblx.Text.Trim())
            {
                case "管理员":
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Visible = false;
                    break;
                case"教员":
                    MessageBox.Show("抱歉，您请求的功能尚没有完成！");
                    
                    break;
                case"学生":
                    MessageBox.Show("抱歉，您请求的功能尚没有完成！");
                    break;
                default:
                    MessageBox.Show("抱歉，您请求的功能尚没有完成！");
                    break;
            }
            
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isUser = false;
            string messae = "";
            if(Input())
            {
                isUser = User(txtId.Text.Trim(), txtPwd.Text.Trim(), cmblx.Text.Trim(),ref messae);
                if (isUser)
                {
                    UserHelper.loginId = txtId.Text.Trim(); 
                    UserHelper.loginType = cmblx.Text.Trim();
                    ShowForm();
                    
                }
                else
                {
                    if (messae.Length>0)
                    {
                        MessageBox.Show(messae, "提示");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
      
    }
}
