using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace stu_sys
{
    public partial class Frm_add_class : Form
    {
        public Frm_add_class()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load grade data when form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_add_class_Load(object sender, EventArgs e)
        {
            //1.load grade data into combo
            InitGradeData();
        }

        /// <summary>
        /// init grade data
        /// </summary>
        private void InitGradeData()
        {
            //1.define sql
            string sql = "SELECT gId, gName FROM tab_grade ORDER BY gId";

            //2.execute sql
            DataTable db_grade_list = DatabaseConnection.GetDataTable(sql);

            //3.load grade data
            cbo_grade.DataSource = db_grade_list;
            cbo_grade.DisplayMember = "gName";
            cbo_grade.ValueMember = "gId";
            cbo_grade.SelectedIndex = 0;
        }

        /// <summary>
        /// insert data into tab_class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //1.get class name
            string cName = txt_class_name.Text.Trim();

            //2.get grade
            int gId = (int)cbo_grade.SelectedValue;

            //3. get comment
            string comment = txt_comment.Text.Trim();

            if (string.IsNullOrEmpty(cName))
            {
                //class name cannot be empty
                MessageBox.Show("Class Name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_class_name.Focus();
                return;
            }

            //4.whether the record exists in mysql
            //4.1define sql
            string sql = "SELECT COUNT(*) FROM tab_class";
            sql += " WHERE 1=1 ";
            sql += " AND cName=@cName ";
            sql += " AND gId=@gId ";

            //4.2execute sql
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@cName", cName),
                new MySqlParameter("@gId", gId)
            };

            Object dt_count = DatabaseConnection.ExecuteScalar(sql, parameters);
            
            if (dt_count==null || dt_count == DBNull.Value || dt_count.ToString()=="0")
            {
                //not exist, save record
                //4.3 define sql
                string sql_add = "INSERT INTO tab_class " +
                    "(cId, cName, gId, comment) " +
                    "VALUES " +
                    "(NULL, @cName, @gId, @comment)";

                //4.4 execute sql
                MySqlParameter[] parameters_add =
                {
                    new MySqlParameter("@cName", cName),
                    new MySqlParameter("@gId", gId),
                    new MySqlParameter("@comment", comment)

                };

                int count = DatabaseConnection.ExecuteNonQuery(sql_add, parameters_add);
                if (count != 0)
                {
                    //add successfully;
                    MessageBox.Show($"Class: {cName} add successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_class_name.Clear();
                    txt_comment.Clear();
                    return;
                }
                else
                {
                    //fail
                    MessageBox.Show($"Class: {cName} add unsuccessfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                //record exist
                MessageBox.Show("Class exists", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close this form 
            this.Close();
        }
    }
}
