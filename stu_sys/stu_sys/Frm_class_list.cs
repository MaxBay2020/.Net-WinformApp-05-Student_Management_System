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
    public partial class Frm_class_list : Form
    {
        //delegate
        private Action reLoad = null;

        public Frm_class_list()
        {
            InitializeComponent();
        }

        /// <summary>
        /// show class list when form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_class_list_Load(object sender, EventArgs e)
        {
            //1.load grade data
            InitGrades();


            //2.load all class list
            InitAllClasses();
        }

        /// <summary>
        /// load all classes data
        /// </summary>
        private void InitAllClasses()
        {
            //1.define sql
            string sql = "SELECT c.cId, c.cName, g.gName, c.comment " +
                            "FROM tab_class c " +
                            "JOIN tab_grade g " +
                            "ON c.gId = g.gId " +
                            "WHERE c.isDeleted=0 " +
                            "ORDER BY c.cId";

            //2.execute sql
            DataTable dt_class_list = DatabaseConnection.GetDataTable(sql);

            //3.assign data to dgv
            dgv_class_list.DataSource = dt_class_list;
        }

        /// <summary>
        /// load grade into combo from mysql
        /// </summary>
        private void InitGrades()
        {
            //1.define sql
            string sql = "SELECT gId, gName FROM tab_grade ORDER BY gId";
            DataTable dt_grade_list = DatabaseConnection.GetDataTable(sql);

            //please select item
            DataRow dr = dt_grade_list.NewRow();
            dr["gId"] = 0;
            dr["gName"] = "--Please Select--";

            //add to the last element
            dt_grade_list.Rows.InsertAt(dr, 0);

            //load data to combo list
            cbo_grade.DataSource = dt_grade_list;

            cbo_grade.DisplayMember = "gName"; //displayed data
            cbo_grade.ValueMember = "gId"; //index

            cbo_grade.SelectedIndex = 0;
        }

        /// <summary>
        /// based on conditions, find data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_find_Click(object sender, EventArgs e)
        {
            //1.get combo value
            int grade_id = (int)cbo_grade.SelectedValue;

            //2.get class name input
            string class_name_input = txt_class.Text.Trim();

            //3.define sql
            string sql = "SELECT c.cId, c.cName, g.gName, c.comment " +
                            "FROM tab_class c " +
                            "JOIN tab_grade g " +
                            "ON c.gId = g.gId " +
                            "WHERE 1=1 ";
            sql += " AND c.isDeleted = 0 ";

            if (grade_id > 0)
            {
                sql += " AND g.gId=@gId ";
            }

            if (!string.IsNullOrEmpty(class_name_input))
            {
                sql += " AND c.cName LIKE @cName ";
            }

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@gId", grade_id),
                new MySqlParameter("@cName", "%"+class_name_input+"%"),
            };

            DataTable dt_class_list = DatabaseConnection.GetDataTable(sql, parameters);
            dgv_class_list.DataSource = dt_class_list;
        }

        /// <summary>
        /// cell clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_class_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) //not click on header
            {
                //access clicked cell
                DataGridViewCell cell = dgv_class_list.Rows[e.RowIndex].Cells[e.ColumnIndex];

                //access clicked row
                DataRow dr = (dgv_class_list.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;

                //get clicked row cId
                int cId = (int)dr["cId"];

                if (cell is DataGridViewLinkCell && cell.FormattedValue.ToString() == "Modify")
                {
                    //modify clicked
                    Frm_class_modify frm_Class_Modify = new Frm_class_modify();

                    //transfer cId, and delegate to class modify form
                    reLoad = InitAllClasses;

                    frm_Class_Modify.Tag = new TagObject()
                    {
                        CId = cId,
                        Reload = reLoad
                    };
                    frm_Class_Modify.MdiParent = this.MdiParent;
                    frm_Class_Modify.Show();

                }
                else if (cell is DataGridViewLinkCell && cell.FormattedValue.ToString() == "Delete")
                {
                    if (MessageBox.Show("Are you sure to delete this class and its students?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        //delete clicked, delete student in cId and delete cId class
                        //1.define sql
                        //1.1delete student 
                        String sql_del_stu = "UPDATE tab_student SET isDeleted = 1 WHERE cId=@cId";

                        //1.2delete class
                        string sql_del_class = "UPDATE tab_class SET isDeleted=1 WHERE cId=@cId";

                        //2.assign parameters
                        MySqlParameter[] parameter =
                            {
                            new MySqlParameter("@cId", cId)
                        };

                        //3.execute sql
                        //3.1 multiple sql execution, use commission
                        List<CommandInfo> com_list = new List<CommandInfo>();
                        CommandInfo com_student = new CommandInfo()
                        {
                            CommandText = sql_del_stu,
                            isProc = false,
                            Parameters = parameter
                        };
                        com_list.Add(com_student);

                        CommandInfo com_class = new CommandInfo()
                        {
                            CommandText = sql_del_class,
                            isProc = false,
                            Parameters = parameter
                        };
                        com_list.Add(com_class);

                        //call commission method
                        bool flag = DatabaseConnection.ExecuteTrans(com_list);
                        if (flag)
                        {
                            //Delete successfully
                            MessageBox.Show("Delete successfully", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //refresh student list
                            DataTable dt_class = (DataTable)dgv_class_list.DataSource;

                            dt_class.Rows.Remove(dr);

                            dgv_class_list.DataSource = dt_class;
                        }
                        else
                        {
                            //Delete unsuccessfully
                            MessageBox.Show("Delete unsuccessfully", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// multiple delete, delete button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //1.access selected rows' cId
            List<int> cId_list = new List<int>();

            for (int i = 0; i < dgv_class_list.Rows.Count; i++)
            {
                //access check box each row
                DataGridViewCheckBoxCell cell = dgv_class_list.Rows[i].Cells["col_check"] as DataGridViewCheckBoxCell;

                bool isChecked = Convert.ToBoolean(cell.Value);

                if (isChecked)
                {
                    //if checked, get this row and the sId in it
                    DataRow dr = (dgv_class_list.Rows[i].DataBoundItem as DataRowView).Row;

                    int cId = (int)dr["cId"];
                    cId_list.Add(cId);
                }
            }

            //2.number of selected rows
            //2.1 0 row
            if (cId_list.Count == 0)
            {
                MessageBox.Show("Please select record first", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete these classes and their students?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //1.1delete student
                    String sql_del_stu = "UPDATE tab_student SET isDeleted = 1 WHERE cId=@cId";

                    //1.2delete class
                    string sql_del_class = "UPDATE tab_class SET isDeleted=1 WHERE cId=@cId";

                    List<CommandInfo> com_list = new List<CommandInfo>();

                    foreach (int  cId in cId_list)
                    {
                        //2.assign parameters
                        MySqlParameter[] parameter =
                            {
                                new MySqlParameter("@cId", cId)
                            };

                        //3.execute sql
                        //3.1 multiple sql execution, use commission
                        CommandInfo com_student = new CommandInfo()
                        {
                            CommandText = sql_del_stu,
                            isProc = false,
                            Parameters = parameter
                        };
                        com_list.Add(com_student);

                        CommandInfo com_class = new CommandInfo()
                        {
                            CommandText = sql_del_class,
                            isProc = false,
                            Parameters = parameter
                        };
                        com_list.Add(com_class);
                    }

                    //call commission method
                    bool flag = DatabaseConnection.ExecuteTrans(com_list);
                    if (flag)
                    {
                        //Delete successfully
                        MessageBox.Show("Delete successfully", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //refresh student list
                        DataTable dt_class = (DataTable)dgv_class_list.DataSource;

                        string cIdStr = string.Join(",", cId_list);

                        DataRow[] rows = dt_class.Select("cid in (" + cIdStr + ")");

                        foreach (DataRow dr in rows)
                        {
                            dt_class.Rows.Remove(dr);
                        }

                        dgv_class_list.DataSource = dt_class;
                    }
                    else
                    {
                        //Delete unsuccessfully
                        MessageBox.Show("Delete unsuccessfully", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }
        }

    }
}
