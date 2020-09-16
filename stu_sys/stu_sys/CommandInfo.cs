using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace stu_sys
{
    public class CommandInfo
    {
        //sql statement or name of process
        public string CommandText;

        //parameters
        public DbParameter[] Parameters;

        //is process?
        public bool isProc;

        public CommandInfo()
        {

        }

        public CommandInfo(string comText, bool isProc)
        {
            this.CommandText = comText;
            this.isProc = isProc;
        }

        public CommandInfo(string sqlText, bool isProc, DbParameter[] parameters)
        {
            this.CommandText = sqlText;
            this.Parameters = parameters;
            this.isProc = isProc;
        }

    }
}


