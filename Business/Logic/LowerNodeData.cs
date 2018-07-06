using Data;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Business.Logic
{
    public class LowerNodeData
    {
        public LowerNode FillData(LowerNode lowerNode)
        {
            string storedProcedure  = "Negocio_GetData_Details_ByIdUser";
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlDataAdapter sqlDataAdapter   = new SqlDataAdapter();

            SqlParameter paramIdUsuario     = new SqlParameter();
            paramIdUsuario.SqlDbType        = SqlDbType.NVarChar;
            paramIdUsuario.ParameterName    = "@NodoSuperior";
            paramIdUsuario.Value            = lowerNode.NodoSuperior;
            sqlCommand.Parameters.Add(paramIdUsuario);
            
            SqlParameter paramIdCategoria   = new SqlParameter();
            paramIdCategoria.SqlDbType      = SqlDbType.SmallInt;
            paramIdCategoria.ParameterName  = "@IdCategoria";
            paramIdCategoria.Value          = lowerNode.IdCategoria;
            sqlCommand.Parameters.Add(paramIdCategoria);
            
            connection.Connect();

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    lowerNode.Nombres           = reader["Nombres"].ToString();
                    lowerNode.Apellidos         = reader["Apellidos"].ToString();
                    lowerNode.NombreNivel       = reader["NombreNivel"].ToString();
                    lowerNode.DineroAcumulado   = Convert.ToDecimal(reader["DineroAcumulado"].ToString());
                    lowerNode.Cantidad          = Convert.ToInt16(reader["Cantidad"].ToString());
                }
            }
            
            connection.Disconnect();
            return lowerNode;
        }
    }
}
