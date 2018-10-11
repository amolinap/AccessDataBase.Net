/**
 * @file:   DBMySQL.cs
 * @author: Alejandro Molina Pulido
 * @email:  am.alex09@gmail.com
 * @date:   Agosto 2013
 * @brief:  This file exposes the global connection to MySQL database.
 */

/*
 * MySQL                5.1.73
 * MySql.Data.dll       v6.9.5.0    Runtime v2.0.50727
 */

/*
 * https://downloads.mysql.com/archives/c-net/
 * https://downloads.mysql.com/archives/get/file/mysql-connector-net-6.9.5-noinstall.zip
 * 
 * Add reference to MySQL.Data.dll
 */

using System;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataBaseNet
{
    public class DBMySQL
    {
        public delegate void StatusConnection(String message);
        public event StatusConnection ConnectionMessage;

        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlTransaction transaction;

        public DBMySQL(string user, string pass, string db_name, string server, int port = 3306)
        {
            connection = new MySqlConnection("server=" + server + ";port=" + port + ";user id=" + user + ";password=" + pass + ";database=" + db_name + ";sslmode=none;persistsecurityinfo=True;");
            transaction = null;
            command = new MySqlCommand();
        }

        public DBMySQL(string connection_string)
        {
            connection = new MySqlConnection(connection_string);
            transaction = null;
            command = new MySqlCommand();
        }

        public string ConnectionString()
        {
            return connection.ConnectionString;
        }

        private MySql.Data.MySqlClient.MySqlConnection Connection()
        {
            return connection;
        }

        private void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DataSet RunQueryDataSet(string sql)
        {
            try
            {
                command.Connection = Connection();
                command.CommandText = sql;

                MySqlDataAdapter dAdapter = new MySqlDataAdapter();
                dAdapter.SelectCommand = command;

                DataSet dSet = new DataSet();
                dAdapter.Fill(dSet);

                OpenConnection();
                command.ExecuteNonQuery();
                CloseConnection();

                return dSet;
            }
            catch (Exception ex)
            {
                ConnectionMessage(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss - ") + ex.Message);

                return new DataSet();
            }
        }

        public string RunQueryParameter(string sql)
        {
            command.Connection = Connection();
            command.CommandText = sql;

            object resultado;

            OpenConnection();
            resultado = command.ExecuteScalar();
            CloseConnection();

            if (resultado == null)
            {
                resultado = string.Empty;
            }

            return resultado.ToString();
        }

        public DataTable RunQueryDataTable(string sql)
        {
            command.Connection = Connection();
            command.CommandText = sql;

            DataTable dTable = new DataTable();

            OpenConnection();
            dTable.Load(command.ExecuteReader());
            CloseConnection();

            return dTable;
        }

        public bool RunQueryCommand(string sql)
        {
            if (!string.IsNullOrEmpty(sql))
            {
                try
                {
                    command.Connection = Connection();
                    command.CommandText = sql;

                    OpenConnection();
                    transaction = connection.BeginTransaction();

                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception Excepcion)
                {
                    transaction.Rollback();

                    return false;
                }
                finally
                {
                    CloseConnection();
                }

                return true;
            }

            return false;
        }
    }
}