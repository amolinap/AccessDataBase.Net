/**
 * @file:   DBPostgreSQL.cs
 * @author: Alejandro Molina Pulido
 * @email:  am.alex09@gmail.com
 * @date:   Agosto 2013
 * @brief:  This file exposes the global connection to PostgreSQL database.
 */

/*
 * PostgreSQL           v8.3
 * Mono.Security.dll    1.0.5000.0
 * Npgsql.dll           0.7.0.0
 */

using System;
using System.Text;
using System.Data;
using Npgsql;

namespace DataBaseNet
{
    public class DBPostgreSQL
    {
        private NpgsqlConnection connection;
        private NpgsqlCommand command;
        private NpgsqlTransaction transaction;

        public DBPostgreSQL(string user, string pass, string db_name, string server, int port = 5432)
        {
            connection = new NpgsqlConnection("Server = " + server + "; Port = " + port + "; User id = " + user + "; Password = " + pass + "; Database = " + db_name + ";");
            transaction = null;
            command = new NpgsqlCommand();
        }

        public DBPostgreSQL(string connection_string)
        {
            connection = new NpgsqlConnection(connection_string);
            transaction = null;
            command = new NpgsqlCommand();
        }

        public string ConnectionString()
        {
            return connection.ConnectionString;
        }

        private NpgsqlConnection Connection()
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

                NpgsqlDataAdapter dAdapter = new NpgsqlDataAdapter();
                dAdapter.SelectCommand = command;

                DataSet dSet = new DataSet();
                dAdapter.Fill(dSet);

                OpenConnection();
                command.ExecuteNonQuery();
                CloseConnection();

                return dSet;
            }
            catch
            {
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