using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Business.Logic
{
    public class PrincipalUserData
    {
        public PrincipalUser FillData(PrincipalUser principalUser)
        {
            string storedProcedure  = "Negocio_GetData_Principal_User";
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlDataAdapter sqlDataAdapter   = new SqlDataAdapter();

            SqlParameter paramIdUsuario     = new SqlParameter();
            paramIdUsuario.SqlDbType        = SqlDbType.NVarChar;
            paramIdUsuario.ParameterName    = "@IdUsuario";
            paramIdUsuario.Value            = principalUser.IdUsuario;
            sqlCommand.Parameters.Add(paramIdUsuario);
            
            SqlParameter paramIdCategoria   = new SqlParameter();
            paramIdCategoria.SqlDbType      = SqlDbType.SmallInt;
            paramIdCategoria.ParameterName  = "@IdCategoria";
            paramIdCategoria.Value          = principalUser.IdCategoria;
            sqlCommand.Parameters.Add(paramIdCategoria);
            
            connection.Connect();

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    principalUser.Nombres           = reader["Nombres"].ToString();
                    principalUser.Apellidos         = reader["Apellidos"].ToString();
                    principalUser.NombreCategoria   = reader["NombreCategoria"].ToString();
                    principalUser.NombreNivel       = reader["NombreNivel"].ToString();
                    principalUser.IdNivel           = Convert.ToInt16(reader["IdNivel"].ToString());
                }
            }
            
            connection.Disconnect();
            return principalUser;
        }
    }
}
