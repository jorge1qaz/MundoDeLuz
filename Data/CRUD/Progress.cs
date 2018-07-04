using System.Data;
using System.Data.SqlClient;

namespace Data.CRUD
{
    public class Progress: Progresos
    {
        public bool CreateProgress()
        {
            string storedProcedure  = "Negocio_Create_Progress";
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter paramNodoSuperior  = new SqlParameter();
            paramNodoSuperior.SqlDbType     = SqlDbType.NVarChar;
            paramNodoSuperior.ParameterName = "@NodoSuperior";
            paramNodoSuperior.Value         = NodoSuperior;
            sqlCommand.Parameters.Add(paramNodoSuperior);

            SqlParameter paramNodoInferior  = new SqlParameter();
            paramNodoInferior.SqlDbType     = SqlDbType.NVarChar;
            paramNodoInferior.ParameterName = "@NodoInferior";
            paramNodoInferior.Value         = NodoInferior;
            sqlCommand.Parameters.Add(paramNodoInferior);

            SqlParameter paramIdCategoria   = new SqlParameter();
            paramIdCategoria.SqlDbType      = SqlDbType.SmallInt;
            paramIdCategoria.ParameterName  = "@IdCategoria";
            paramIdCategoria.Value          = IdCategoria;
            sqlCommand.Parameters.Add(paramIdCategoria);

            SqlParameter paramAprobacion    = new SqlParameter();
            paramAprobacion.SqlDbType       = SqlDbType.Bit;
            paramAprobacion.ParameterName   = "@Aprobacion";
            paramAprobacion.Value           = Aprobacion;
            sqlCommand.Parameters.Add(paramAprobacion);

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
