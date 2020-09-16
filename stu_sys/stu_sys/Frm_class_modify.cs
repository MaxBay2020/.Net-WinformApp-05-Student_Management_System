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
    public partial class Frm_class_modify : Form
    {
        private int cId = 0;

        private string oldCName = "";

        private int oldGId = 0;

        private Action reLoad = null;

        public Frm_class_modify()
        {
            InitializeComponent();
        }

        /// <summary>
        /// when form opened, load class info based on cId transferred
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_class_modify_Load(object sender, EventArgs e)
        {
            //init grade list
            InitGrades();

            //init class info
            InitClassInfo();
        }

        /// <summary>
        /// init class infor based on transferred cId and delegate
        /// </summary>
        private void InitClassInfo()
        {
            if (this.Tag != null)
            {
                TagObject tagObject = (TagObject)this.Tag;
                cId = tagObject.CId;
                reLoad = tagObject.Reload;

                //search record based on sId
                //1.define sql
                string sql = "SELECT c.cName, c.gId, c.comment " +
                                "FROM tab_class c " +
                                "JOIN tab_grade g " +
                                "ON c.gId=g.gId " +
                                "WHERE c.cId = @cId";

                //2.assign parameters
                MySqlParameter parameter = new MySqlParameter("@cId", cId);

                //3.execute sql
                MySqlDataReader dr = DatabaseConnection.ExecuteReader(sql, parameter);

                //4.read data
                if (dr.Read())
                {
                    //get info
                    txt_class_name.Text = dr["cName"].ToString();
                    oldCName = txt_class_name.Text.Trim();
                    txt_comment.Text = dr["comment"].ToString();
                    //MessageBox.Show(dr["cId"].ToString());

                    int gId = (int)dr["gId"];
                    oldGId = gId;

                    //string cName = dr["cName"].ToString();
                    //string gName = dr["gName"].ToString();

                    //cbo_grade_list.Text = gName;
                    //cbo_class_list.Text = cName;

                    //set grade combo
                    cbo_grade.SelectedValue = gId;
                }

                dr.Close();
            }
        }

        /// <summary>
        /// load grade into combo from mysql
        /// </summary>
        private void InitGrades()
        {
            //1.define sql
            string sql = "SELECT gId, gName FROM tab_grade ORDER BY gId";
            DataTable dt_grade_list = DatabaseConnection.GetDataTable(sql);

            //load data to combo list
            cbo_grade.DataSource = dt_grade_list;

            cbo_grade.DisplayMember = "gName"; //displayed data
            cbo_grade.ValueMember = "gId"; //index

        }

        /// <summary>
        /// submit modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modify_Click(object sender, EventArgs e)
        {
            //1.get info
            //1.1 get class name
            string cName = txt_class_name.Text.Trim();
            //1.2 get gId
            int gId = (int)cbo_grade.SelectedValue;
            //1.3 get comment
            string comment = txt_comment.Text.Trim();

            //2. cannot be empty
            if (string.IsNullOrEmpty(cName))
            {
                //can not be empty
                MessageBox.Show("Class name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //3. query
            //3.1define sql
            string sql = "SELECT COUNT(1) FROM tab_class " +
                        "WHERE cName=@cName AND gId=@gId ";

            if (cName == oldCName&& gId == oldGId)
            {
                sql += " AND cId<>@cId ";
            }

            //3.2 assign parameters
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@cName", cName),
                new MySqlParameter("@gId", gId),
                new MySqlParameter("@cId", cId)
            };

            //3.3 execute sql
            object o = DatabaseConnection.ExecuteScalar(sql, parameters);

            if (o == null || o == DBNull.Value || o.ToString() == "0")
            {
                //the record not exist, modify
                //4. add student
                //4.1 define sql 
                string sql_update = "UPDATE tab_class " +
                                    "SET cName=@cName, " +
                                    "gId=@gId, " +
                                    "comment=@comment " +
                                    "WHERE cId=@cId";

                //4.2 assign parameters
                MySqlParameter[] parameters_update =
                {
                    new MySqlParameter("@cName", cName),
                    new MySqlParameter("@gId", gId),
                    new MySqlParameter("@comment", comment),
                    new MySqlParameter("@cId", cId),
                };

                //4.3 execute sql
                int count = DatabaseConnection.ExecuteNonQuery(sql_update, parameters_update);
                //MessageBox.Show(count + "");
                if (count > 0)
                {
                    //modify succesfully;
                    MessageBox.Show($"Class: {cName} modify successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //refresh student list immediately
                    reLoad.Invoke();

                    return;
                }
                else
                {
                    //modify unsuccesfully, info is the same
                    MessageBox.Show($"Class: {cName} information is the same", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                //5.if record exists, modify fail
                MessageBox.Show("The class already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        /// <summary>
        /// cancel button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
