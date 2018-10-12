using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataBaseNet
{
    public class DBSQLServer
    {
        public delegate void StatusConnection(String message);
        public event StatusConnection ConnectionMessage;

        private SqlConnection connection;
        private SqlCommand command;
        private SqlTransaction transaction;

        public DBSQLServer(string usuario, string contrasena, string nombreBD, string servidor = "localhost", string instancia = "MSSQLSERVER")
        {
            try
            {
                connection = new SqlConnection("Data Source=" + servidor + "\\" + instancia + "; Initial Catalog=" + nombreBD + "; integrated security=yes; User Id=sa; Password=" + contrasena + ";");
                transaction = null;
                command = new SqlCommand();
            }
            catch (Exception ex)
            {
                ConnectionMessage(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss - ") + ex.Message);
            }
        }

        public DBSQLServer(string conexion)
        {
            connection = new SqlConnection(conexion);
            transaction = null;
            command = new SqlCommand();
        }

        public string ConnectionString()
        {
            return connection.ConnectionString;
        }

        private SqlConnection Connection()
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

                SqlDataAdapter dAdapter = new SqlDataAdapter();
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