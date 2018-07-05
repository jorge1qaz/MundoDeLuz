using System.Data;
using System.Data.SqlClient;

namespace Data.CRUD
{
    public class Node: Nodos
    {
        public bool FullNode(string storedProcedure)
        {
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter paramIdNodo     = new SqlParameter();
            paramIdNodo.SqlDbType        = SqlDbType.NVarChar;
            paramIdNodo.ParameterName    = "@IdNodo";
            paramIdNodo.Value            = IdNodo;
            sqlCommand.Parameters.Add(paramIdNodo);

            SqlParameter paramIdCategoria     = new SqlParameter();
            paramIdCategoria.SqlDbType        = SqlDbType.NVarChar;
            paramIdCategoria.ParameterName    = "@IdCategoria";
            paramIdCategoria.Value            = IdCategoria;
            sqlCommand.Parameters.Add(paramIdCategoria);

            SqlParameter paramCantidad     = new SqlParameter();
            paramCantidad.SqlDbType        = SqlDbType.NVarChar;
            paramCantidad.ParameterName    = "@Cantidad";
            paramCantidad.Value            = Cantidad;
            sqlCommand.Parameters.Add(paramCantidad);

            SqlParameter paramIdUsuario     = new SqlParameter();
            paramIdUsuario.SqlDbType        = SqlDbType.NVarChar;
            paramIdUsuario.ParameterName    = "@IdUsuario";
            paramIdUsuario.Value            = IdUsuario;
            sqlCommand.Parameters.Add(paramIdUsuario);

            SqlParameter paramIdNivel     = new SqlParameter();
            paramIdNivel.SqlDbType        = SqlDbType.NVarChar;
            paramIdNivel.ParameterName    = "@IdNivel";
            paramIdNivel.Value            = IdNivel;
            sqlCommand.Parameters.Add(paramIdNivel);

            SqlParameter paramComprobacion  = new SqlParameter();
            paramComprobacion.Direction     = ParameterDirection.Output;
            paramComprobacion.SqlDbType     = SqlDbType.Bit;
            paramComprobacion.ParameterName = "@Validation";
            sqlCommand.Parameters.Add(paramComprobacion);

            connection.Connect();
            sqlCommand.ExecuteNonQuery();
            connection.Disconnect();
            return bool.Parse(sqlCommand.Parameters["@Validation"].Value.ToString());
        }

        public bool UpdateNode() // Corregir
        {
            string storedProcedure  = "Negocio_Create_Node";
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter paramIdCategoria     = new SqlParameter();
            paramIdCategoria.SqlDbType        = SqlDbType.NVarChar;
            paramIdCategoria.ParameterName    = "@IdCategoria";
            paramIdCategoria.Value            = IdCategoria;
            sqlCommand.Parameters.Add(paramIdCategoria);

            SqlParameter paramIdUsuario     = new SqlParameter();
            paramIdUsuario.SqlDbType        = SqlDbType.NVarChar;
            paramIdUsuario.ParameterName    = "@IdUsuario";
            paramIdUsuario.Value            = IdUsuario;
            sqlCommand.Parameters.Add(paramIdUsuario);

            SqlParameter paramComprobacion  = new SqlParameter();
            paramComprobacion.Direction     = ParameterDirection.Output;
            paramComprobacion.SqlDbType     = SqlDbType.Bit;
            paramComprobacion.ParameterName = "@Validation";
            sqlCommand.Parameters.Add(paramComprobacion);

            connection.Connect();
            sqlCommand.ExecuteNonQuery();
            connection.Disconnect();
            return bool.Parse(sqlCommand.Parameters["@Validation"].Value.ToString());
        }
    }
}
