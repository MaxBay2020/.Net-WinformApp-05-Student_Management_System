namespace stu_sys
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sm_studentManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_sub_addStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_sub_studentList = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_classManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_sub_addClass = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_sub_classList = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_gradeManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_sub_gradeList = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sm_studentManagement,
            this.sm_classManagement,
            this.sm_gradeManagement,
            this.sm_exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1114, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sm_studentManagement
            // 
            this.sm_studentManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sm_sub_addStudent,
            this.sm_sub_studentList});
            this.sm_studentManagement.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sm_studentManagement.Name = "sm_studentManagement";
            this.sm_studentManagement.Size = new System.Drawing.Size(145, 21);
            this.sm_studentManagement.Text = "Student Management";
            // 
            // sm_sub_addStudent
            // 
            this.sm_sub_addStudent.Name = "sm_sub_addStudent";
            this.sm_sub_addStudent.Size = new System.Drawing.Size(147, 22);
            this.sm_sub_addStudent.Text = "Add student";
            this.sm_sub_addStudent.Click += new System.EventHandler(this.sm_sub_addStudent_Click);
            // 
            // sm_sub_studentList
            // 
            this.sm_sub_studentList.Name = "sm_sub_studentList";
            this.sm_sub_studentList.Size = new System.Drawing.Size(147, 22);
            this.sm_sub_studentList.Text = "Student list";
            this.sm_sub_studentList.Click += new System.EventHandler(this.sm_sub_studentList_Click);
            // 
            // sm_classManagement
            // 
            this.sm_classManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sm_sub_addClass,
            this.sm_sub_classList});
            this.sm_classManagement.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sm_classManagement.Name = "sm_classManagement";
            this.sm_classManagement.Size = new System.Drawing.Size(131, 21);
            this.sm_classManagement.Text = "Class Management";
            // 
            // sm_sub_addClass
            // 
            this.sm_sub_addClass.Name = "sm_sub_addClass";
            this.sm_sub_addClass.Size = new System.Drawing.Size(132, 22);
            this.sm_sub_addClass.Text = "Add class";
            this.sm_sub_addClass.Click += new System.EventHandler(this.sm_sub_addClass_Click);
            // 
            // sm_sub_classList
            // 
            this.sm_sub_classList.Name = "sm_sub_classList";
            this.sm_sub_classList.Size = new System.Drawing.Size(132, 22);
            this.sm_sub_classList.Text = "Class list";
            this.sm_sub_classList.Click += new System.EventHandler(this.sm_sub_classList_Click);
            // 
            // sm_gradeManagement
            // 
            this.sm_gradeManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sm_sub_gradeList});
            this.sm_gradeManagement.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sm_gradeManagement.Name = "sm_gradeManagement";
            this.sm_gradeManagement.Size = new System.Drawing.Size(137, 21);
            this.sm_gradeManagement.Text = "Grade Management";
            // 
            // sm_sub_gradeList
            // 
            this.sm_sub_gradeList.Name = "sm_sub_gradeList";
            this.sm_sub_gradeList.Size = new System.Drawing.Size(132, 22);
            this.sm_sub_gradeList.Text = "Grade list";
            this.sm_sub_gradeList.Click += new System.EventHandler(this.sm_sub_gradeList_Click);
            // 
            // sm_exit
            // 
            this.sm_exit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sm_exit.Name = "sm_exit";
            this.sm_exit.Size = new System.Drawing.Size(40, 21);
            this.sm_exit.Text = "Exit";
            this.sm_exit.Click += new System.EventHandler(this.sm_exit_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 513);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sm_studentManagement;
        private System.Windows.Forms.ToolStripMenuItem sm_sub_addStudent;
        private System.Windows.Forms.ToolStripMenuItem sm_sub_studentList;
        private System.Windows.Forms.ToolStripMenuItem sm_classManagement;
        private System.Windows.Forms.ToolStripMenuItem sm_gradeManagement;
        private System.Windows.Forms.ToolStripMenuItem sm_sub_addClass;
        private System.Windows.Forms.ToolStripMenuItem sm_sub_classList;
        private System.Windows.Forms.ToolStripMenuItem sm_sub_gradeList;
        private System.Windows.Forms.ToolStripMenuItem sm_exit;
    }
}