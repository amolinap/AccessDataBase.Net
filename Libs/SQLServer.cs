using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BaseDatos
{
    public class DBSQLServer
    {
        private SqlConnection cadenaConexion;
        private SqlCommand comando;
        private SqlTransaction transaccion;

        public DBSQLServer(string usuario, string contrasena, string nombreBD, string servidor)
        {
            cadenaConexion = new SqlConnection("Data Source=" + servidor + "\\DBEXPRESS; Initial Catalog=" + nombreBD + "; integrated security=false; User Id=sa; Password=" + contrasena + ";");
            transaccion = null;
            comando = new SqlCommand();
        }

        public DBSQLServer(string conexion)
        {
            cadenaConexion = new SqlConnection(conexion);
            transaccion = null;
            comando = new SqlCommand();
        }

        private string CadenaConexion()
        {
            return cadenaConexion.ToString();
        }

        private SqlConnection LeerConexion()
        {
            return cadenaConexion;
        }

        public void AbrirConexion()
        {
            if (cadenaConexion.State == ConnectionState.Closed)
            {
                cadenaConexion.Open();
            }
        }

        public void CerrarConexion()
        {
            if (cadenaConexion.State == ConnectionState.Open)
            {
                cadenaConexion.Close();
            }
        }

        public DataSet EjecutarConsulta(string sql)
        {
            try
            {
                comando.Connection = LeerConexion();
                comando.CommandText = sql;

                SqlDataAdapter dAdapter = new SqlDataAdapter();
                dAdapter.SelectCommand = comando;

                DataSet dSet = new DataSet();
                dAdapter.Fill(dSet);

                AbrirConexion();
                comando.ExecuteNonQuery();
                CerrarConexion();

                return dSet;
            }
            catch
            {
                return new DataSet();
            }
        }

        public string EjecutarBusquedaParametro(string sql)
        {
            comando.Connection = LeerConexion();
            comando.CommandText = sql;

            object resultado;

            AbrirConexion();
            resultado = comando.ExecuteScalar();
            CerrarConexion();

            if (resultado == null)
            {
                resultado = "Nulo";
            }

            return resultado.ToString();
        }

        public DataTable EjecutarBusquedaDatos(string sql)
        {
            comando.Connection = LeerConexion();
            comando.CommandText = sql;

            DataTable dTable = new DataTable();                       

            AbrirConexion();            
            dTable.Load(comando.ExecuteReader());
            CerrarConexion();

            return dTable;
        }

        public string EjecutarInstruccion(string sql)
        {
            if (sql != "")
            {
                try
                {
                    comando.Connection = LeerConexion();
                    comando.CommandText = sql;

                    AbrirConexion();
                    transaccion = cadenaConexion.BeginTransaction();

                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();
                    transaccion.Commit();
                }
                catch (Exception Excepcion)
                {
                    transaccion.Rollback();

                    return Excepcion.Message;
                }
                finally
                {
                    CerrarConexion();
                }

                return "TRUE";
            }

            return "FALSE";
        }        
    }
}