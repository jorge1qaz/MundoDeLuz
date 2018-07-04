using System.Data;
using System.Data.SqlClient;

namespace Data.CRUD
{
    public class Category: Categorias
    {
        public bool UpdateCategory()
        {
            string storedProcedure  = "Gen_Update_Category";
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter paramIdCategoria   = new SqlParameter();
            paramIdCategoria.SqlDbType      = SqlDbType.SmallInt;
            paramIdCategoria.ParameterName  = "@IdCategoria";
            paramIdCategoria.Value          = IdCategoria;
            sqlCommand.Parameters.Add(paramIdCategoria);

            SqlParameter paramNombreCategoria   = new SqlParameter();
            paramNombreCategoria.SqlDbType      = SqlDbType.NVarChar;
            paramNombreCategoria.ParameterName  = "@NombreCategoria";
            paramNombreCategoria.Value          = NombreCategoria;
            sqlCommand.Parameters.Add(paramNombreCategoria);

            SqlParameter paramMonto     = new SqlParameter();
            paramMonto.SqlDbType        = SqlDbType.Decimal;
            paramMonto.ParameterName    = "@Monto";
            paramMonto.Value            = Monto;
            sqlCommand.Parameters.Add(paramMonto);

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
