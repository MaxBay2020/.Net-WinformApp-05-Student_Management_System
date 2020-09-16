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

namespace stu_sys
{
    public partial class Frm_student_list : Form
    {
        public Frm_student_list()
        {
            InitializeComponent();
        }

        //delegate
        private Action reLoad = null;

        #region single instance
        //private static Frm_student_list frm_Student_List = null;
        //public static Frm_student_list CreateInstance()
        //{
        //    if (frm_Student_List == null || frm_Student_List.IsDisposed)
        //    {
        //        frm_Student_List = new Frm_student_list();

        //    }

        //    return frm_Student_List;
        //}
        #endregion


        /// <summary>
        /// load class list and grade list when form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_student_list_Load(object sender, EventArgs e)
        {
            //add data to class list combo
            InitClassList();

            //add data to grade list combo
            InitGradeList();

            //add student list data to dgv
            InitAllStudentList();
        }

        /// <summary>
        /// load all student data when form load
        /// </summary>
        private void InitAllStudentList()
        {
            cbo_grade_list.Tag = null; 
            //1.define sql
            string sql = "SELECT s.sId, s.sName, s.sGender, c.cName, g.gName, s.sPhone, s.createTime " +
                            "FROM tab_student s " +
                            "JOIN tab_class c " +
                            "ON s.cId=c.cId " +
                            "JOIN tab_grade g " +
                            "ON c.gId=g.gId "   +
                            "WHERE s.isDeleted=0 " +
                            "ORDER BY s.sId ";

            //2.execute sql
            DataTable dt_student_list = DatabaseConnection.GetDataTable(sql);


            //3.put result into dvg
            dgv_student.DataSource = dt_student_list;

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
            cbo_class_list.Tag = "1";
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
        /// reset conditions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reset_Click(object sender, EventArgs e)
        {
            cbo_class_list.Tag = null;
            cbo_grade_list.Tag = null;
            txt_sName.Clear();
            txt_sName.Focus();
            InitClassList();
            InitGradeList();
            InitAllStudentList();
        }

        /// <summary>
        /// based on conditions, find students
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_find_Click(object sender, EventArgs e)
        {
            //otherwise, based on conditions, find students
            //1.get input value
            //1.1 get student name input
            string sName = txt_sName.Text.Trim();

            //1.2 get class name selected
            string cName = cbo_class_list.Text;

            //1.3get grade selected
            string gName = cbo_grade_list.Text;


            //2.define sql
            string sql = "SELECT s.sId, s.sName, s.sGender, c.cName, g.gName, s.sPhone, s.createTime " +
                            "FROM tab_student s " +
                            "JOIN tab_class c " +
                            "ON s.cId=c.cId " +
                            "JOIN tab_grade g " +
                            "ON c.gId=g.gId " +
                            "WHERE 1=1 " +
                            "AND s.isDeleted = 0";

            //if no condition
            if (string.IsNullOrEmpty(sName) && (int)cbo_class_list.SelectedValue == 0 && (int)cbo_grade_list.SelectedValue == 0)
            {
                txt_sName.Clear();
                InitAllStudentList();

            }
            else if (!string.IsNullOrEmpty(sName) && (int)cbo_class_list.SelectedValue == 0 && (int)cbo_grade_list.SelectedValue == 0)
            {
                //if student name is entered;

                sql += " AND s.sName LIKE @sName";

                //3.set parameters
                MySqlParameter[] parameters =
                    {
                        new MySqlParameter("@sName", "%"+sName+"%")
                    };

                //4.execute sql
                DataTable dt_student_list = DatabaseConnection.GetDataTable(sql, parameters);

                //5.put result into dgv
                dgv_student.DataSource = dt_student_list;
            }
            else
            {
             
                //if all 3 conditions entered;

                sql += " AND cName = @cName ";
                sql += " AND gName = @gName ";

                //if student name input has value
                if (!string.IsNullOrEmpty(sName))
                {
                    sql += " AND s.sName LIKE @sName";

                    //3.set parameters
                    MySqlParameter[] parameters =
                    {
                        new MySqlParameter("@cName", cName),
                        new MySqlParameter("@gName", gName),
                        new MySqlParameter("@sName", "%"+sName+"%")
                    };

                    //4.execute sql
                    DataTable dt_student_list = DatabaseConnection.GetDataTable(sql, parameters);

                    //5.put result into dgv
                    dgv_student.DataSource = dt_student_list;
                }
                else
                {
                    //3.set parameters
                    MySqlParameter[] parameters =
                    {
                        new MySqlParameter("@cName", cName),
                        new MySqlParameter("@gName", gName),
                    };

                    //MessageBox.Show("cName:" + cName);
                    //MessageBox.Show("gName:" + gName);
                    //MessageBox.Show(sql);

                    //4.execute sql
                    DataTable dt_student_list = DatabaseConnection.GetDataTable(sql, parameters);

                    //5.put result into dgv
                    dgv_student.DataSource = dt_student_list;
                }

            }



        }


        /// <summary>
        /// modify and delete function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) //-1 is title clicked
            {
                DataRow dr = (dgv_student.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;

                //1.get cell clicked
                DataGridViewCell cell = dgv_student.Rows[e.RowIndex].Cells[e.ColumnIndex];

                //2.get the cell content
                if (cell is DataGridViewLinkCell && cell.FormattedValue.ToString() == "Modify")
                {
                    //modify clicked
                    //open modify form

                    //bring sId
                    //get sId
                    int sId = (int)dr["sId"];

                    Frm_modity frm_Modity = new Frm_modity();

                    //bring delegate
                    //assign delegate
                    reLoad = InitAllStudentList;

                    //transfer delegate and sId
                    frm_Modity.Tag = new TagObject()
                    {
                        SId = sId,
                        Reload = reLoad
                    };


                    //set MDI container
                    frm_Modity.MdiParent = this.MdiParent;
                    
                    frm_Modity.Show();
                }
                else if (cell is DataGridViewLinkCell && cell.FormattedValue.ToString() == "Delete")
                {
                    //fake delete clicked, isDeleted 0 -> 1
                    if(MessageBox.Show("Are you sure to delete?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //3.if yes selected, delete student
                        //3.1define sql
                        string sql_del = "UPDATE tab_student SET isDeleted=1 WHERE sId=@sId";

                        //3.2get sId
                        //get row clicked

                        //get sId
                        int sId = int.Parse(dr["sId"].ToString());

                        //3.3 assign parameters
                        MySqlParameter[] parameters =
                        {
                            new MySqlParameter("@sId", sId)
                        };

                        //3.4execute sql
                        int count = DatabaseConnection.ExecuteNonQuery(sql_del, parameters);

                        if (count > 0)
                        {
                            //delete successfully
                            MessageBox.Show("Delete successfully", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //refresh student list
                            DataTable dt_student = (DataTable)dgv_student.DataSource;
                            //dgv_student.DataSource = null;
                            dt_student.Rows.Remove(dr);
                            dgv_student.DataSource = dt_student;
                        }
                        else
                        {
                            //delete unsuccessfully
                            MessageBox.Show("Delete unsuccessfully", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                    }
                    else
                    {
                        //if no selected, cancel
                        return;
                    }
                }

            }

        }

        /// <summary>
        /// delete button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //1.access selected rows' sId
            List<int> sId_list = new List<int>();
            for (int i = 0; i < dgv_student.Rows.Count; i++)
            {
                //access check box each row
                DataGridViewCheckBoxCell cell = dgv_student.Rows[i].Cells["col_check"] as DataGridViewCheckBoxCell;

                bool isChecked = Convert.ToBoolean(cell.Value);

                if (isChecked)
                {
                    //if checked, get this row and the sId in it
                    DataRow dr = (dgv_student.Rows[i].DataBoundItem as DataRowView).Row;

                    int sId = (int)dr["sId"];
                    sId_list.Add(sId);
                }
            }

            //2.number of selected rows
            //2.1 0 row
            if (sId_list.Count == 0)
            {
                MessageBox.Show("Please select record first", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //2.1 >0 delete selected rows

                    int count = 0;

                    //start commit
                    using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.connectStr))
                    {
                        //start commit by connection (opened);
                        connection.Open();
                        MySqlTransaction transaction = connection.BeginTransaction();

                        //create mysqlcommand object
                        MySqlCommand cmd = new MySqlCommand();

                        cmd.Connection = connection;

                        cmd.Transaction = transaction;

                        //start to execute sql
                        try
                        {
                            foreach (int sId in sId_list)
                            {
                                //define sql
                                cmd.CommandText = "UPDATE tab_student SET isDeleted=1 WHERE sId=@sId";

                                //assign parameters
                                MySqlParameter parameter = new MySqlParameter("@sId", sId);

                                //execute sql
                                cmd.Parameters.Clear();

                                cmd.Parameters.Add(parameter);

                                count += cmd.ExecuteNonQuery();
                                
                            }

                            //submit commit
                            transaction.Commit();
                        }
                        catch (Exception)
                        {

                            //if theres error, rollback
                            transaction.Rollback();
                            MessageBox.Show("Delete failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (count == sId_list.Count)
                    {
                        MessageBox.Show("Delete successfully. \r\n" + count + " records have been deleted", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //refresh student list
                        DataTable dt_student = (DataTable)dgv_student.DataSource;

                        string sIdStr = string.Join(",", sId_list);

                        DataRow[] rows = dt_student.Select("sid in ("+sIdStr+")");

                        foreach (DataRow dr in rows)
                        {
                            dt_student.Rows.Remove(dr);
                        }

                        dgv_student.DataSource = dt_student;
                        
                        return;
                    }

                }

            }

        }
    }
}
