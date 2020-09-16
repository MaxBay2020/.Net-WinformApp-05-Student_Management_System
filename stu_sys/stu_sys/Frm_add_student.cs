using MySql.Data.MySqlClient;
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
    public partial class Frm_add_student : Form
    {
        public Frm_add_student()
        {
            InitializeComponent();
        }

        private void Frm_add_student_Load(object sender, EventArgs e)
        {
            //add data to class list combo
            InitClassList();

            //add data to grade list combo
            InitGradeList();
        }

        /// <summary>
        /// load grade list into grade list combo
        /// </summary>
        private void InitGradeList()
        {
            //1.define sql
            string sql = "SELECT gId, gName FROM tab_grade ORDER BY gId";

            //2.execute sql
            DataTable dt_grade_list = DatabaseConnection.GetDataTable(sql);

            //3.insert a row "please select"
            DataRow dr = dt_grade_list.NewRow();
            dr["gId"] = 0;
            dr["gName"] = "--Please Select--";
            dt_grade_list.Rows.InsertAt(dr, 0);

            //4.load data to class list combo
            cbo_grade_list.DataSource = dt_grade_list;
            cbo_grade_list.DisplayMember = "gName";
            cbo_grade_list.ValueMember = "gId";

            //5.set initial value
            cbo_grade_list.SelectedIndex = 0;

            cbo_grade_list.Tag = "1";
            //cbo_class_list.Tag = "1";
        }

        /// <summary>
        /// load class list into class list combo
        /// </summary>
        private void InitClassList()
        {
            //1.define sql
            string sql = "SELECT cId, cName FROM tab_class ORDER BY cId";

            //2.execute sql
            DataTable dt_class_list = DatabaseConnection.GetDataTable(sql);

            //3.insert a row "please select"
            DataRow dr = dt_class_list.NewRow();
            dr["cId"] = 0;
            dr["cName"] = "--Please Select--";
            dt_class_list.Rows.InsertAt(dr, 0);

            //4.load data to class list combo
            cbo_class_list.DataSource = dt_class_list;
            cbo_class_list.DisplayMember = "cName";
            cbo_class_list.ValueMember = "cId";

            //5.set initial value
            cbo_class_list.SelectedIndex = 0;
            cbo_class_list.Tag = "1";
        }

        /// <summary>
        /// reset conditions
        /// </summary>
        /// <param name="sender"></param>
        /// <param 
        private void btn_reset_Click(object sender, EventArgs e)
        {
            cbo_class_list.Tag = null;
            cbo_grade_list.Tag = null;
            txt_name.Clear();
            txt_name.Focus();
            InitClassList();
            InitGradeList();
        }

        /// <summary>
        /// when value changed, reload class list combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_grade_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_grade_list.Tag != null)
            {
                //1.get gId
                object gId = cbo_grade_list.SelectedValue;

                //2.define sql
                string sql = "SELECT cId, cName FROM tab_class WHERE gId=@gId";

                //3.execute sql
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("@gId", gId)
                };

                DataTable dt_class_list = DatabaseConnection.GetDataTable(sql, parameters);


                //6.load data to class list combo
                cbo_class_list.DataSource = dt_class_list;
                cbo_class_list.DisplayMember = "cName";
                cbo_class_list.ValueMember = "cId";

                //MessageBox.Show(cbo_class_list.Text);

            }

        }

        /// <summary>
        /// when class list combo changed, reload grade list combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_class_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_class_list.Tag != null)
            {
                //1.get gId
                string cName = cbo_class_list.Text;

                //2.define sql
                string sql = "SELECT g.gId, g.gName " +
                                "FROM tab_class c " +
                                "JOIN tab_grade g " +
                                "ON c.gId=g.gId " +
                                "WHERE c.cName=@cName";

                //3.execute sql
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("@cName", cName)
                };

                DataTable dt_grade_list = DatabaseConnection.GetDataTable(sql, parameters);


                //6.load data to class list combo
                cbo_grade_list.DataSource = dt_grade_list;
                cbo_grade_list.DisplayMember = "gName";
                cbo_grade_list.ValueMember = "gId";

                //MessageBox.Show(cbo_class_list.Text);

                cbo_grade_list.Tag = null;
            }

        }

        /// <summary>
        /// insert one record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
            //1.get info
            //1.1 student name
            string sName = txt_name.Text.Trim();

            //1.2 student gender
            string sGender = r_male.Text.Trim();
            if (r_female.Checked)
            {
                sGender = r_female.Text.Trim();
            }

            //1.3 student class
            int cId = (int)cbo_class_list.SelectedValue;

            //1.4 student phone
            string sPhone = txt_phone.Text.Trim();

            //2. whether info is empty
            if(string.IsNullOrEmpty(sName) || cId==0 || string.IsNullOrEmpty(sPhone))
            {
                //has empty blank
                MessageBox.Show("Please fill all blanks", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //otherwise, check whether this record already exist
            //2.1 define sql
            string sql = "SELECT COUNT(1) FROM tab_student " +
                        "WHERE sName=@sName AND sPhone=@sPhone";

            //2.2 assign parameters
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@sName", sName),
                new MySqlParameter("@sPhone", sPhone)
            };

            //2.3 execute sql
            object o = DatabaseConnection.ExecuteScalar(sql, parameters);

            if (o ==null || o==DBNull.Value || o.ToString()=="0")
            {
                //the record not exist;
                //3. add student
                //3.1 define sql 
                string sql_add = "INSERT INTO tab_student " +
                            "(sId, sName, sGender, cId, sPhone, createTime) " +
                            "VALUES (NULL, @sName, @sGender, @cId, @sPhone, NOW())";

                //3.2 assign parameters
                MySqlParameter[] parameters_add =
                {
                    new MySqlParameter("@sName", sName),
                    new MySqlParameter("@sGender", sGender),
                    new MySqlParameter("@cId", cId),
                    new MySqlParameter("@sPhone", sPhone)
                };

                //3.3 execute sql
                int count = DatabaseConnection.ExecuteNonQuery(sql_add, parameters_add);

                if (count > 0)
                {
                    //add succesfully;
                    MessageBox.Show($"Student: {sName} add successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_name.Clear();
                    txt_phone.Clear();
                    InitClassList();
                    InitGradeList();
                }
                else
                {
                    //add unsuccesfully;
                    MessageBox.Show($"Student: {sName} add unsuccessfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                //the record exist;
                MessageBox.Show("The student already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
