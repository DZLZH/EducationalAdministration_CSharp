using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jwglxt
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            tssldisplay.Text = tssldisplay.Text + "-" + UserHelper.loginId;
        }

        private void 增加学生ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.MdiParent = this;
            addStudentForm.Show();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.MdiParent = this;
            selectForm.Show();
        }

        private void 查询及修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.MdiParent = this;
            selectForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SelectSexForm selectSexForm = new SelectSexForm();
            selectSexForm.MdiParent = this;
            selectSexForm.Show();
        }


        private void 增加学生用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.MdiParent = this;
            addStudentForm.Show();
        }

        private void 学生信息列表ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectSexForm selectSexForm = new SelectSexForm();
            selectSexForm.MdiParent = this;
            selectSexForm.Show();
        }

        private void 增加教员用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacherForm addteacherForm = new AddTeacherForm();
            addteacherForm.MdiParent = this;
            addteacherForm.Show();
        }

        private void 增加教员用户ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddTeacherForm addteacherForm = new AddTeacherForm();
            addteacherForm.MdiParent = this;
            addteacherForm.Show();
        }

        private void 教员信息列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TSelectSexForm tSelectSexForm = new TSelectSexForm();
            tSelectSexForm.MdiParent = this;
            tSelectSexForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            TSelectSexForm tSelectSexForm = new TSelectSexForm();
            tSelectSexForm.MdiParent = this;
            tSelectSexForm.Show();
        }

        
    }
}
