using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GraceOjelabi
{
    /*
     * I would be creating the connection between desktop application and mysql database
     */
    internal class DBconnect : DBconnectBase
    {
        private readonly MySqlConnection getConnection = new("datasource=database-1.c0pfhbcn1n0c.us-east-1.rds.amazonaws.com;port=3306;username=admin;password=Taitai1992;database=Ojelabi");

        //create a function to open connection
        public void openConnect()
        {
            if (GetConnection.State == ConnectionState.Closed)
                GetConnection.Open();
        }

        //create afunction to close connection
        public void closeConnect()
        {
            if (GetConnection.State == System.Data.ConnectionState.Open)
                GetConnection.Close();
        }
    }
}
