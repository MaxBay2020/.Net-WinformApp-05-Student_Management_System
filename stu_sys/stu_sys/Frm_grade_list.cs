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
    public partial class Frm_grade_list : Form
    {
        private int flag = 0; //0: add, 1: modify

        private int gId_mod = 0;

        private string oldGName = "";

        public Frm_grade_list()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load data in the form when form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_grade_list_Load(object sender, EventArgs e)
        {
            //init grade list
            InitGrade();

            txt_gName.Clear();

            flag = 0;
            btn_submit.Text = "Add";
        }

        /// <summary>
        /// add grade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_gName.Clear();
            txt_gName.Focus();

            if (flag == 1)
            {
                //1 is modify, 0 is add
                flag = 0;

                btn_submit.Text = "Add";
            }
        }

        private void InitGrade()
        {
            //1.define sql
            string sql = "SELECT gId, gName " +
                "FROM tab_grade " +
                "WHERE isDeleted = 0 " +
                "ORDER BY gId";

            //2.call DatabaseConnection to execute sql
            DataTable dt_grade_list = DatabaseConnection.GetDataTable(sql);

            //3.assign dataSource
            dgv_grade_list.DataSource = dt_grade_list;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //1.accept info
            string gName = txt_gName.Text.Trim();

            //2.gName whether is empty
            if (string.IsNullOrEmpty(gName))
            {
                MessageBox.Show("Grade name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (flag == 0) //0: add
            {
                //whether grade exists
                //1.define sql
                string sql_exist = "SELECT COUNT(1) " +
                                    "FROM tab_grade " +
                                    "WHERE gName=@gName";

                //2. assign parameters
                MySqlParameter parameter = new MySqlParameter("@gName", gName);

                //3.execute sql
                object o = DatabaseConnection.ExecuteScalar(sql_exist, parameter);

                //4. whether o is null or empty string
                if(o!=null && o.ToString() != "0")
                {
                    //records exists;
                    MessageBox.Show("Grade name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                //5. otherwise, add record
                //5.1define sql
                string sql_add = "INSERT INTO tab_grade (gId, gName) VALUES(NULL, @gName);SELECT @@IDENTITY";

                MySqlParameter parameter_new = new MySqlParameter("@gName", gName);

                //5.2execute sql
                object oGId = DatabaseConnection.ExecuteScalar(sql_add, parameter_new);

                if (oGId != null && oGId.ToString() != "0")
                {
                    //add successfully
                    MessageBox.Show($"{gName} Add successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //refresh
                    DataTable dt_grade_list = (DataTable)dgv_grade_list.DataSource;

                    //add the new row into table
                    DataRow dr = dt_grade_list.NewRow();
                    dr["gId"] = int.Parse(oGId.ToString());
                    dr["gName"] = gName;

                    dt_grade_list.Rows.Add(dr);
                    dgv_grade_list.DataSource = dt_grade_list;
                }
                else
                {
                    //add unsuccessfully
                    MessageBox.Show("Add unsuccessfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else if(flag==1) //1:modify
            {
                if (gName == oldGName)
                {
                    MessageBox.Show("Grade name not changed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //1.define sql
                string sql_exist = "SELECT COUNT(1) " +
                                    "FROM tab_grade " +
                                    "WHERE gName=@gName " +
                                    "AND gId<>@gId";

                //2. assign parameters
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("@gName",gName),
                    new MySqlParameter("@gId",gId_mod)
                };

                //3.execute sql
                object o = DatabaseConnection.ExecuteScalar(sql_exist, parameters);

                //4. whether o is null or empty string
                if (o != null && o.ToString() != "0")
                {
                    //records exists;
                    MessageBox.Show("Grade name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                //modify data
                string sql_update = "UPDATE tab_grade SET gName = @gName WHERE gId=@gId";

                //5.2execute sql
                int count = DatabaseConnection.ExecuteNonQuery(sql_update, parameters);

                if (count>0)
                {
                    //add successfully
                    MessageBox.Show($"{gName} modify successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //refresh
                    DataTable dt_grade_list = (DataTable)dgv_grade_list.DataSource;

                    //add the new row into table
                    DataRow[] rows = dt_grade_list.Select("gId=" + gId_mod);

                    DataRow dr = rows[0];

                    dr["gName"] = gName;

                    dgv_grade_list.DataSource = dt_grade_list;
                }
                else
                {
                    //modify unsuccessfully
                    MessageBox.Show("Modify unsuccessfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        /// <summary>
        /// modify, delete function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_grade_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) //not click on header
            {
                //access clicked cell
                DataGridViewCell cell = dgv_grade_list.Rows[e.RowIndex].Cells[e.ColumnIndex];

                //access clicked row
                DataRow dr = (dgv_grade_list.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;

                //get clicked row gId
                gId_mod = (int)dr["gId"];

                if (cell is DataGridViewLinkCell && cell.FormattedValue.ToString() == "Modify")
                {
                    //modify clicked
                    //load gName to txt_gName
                    txt_gName.Text = dr["gName"].ToString();
                    oldGName = dr["gName"].ToString();
                    flag = 1; //1 is modify
                    btn_submit.Text = "Modify";

                }
                else if (cell is DataGridViewLinkCell && cell.FormattedValue.ToString() == "Delete")
                {
                    if (MessageBox.Show("Are you sure to delete this grade and its class and students?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        //delete clicked, delete student in cId and delete cId class
                        //1.define sql
                        //1.1delete student 
                        String sql_del_stu = "UPDATE tab_student SET isDeleted = 1 WHERE cId in (SELECT cId FROM tab_class WHERE gId=@gId)";

                        //1.2delete class
                        string sql_del_class = "UPDATE tab_class SET isDeleted=1 WHERE gId=@gId";


                        //1.3delete grade
                        string sql_del_grade = "UPDATE tab_grade SET isDeleted=1 WHERE gId=@gId";

                        //2.assign parameters
                        MySqlParameter[] parameter =
                            {
                            new MySqlParameter("@gId", gId_mod)
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


                        CommandInfo com_grade = new CommandInfo()
                        {
                            CommandText = sql_del_grade,
                            isProc = false,
                            Parameters = parameter
                        };
                        com_list.Add(com_grade);

                        //call commission method
                        bool flag = DatabaseConnection.ExecuteTrans(com_list);
                        if (flag)
                        {
                            //Delete successfully
                            MessageBox.Show("Delete successfully", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //refresh student list
                            DataTable dt_grade = (DataTable)dgv_grade_list.DataSource;

                            dt_grade.Rows.Remove(dr);

                            dgv_grade_list.DataSource = dt_grade;
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
        /// multiple delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //1.access selected rows' cId
            List<int> gId_list = new List<int>();

            for (int i = 0; i < dgv_grade_list.Rows.Count; i++)
            {
                //access check box each row
                DataGridViewCheckBoxCell cell = dgv_grade_list.Rows[i].Cells["col_check"] as DataGridViewCheckBoxCell;

                bool isChecked = Convert.ToBoolean(cell.Value);

                if (isChecked)
                {
                    //if checked, get this row and the sId in it
                    DataRow dr = (dgv_grade_list.Rows[i].DataBoundItem as DataRowView).Row;

                    int gId = (int)dr["gId"];
                    gId_list.Add(gId);
                }
            }

            //2.number of selected rows
            //2.1 0 row
            if (gId_list.Count == 0)
            {
                MessageBox.Show("Please select record first", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete this grade and its classes and their students?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //1.1delete student
                    String sql_del_stu = "UPDATE tab_student SET isDeleted = 1 WHERE cId in (SELECT cId FROM tab_class WHERE gId=@gId)";

                    //1.2delete class
                    string sql_del_class = "UPDATE tab_class SET isDeleted=1 WHERE gId=@gId";
                    
                    //1.3delete grade
                    string sql_del_grade = "UPDATE tab_grade SET isDeleted=1 WHERE gId=@gId";

                    List<CommandInfo> com_list = new List<CommandInfo>();

                    foreach (int cId in gId_list)
                    {
                        //2.assign parameters
                        MySqlParameter[] parameter =
                            {
                                new MySqlParameter("@gId", gId_mod)
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

                        CommandInfo com_grade = new CommandInfo()
                        {
                            CommandText = sql_del_grade,
                            isProc = false,
                            Parameters = parameter
                        };
                        com_list.Add(com_grade);
                    }

                    //call commission method
                    bool flag = DatabaseConnection.ExecuteTrans(com_list);
                    if (flag)
                    {
                        //Delete successfully
                        MessageBox.Show("Delete successfully", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //refresh student list
                        DataTable dt_grade = (DataTable)dgv_grade_list.DataSource;

                        string gIdStr = string.Join(",", gId_list);

                        DataRow[] rows = dt_grade.Select("gid in (" + gIdStr + ")");

                        foreach (DataRow dr in rows)
                        {
                            dt_grade.Rows.Remove(dr);
                        }

                        dgv_grade_list.DataSource = dt_grade;
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
