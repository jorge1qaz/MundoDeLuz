using System;
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



        public bool DeleteProgress()
        {
            string storedProcedure  = "Negocio_Delete_Progress";
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
            
            SqlParameter paramIdProgreso    = new SqlParameter();
            paramIdProgreso.SqlDbType       = SqlDbType.Int;
            paramIdProgreso.ParameterName   = "@IdProgreso";
            paramIdProgreso.Value           = IdProgreso;
            sqlCommand.Parameters.Add(paramIdProgreso);

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

        public bool UpdateProgress()
        {
            string storedProcedure  = "Negocio_Approve_Progress";
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;
            
            SqlParameter paramIdProgreso    = new SqlParameter();
            paramIdProgreso.SqlDbType       = SqlDbType.Int;
            paramIdProgreso.ParameterName   = "@IdProgreso";
            paramIdProgreso.Value           = IdProgreso;
            sqlCommand.Parameters.Add(paramIdProgreso);

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

        public Progresos Read(string idProgreso)
        {
            Progresos progresos = new Progresos();
            string storedProcedure  = "Negocio_GetData_Progress";
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlDataAdapter sqlDataAdapter   = new SqlDataAdapter();

            SqlParameter parameter     = new SqlParameter();
            parameter.SqlDbType        = SqlDbType.Int;
            parameter.ParameterName    = "@IdProgreso";
            parameter.Value            = idProgreso;
            sqlCommand.Parameters.Add(parameter);
            
            connection.Connect();

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    progresos.NodoSuperior  = reader["NodoSuperior"].ToString();
                    progresos.NodoInferior  = reader["NodoInferior"].ToString();
                    progresos.IdCategoria   = Convert.ToInt16(reader["IdCategoria"].ToString());
                }
            }
            
            connection.Disconnect();
            return progresos;
        }
    }
}
