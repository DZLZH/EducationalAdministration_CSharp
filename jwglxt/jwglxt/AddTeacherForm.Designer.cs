namespace jwglxt
{
    partial class AddTeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeacherForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rdoW = new System.Windows.Forms.RadioButton();
            this.rdoM = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtqrPwd = new System.Windows.Forms.TextBox();
            this.rdofhd = new System.Windows.Forms.RadioButton();
            this.rdohd = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdoW
            // 
            this.rdoW.AutoSize = true;
            this.rdoW.Location = new System.Drawing.Point(281, 307);
            this.rdoW.Name = "rdoW";
            this.rdoW.Size = new System.Drawing.Size(35, 16);
            this.rdoW.TabIndex = 17;
            this.rdoW.Text = "女";
            this.rdoW.UseVisualStyleBackColor = true;
            // 
            // rdoM
            // 
            this.rdoM.AutoSize = true;
            this.rdoM.Location = new System.Drawing.Point(169, 307);
            this.rdoM.Name = "rdoM";
            this.rdoM.Size = new System.Drawing.Size(35, 16);
            this.rdoM.TabIndex = 16;
            this.rdoM.Text = "男";
            this.rdoM.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 250);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 21);
            this.txtName.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "姓名";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(162, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(154, 21);
            this.txtId.TabIndex = 26;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(162, 76);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(154, 21);
            this.txtPwd.TabIndex = 25;
            // 
            // txtqrPwd
            // 
            this.txtqrPwd.Location = new System.Drawing.Point(162, 134);
            this.txtqrPwd.Name = "txtqrPwd";
            this.txtqrPwd.PasswordChar = '*';
            this.txtqrPwd.Size = new System.Drawing.Size(154, 21);
            this.txtqrPwd.TabIndex = 24;
            // 
            // rdofhd
            // 
            this.rdofhd.AutoSize = true;
            this.rdofhd.Location = new System.Drawing.Point(202, 27);
            this.rdofhd.Name = "rdofhd";
            this.rdofhd.Size = new System.Drawing.Size(59, 16);
            this.rdofhd.TabIndex = 23;
            this.rdofhd.Text = "非活动";
            this.rdofhd.UseVisualStyleBackColor = true;
            // 
            // rdohd
            // 
            this.rdohd.AutoSize = true;
            this.rdohd.Location = new System.Drawing.Point(107, 27);
            this.rdohd.Name = "rdohd";
            this.rdohd.Size = new System.Drawing.Size(47, 16);
            this.rdohd.TabIndex = 22;
            this.rdohd.Text = "活动";
            this.rdohd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "状态";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "确认密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "用户名";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rdohd);
            this.panel1.Controls.Add(this.rdofhd);
            this.panel1.Location = new System.Drawing.Point(55, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 62);
            this.panel1.TabIndex = 28;
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtqrPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoW);
            this.Controls.Add(this.rdoM);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTeacherForm";
            this.Text = "创建教员用户";
            this.Load += new System.EventHandler(this.AddTeacherForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdoW;
        private System.Windows.Forms.RadioButton rdoM;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtqrPwd;
        private System.Windows.Forms.RadioButton rdofhd;
        private System.Windows.Forms.RadioButton rdohd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}