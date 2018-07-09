using Data;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Business.Logic
{
    public class LowerNodeData
    {
        public LowerNode FillData(LowerNode lowerNode, string storedProcedure)
        {
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

            SqlParameter paramNodoInferior     = new SqlParameter();
            paramNodoInferior.SqlDbType        = SqlDbType.NVarChar;
            paramNodoInferior.ParameterName    = "@NodoInferior";
            paramNodoInferior.Value            = lowerNode.NodoInferior;
            sqlCommand.Parameters.Add(paramNodoInferior);
            
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
                    lowerNode.Cantidad          = Convert.ToInt16(reader["Cantidad"].ToString());
                    lowerNode.NombreNivel       = reader["NombreNivel"].ToString();
                    lowerNode.RecaudadoNivel1   = Convert.ToDecimal(reader["RecaudadoNivel1"].ToString());
                    lowerNode.RecaudadoNivel2   = Convert.ToDecimal(reader["RecaudadoNivel2"].ToString());
                    lowerNode.RecaudadoNivel3   = Convert.ToDecimal(reader["RecaudadoNivel3"].ToString());
                }
            }
            
            connection.Disconnect();
            return lowerNode;
        }
    }
}
