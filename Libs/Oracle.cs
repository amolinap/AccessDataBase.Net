using System;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace DataBaseNet
{
    public class Oracle
    {
        private OracleConnection connection;
        private OracleCommand command;
        private OracleTransaction transaction;

        public Oracle(string user, string pass, string db_name, string server, int port = 3306)
        {
            connection = new OracleConnection("Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + server + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + db_name + ")));Password=" + pass + ";User ID=" + user + ";");

            transaction = null;
            command = new OracleCommand();
        }

        public Oracle(string connection_string)
        {
            connection = new OracleConnection(connection_string);
            transaction = null;
            command = new OracleCommand();
        }
    }
}
