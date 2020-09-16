using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stu_sys
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// add student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sm_sub_addStudent_Click(object sender, EventArgs e)
        {
            Frm_add_student frm_Add_Student = new Frm_add_student();
            frm_Add_Student.MdiParent = this;
            frm_Add_Student.Show();
        }

        /// <summary>
        /// student list, single instance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sm_sub_studentList_Click(object sender, EventArgs e)
        {
            #region single instance
            //Frm_student_list frm_Student_List = Frm_student_list.CreateInstance();
            //frm_Student_List.MdiParent = this;
            //frm_Student_List.Show();
            #endregion

            #region method2

            if (!CheckForm(typeof(Frm_student_list).Name))
            {
                Frm_student_list frm_Student_List = new Frm_student_list();
                frm_Student_List.MdiParent = this;
                frm_Student_List.Show();
            }
            #endregion

        }

        /// <summary>
        /// check whether a form opened
        /// </summary>
        /// <param name="form_name"></param>
        /// <returns></returns>
        private static bool CheckForm(string form_name)
        {
            bool flag = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == form_name)
                {
                    flag = true;

                    //get focus
                    form.Activate();
                    
                    break;
                } 
            }

            return flag;
        }

        /// <summary>
        /// add class function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sm_sub_addClass_Click(object sender, EventArgs e)
        {
            Frm_add_class frm_Add_Class = new Frm_add_class();
            frm_Add_Class.MdiParent = this;
            frm_Add_Class.Show();
        }

        /// <summary>
        /// class list form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sm_sub_classList_Click(object sender, EventArgs e)
        {
            if (!CheckForm(typeof(Frm_class_list).Name))
            {
                Frm_class_list frm_Class_List = new Frm_class_list();
                frm_Class_List.MdiParent = this;
                frm_Class_List.Show();
            }
            return;
        }

        /// <summary>
        /// add grade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sm_sub_addGrade_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// grade list form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sm_sub_gradeList_Click(object sender, EventArgs e)
        {
            if (!CheckForm(typeof(Frm_grade_list).Name))
            {
                Frm_grade_list frm_Grade_List = new Frm_grade_list();
                frm_Grade_List.MdiParent = this;
                frm_Grade_List.Show();
            }

            return;
        }

        /// <summary>
        /// click chose to exit app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// exit function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sm_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
