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
    public partial class Frm_modity : Form
    {
        public Frm_modity()
        {
            InitializeComponent();
        }

        private int sId = 0;

        //delegate
        private Action reLoad = null;

        //public Frm_modity(int sId)
        //{
        //    InitializeComponent();
        //    this._sId = sId;
        //}

        /// <summary>
        /// cancel button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_modity_Load(object sender, EventArgs e)
        {
            //init class list
            InitClassList();

            //init grade list
            InitGradeList();

            //load student info
            InitStuInfo();
        }

        /// <summary>
        /// load student info when form load
        /// </summary>
        private void InitStuInfo()
        {
            //get sId
            if (this.Tag != null)
            {
                TagObject tagObject = (TagObject)this.Tag;

                sId = tagObject.SId;

                reLoad = tagObject.Reload;

                //search record based on sId
                //1.define sql
                string sql = "SELECT s.sName, s.sGender, c.cId, g.gId, s.sPhone " +
                                "FROM tab_student s " +
                                "JOIN tab_class c " +
                                "ON s.cId=c.cId " +
                                "JOIN tab_grade g " +
                                "ON c.gId=g.gId " +
                                "WHERE s.sId = @sId";

                //2.assign parameters
                MySqlParameter parameter = new MySqlParameter("@sId", sId);

                //3.execute sql
                MySqlDataReader dr = DatabaseConnection.ExecuteReader(sql, parameter);

                //4.read data
                if (dr.Read())
                {
                    //get info
                    txt_name.Text = dr["sName"].ToString();
                    txt_phone.Text = dr["sPhone"].ToString();
                    string sGender = dr["sGender"].ToString();
                    //MessageBox.Show(dr["cId"].ToString());
                    
                    int cId = (int)dr["cId"];
                    int gId = (int)dr["gId"];
                    
                    //string cName = dr["cName"].ToString();
                    //string gName = dr["gName"].ToString();

                    //set gender
                    if ("Male".Equals(sGender) || "male".Equals(sGender))
                    {
                        r_male.Checked = true;
                    }
                    else
                    {
                        r_female.Checked = true;
                    }

                    //cbo_grade_list.Text = gName;
                    //cbo_class_list.Text = cName;

                    //set class combo
                    cbo_class_list.SelectedValue = cId;

                    //set grade combo
                    cbo_grade_list.SelectedValue = gId;


                    cbo_grade_list.Tag = "1";
                }

                dr.Close();

            }
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

            ////5.set initial value
            //cbo_class_list.SelectedIndex = 0;
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

            ////5.set initial value
            //cbo_grade_list.SelectedIndex = 0;

        }

 

        /// <summary>
        /// when class list combo changed, reload grade list combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_class_list_SelectedIndexChanged_1(object sender, EventArgs e)
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

                cbo_class_list.Tag = null;
            }
        }

        /// <summary>
        /// close button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_modity_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        /// <summary>
        /// confirm modify info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modify_Click(object sender, EventArgs e)
        {
            //1.get info
            string sName = txt_name.Text.Trim();
            string sGender = r_male.Checked ? r_male.Text.Trim() : r_female.Text.Trim();
            int cId = (int)cbo_class_list.SelectedValue;
            int gId = (int)cbo_grade_list.SelectedValue;
            string sPhone = txt_phone.Text.Trim();

            //2.can not be empty
            if (string.IsNullOrEmpty(sName) || cId == 0 || string.IsNullOrEmpty(sPhone))
            {
                //has empty blank
                MessageBox.Show("Please fill all blanks", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //3.based on name and phone, search in database
            //3.1 define sql
            string sql = "SELECT COUNT(1) FROM tab_student " +
                        "WHERE sName=@sName AND sPhone=@sPhone " +
                        "AND sId<>@sId";

            //3.2 assign parameters
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@sName", sName),
                new MySqlParameter("@sPhone", sPhone),
                new MySqlParameter("@sId", sId)
            };

            //3.3 execute sql
            object o = DatabaseConnection.ExecuteScalar(sql, parameters);

            if (o == null || o == DBNull.Value || o.ToString() == "0")
            {
                //the record not exist, modify
                //4. add student
                //4.1 define sql 
                string sql_update = "UPDATE tab_student " +
                                    "SET sName=@sName, " +
                                    "sGender=@sGender, " +
                                    "cId=@cId, " +
                                    "sPhone=@sPhone " +
                                    "WHERE sId=@sId";

                //4.2 assign parameters
                MySqlParameter[] parameters_update =
                {
                    new MySqlParameter("@sName", sName),
                    new MySqlParameter("@sGender", sGender),
                    new MySqlParameter("@cId", cId),
                    new MySqlParameter("@sPhone", sPhone),
                    new MySqlParameter("@sId", sId)
                };

                //4.3 execute sql
                int count = DatabaseConnection.ExecuteNonQuery(sql_update, parameters_update);
                //MessageBox.Show(count + "");
                if (count > 0)
                {
                    //modify succesfully;
                    MessageBox.Show($"Student: {sName} modify successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //refresh student list immediately
                    reLoad.Invoke();

                    return;
                }
                else
                {
                    //modify unsuccesfully, info is the same
                    MessageBox.Show($"Student: {sName} information is the same", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                //5.if record exists, modify fail
                MessageBox.Show("The student already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        

        }
    }
}
