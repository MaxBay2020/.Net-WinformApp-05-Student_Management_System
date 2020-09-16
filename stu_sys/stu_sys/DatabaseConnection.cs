using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace stu_sys
{
    /// <summary>
    /// MySQL connection tool class
    /// </summary>
    public static class DatabaseConnection
    {
        //private string connectStr = "server=localhost; port=3306;  database=studentdb; user id=root; password=123456; pooling=true;";

        //get connection string from configuration file
        public static string connectStr = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;

        public static object ExecuteScalar(string sql, params MySqlParameter[] parameters)
        {

            object o = null;

            //4.connect to mysql
            //4.1 establish connection
            using (MySqlConnection connection = new MySqlConnection(connectStr))
            {
                //4.3 create a command
                MySqlCommand cmd = new MySqlCommand(sql, connection);

                cmd.Parameters.Clear();
                //cmd.Parameters.Add(paramUsername);
                //cmd.Parameters.Add(paramPassword);
                cmd.Parameters.AddRange(parameters);


                //4.4 connection open
                try
                {
                    connection.Open();
                }
                catch (Exception)
                {

                }


                //4.4 execute sql
                o = cmd.ExecuteScalar();

                //4.5 close connection
                //connection.Close();
            }

            return o;
        }


        /// <summary>
        /// find data
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql, params MySqlParameter[] parameters)
        {
            DataTable dt = new DataTable();

            //4.connect to mysql
            //4.1 establish connection
            using (MySqlConnection connection = new MySqlConnection(connectStr))
            {
                //4.3 create a command
                MySqlCommand cmd = new MySqlCommand(sql, connection);

                if (parameters != null)
                {
                    cmd.Parameters.Clear();
                    //cmd.Parameters.Add(paramUsername);
                    //cmd.Parameters.Add(paramPassword);
                    cmd.Parameters.AddRange(parameters);
                }

                //4.4 connection open
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = cmd;

                //4.4 execute sql and fill data
                mda.Fill(dt);

            }

            return dt;
        }

        /// <summary>
        /// insert recore, insert, update, delete can use this method
        /// </summary>
        /// <param name="sql">sql statement</param>
        /// <param name="parameters">parameters in sql statement</param>
        /// <returns>return the number of affected rows</returns>
        public static int ExecuteNonQuery(string sql, params MySqlParameter[] parameters)
        {
            int count = 0;

            //4.connect to mysql
            //4.1 establish connection
            using (MySqlConnection connection = new MySqlConnection(connectStr))
            {
                //4.3 create a command
                MySqlCommand cmd = new MySqlCommand(sql, connection);

                cmd.Parameters.Clear();
                //cmd.Parameters.Add(paramUsername);
                //cmd.Parameters.Add(paramPassword);
                cmd.Parameters.AddRange(parameters);


                //4.4 connection open
                try
                {
                    connection.Open();
                }
                catch (Exception)
                {

                }


                //4.4 execute sql
                count = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                //4.5 close connection
                //connection.Close();
            }

            return count;
        }

        /// <summary>
        /// search query, return MySqlDataReader object
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static MySqlDataReader ExecuteReader(string sql, params MySqlParameter[] parameters)
        {
            MySqlConnection connection = new MySqlConnection(connectStr);

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);

                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(parameters);

                connection.Open();
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
            catch (Exception e)
            {
                connection.Close();
                throw new Exception("123", e);
            }


        }

        /// <summary>
        /// execute commission
        /// </summary>
        /// <param name="com_list">sqls</param>
        /// <returns></returns>
        public static bool ExecuteTrans(List<CommandInfo> com_list)
        {
            using(MySqlConnection connection = new MySqlConnection(connectStr))
            {
                //open connection
                connection.Open();

                //begin transaction
                MySqlTransaction trans = connection.BeginTransaction();

                //create MySqlCommand object
                MySqlCommand cmd = new MySqlCommand();

                //assign connection
                cmd.Connection = connection;

                //assign transaction
                cmd.Transaction = trans;

                try
                {
                    int count = 0;

                    for (int i = 0; i < com_list.Count; i++)
                    {
                        cmd.CommandText = com_list[i].CommandText;

                        if (com_list[i].isProc)
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                        }
                        else
                        {
                            cmd.CommandType = CommandType.Text;
                        }

                        if (com_list[i].Parameters.Length > 0)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddRange(com_list[i].Parameters);
                        }

                        count += cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                    trans.Commit();
                    return true;
                }
                catch (Exception)
                {

                    trans.Rollback();
                    throw new Exception("failed");
                    return false;
                }
            }
        }

    }
}
