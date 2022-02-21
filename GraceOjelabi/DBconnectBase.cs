using MySql.Data.MySqlClient;

namespace GraceOjelabi
{
    internal class DBconnectBase
    {
        internal MySqlConnection? getconnection;
        private MySqlConnection getConnection;

        //to get connection

        public MySqlConnection GetConnection => getConnection;
    }
}