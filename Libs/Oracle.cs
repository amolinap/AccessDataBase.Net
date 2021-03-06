﻿/**
 * @file:   Oracle.cs
 * @author: Alejandro Molina Pulido
 * @email:  am.alex09@gmail.com
 * @date:   Octubre 2018
 * @brief:  This file exposes the global connection to Oracle XE 11g database.
 */

/*
 * Oracle XE 11g            11.2.0.2.0
 * Oracle.DataAccess.dll    v4.112.2.0    Runtime v4.0.30319
 */

using System;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace DataBaseNet
{
    public class DBOracle
    {
        public delegate void StatusConnection(String message);
        public event StatusConnection ConnectionMessage;
        
        private OracleConnection connection;
        private OracleCommand command;
        private OracleTransaction transaction;

        public DBOracle(string user, string pass, string sid, string host, int port = 1521)
        {
            connection = new OracleConnection("Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + pass + ";User ID=" + user + ";");

            transaction = null;
            command = new OracleCommand();
        }

        public DBOracle(string connection_string)
        {
            connection = new OracleConnection(connection_string);
            transaction = null;
            command = new OracleCommand();
        }

        public string ConnectionString()
        {
            return connection.ConnectionString;
        }

        private OracleConnection Connection()
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

                OracleDataAdapter dAdapter = new OracleDataAdapter();
                dAdapter.SelectCommand = command;

                DataSet dSet = new DataSet();
                dAdapter.Fill(dSet);

                OpenConnection();
                command.ExecuteNonQuery();
                CloseConnection();

                return dSet;
            }
            catch(Exception ex)
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
                catch (Exception ex)
                {
                    ConnectionMessage(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss - ") + ex.Message);

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
