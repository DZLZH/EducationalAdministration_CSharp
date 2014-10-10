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
   
    public partial class SelectForm : Form
    {
        private bool UpdateZT(string id, int State)
        {
            bool isUpdate = false;
            string sql = string.Format("update Student set UserStateId={0} where StudentId={1}",State ,id );
            try
            {
                SqlCommand com = new SqlCommand(sql, DBHelper.con);
                DBHelper.con.Open();
                int count = com.ExecuteNonQuery();
                if (count > 0)
                {
                    isUpdate = true;
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
            return isUpdate;
        }

        private  bool SelectName()
        {
            String select = txtSelect.Text.Trim();
            bool isSelect = false;
            lvDisplay.Items.Clear();
            if (!(select == ""))
            {
                string sql = string.Format("select * from Student where LoginId like '%{0}%'", select);
                SqlDataReader allStudent=null;
                try
                {
                    SqlCommand com = new SqlCommand(sql, DBHelper.con);
                    DBHelper.con.Open();
                    allStudent = com.ExecuteReader();
                    if (allStudent.HasRows)
                    {
                        while (allStudent.Read())
                        {
                            string Id = (string)allStudent["LoginId"];
                            string Name = (string)allStudent["StudentName"];
                            string No = (string)allStudent["StudentNO"];
                            string State = ((bool)allStudent["UserStateId"]) ? "活动" : "非活动";
                            ListViewItem item = new ListViewItem(Id);
                            item.SubItems.AddRange(new string[] { Name, No, State });
                            item.Tag = (int)allStudent["StudentId"];
                            lvDisplay.Items.Add(item);
                        }
                        isSelect = true;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    allStudent.Close();
                    DBHelper.con.Close();
                }
            }
            return isSelect;
        }

        public SelectForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSelect.Text.Trim() == "")
            {
                MessageBox.Show("请输入要查询的用户名！", "提示");
            }
            else
            {
                if (!SelectName())
                {
                    MessageBox.Show("没有查询到您要查询的用户信息！", "提示");
                }
            }
        }

        private void lvDisplay_DoubleClick(object sender, EventArgs e)
        {
            if (lvDisplay.SelectedItems.Count > 0)
            {
                UserHelper.Index = (int)lvDisplay.SelectedItems[0].Tag;
                UpdateForm updateForm = new UpdateForm();
                updateForm.MdiParent = this.MdiParent;
                updateForm.Show();
            }
        }

        private void SelectForm_Activated(object sender, EventArgs e)
        {
            SelectName();

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvDisplay.SelectedItems[0].Index>-1 )
            {
                string sql =string.Format("delete from Student where StudentId={0}",lvDisplay.SelectedItems[0].Tag);
                if((int)MessageBox.Show("您确定要删除该条信息吗？","提示",MessageBoxButtons.YesNo)==6)
                try
                {
                    SqlCommand com = new SqlCommand(sql , DBHelper.con);
                    DBHelper.con.Open();
                    int count = com.ExecuteNonQuery();
                    if(count >0)
                    {
                        MessageBox.Show("删除成功！","提示");
                    }
                    else
                    {
                        MessageBox.Show("删除失败！","提示");
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
                SelectName();
            }
            else
            {
                MessageBox.Show("没有选定的项,请选定要删除的项！","提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 活动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvDisplay.SelectedItems[0].Index > -1)
            {
                if (UpdateZT(lvDisplay.SelectedItems[0].Tag.ToString(), 1))
                {
                    MessageBox.Show("修改成功！", "提示");
                    SelectName();
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示");
                }
            }
            else
            {
                MessageBox.Show("没有选定的项,请选定要修改的项！", "提示");

            }
        }

        private void 非活动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvDisplay.SelectedItems[0].Index > -1)
            {
                if (UpdateZT(lvDisplay.SelectedItems[0].Tag.ToString(), 0))
                {
                    MessageBox.Show("修改成功！", "提示");
                    SelectName();
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示");
                }
            }
            else
            {
                MessageBox.Show("没有选定的项,请选定要修改的项！", "提示");

            }
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {

        }


    }
}
