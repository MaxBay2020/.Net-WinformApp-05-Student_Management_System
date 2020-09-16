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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //1.get the username input
            string username = txt_username.Text;

            //2.get the password inout
            string password = txt_password.Text;

            //3.whether is empty or null
            if (string.IsNullOrEmpty(username.Trim()))
            {
                MessageBox.Show("Please enter username", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password.Trim()))
            {
                MessageBox.Show("Please enter password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Focus();
                return;
            }
            #region connecting to mysql
            ////4.connect to mysql
            ////4.1 establish connection
            //string connectStr = "server=localhost; port=3306;  database=studentdb; user id=root; password=123456; pooling=true;";
            //MySqlConnection connection = new MySqlConnection(connectStr);

            ////4.2 define sql
            //string sql = "SELECT * FROM tab_users WHERE uName = @uName AND uPassword = @uPassword";

            ////set params
            ////MySqlParameter paramUsername = new MySqlParameter("uName", username);
            ////MySqlParameter paramPassword = new MySqlParameter("uPassword", password);
            //MySqlParameter[] parameters = 
            //{
            //    new MySqlParameter("uName", username),
            //    new MySqlParameter("uPassword", password)
            //};

            ////4.3 create a command
            //MySqlCommand cmd = new MySqlCommand(sql, connection);

            //cmd.Parameters.Clear();
            ////cmd.Parameters.Add(paramUsername);
            ////cmd.Parameters.Add(paramPassword);
            //cmd.Parameters.AddRange(parameters);


            ////4.4 connection open
            //try
            //{
            //    connection.Open();
            //}
            //catch (Exception)
            //{

            //}


            ////4.4 execute sql
            //object o = cmd.ExecuteScalar();

            ////4.5 close connection
            //connection.Close();
            #endregion

            string sql = "SELECT * FROM tab_users WHERE uName = @uName AND uPassword = @uPassword";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@uName", username),
                new MySqlParameter("@uPassword",password)
            };

            object o = DatabaseConnection.ExecuteScalar(sql, parameters);


            //4.6 deal with result
            if (o == null || o == DBNull.Value || (int)o == 0)
            {
                //user not exist
                MessageBox.Show("Username or Password incorrect", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Clear();
                txt_password.Clear();
                return;
            }
            else
            {
                //user exist
                MessageBox.Show("Welcome back " + username, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //transfer to main form
                frm_main frm_main = new frm_main();
                frm_main.Show();

                //hide current form
                this.Hide();
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        /// <summary>
        /// when form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_login_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
        }
    }
}
