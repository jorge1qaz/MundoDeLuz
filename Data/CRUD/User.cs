using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.CRUD
{
    
    public class User: Usuarios
    {
        public Int16 IdCategoria { get; set; }

        public bool FullUser(string storedProcedure)
        {
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter paramIdUsuario     = new SqlParameter();
            paramIdUsuario.SqlDbType        = SqlDbType.NVarChar;
            paramIdUsuario.ParameterName    = "@IdUsuario";
            paramIdUsuario.Value            = IdUsuario;
            sqlCommand.Parameters.Add(paramIdUsuario);

            SqlParameter paramContrasenia   = new SqlParameter();
            paramContrasenia.SqlDbType      = SqlDbType.NVarChar;
            paramContrasenia.ParameterName  = "@Contrasenia";
            paramContrasenia.Value          = Contrasenia;
            sqlCommand.Parameters.Add(paramContrasenia);

            SqlParameter paramNombres       = new SqlParameter();
            paramNombres.SqlDbType          = SqlDbType.NVarChar;
            paramNombres.ParameterName      = "@Nombres";
            paramNombres.Value              = Nombres;
            sqlCommand.Parameters.Add(paramNombres);

            SqlParameter paramApellidos     = new SqlParameter();
            paramApellidos.SqlDbType        = SqlDbType.NVarChar;
            paramApellidos.ParameterName    = "@Apellidos";
            paramApellidos.Value            = Apellidos;
            sqlCommand.Parameters.Add(paramApellidos);

            SqlParameter paramNumeroTelefonico  = new SqlParameter();
            paramNumeroTelefonico.SqlDbType     = SqlDbType.NVarChar;
            paramNumeroTelefonico.ParameterName = "@NumeroTelefonico";
            paramNumeroTelefonico.Value         = NumeroTelefonico;
            sqlCommand.Parameters.Add(paramNumeroTelefonico);

            SqlParameter paramIdentificacion    = new SqlParameter();
            paramIdentificacion.SqlDbType       = SqlDbType.NVarChar;
            paramIdentificacion.ParameterName   = "@Identificacion";
            paramIdentificacion.Value           = Identificacion;
            sqlCommand.Parameters.Add(paramIdentificacion);

            SqlParameter paramIdBanco       = new SqlParameter();
            paramIdBanco.SqlDbType          = SqlDbType.SmallInt;
            paramIdBanco.ParameterName      = "@IdBanco";
            paramIdBanco.Value              = IdBanco;
            sqlCommand.Parameters.Add(paramIdBanco);

            SqlParameter paramCuentaBancaria    = new SqlParameter();
            paramCuentaBancaria.SqlDbType       = SqlDbType.NVarChar;
            paramCuentaBancaria.ParameterName   = "@CuentaBancaria";
            paramCuentaBancaria.Value           = CuentaBancaria;
            sqlCommand.Parameters.Add(paramCuentaBancaria);

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

        public bool AuthenticateUser()
        {
            string storedProcedure  = "Gen_AuthenticateUser";
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter paramIdUsuario     = new SqlParameter();
            paramIdUsuario.SqlDbType        = SqlDbType.NVarChar;
            paramIdUsuario.ParameterName    = "@IdUsuario";
            paramIdUsuario.Value            = IdUsuario;
            sqlCommand.Parameters.Add(paramIdUsuario);

            SqlParameter paramContrasenia   = new SqlParameter();
            paramContrasenia.SqlDbType      = SqlDbType.NVarChar;
            paramContrasenia.ParameterName  = "@Contrasenia";
            paramContrasenia.Value          = Contrasenia;
            sqlCommand.Parameters.Add(paramContrasenia);

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

        public List<string> GetData_PrincipalUser()
        {
            string storedProcedure  = "Negocio_GetData_Principal_User";
            List<string> result     = new List<string>();
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlDataAdapter sqlDataAdapter   = new SqlDataAdapter();

            SqlParameter paramIdUsuario     = new SqlParameter();
            paramIdUsuario.SqlDbType        = SqlDbType.NVarChar;
            paramIdUsuario.ParameterName    = "@IdUsuario";
            paramIdUsuario.Value            = IdUsuario;
            sqlCommand.Parameters.Add(paramIdUsuario);
            
            SqlParameter paramIdCategoria   = new SqlParameter();
            paramIdCategoria.SqlDbType      = SqlDbType.SmallInt;
            paramIdCategoria.ParameterName  = "@IdCategoria";
            paramIdCategoria.Value          = IdCategoria;
            sqlCommand.Parameters.Add(paramIdCategoria);
            
            connection.Connect();

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.Add(reader.GetString(0).ToString());
                    result.Add(reader.GetString(1).ToString());
                    result.Add(reader.GetString(2).ToString());
                    result.Add(reader.GetString(3).ToString());
                }
            }
            
            connection.Disconnect();
            return result;
        }
    }
}
