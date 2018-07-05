using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class ReadGeneralData
    {
        Connection Connection = new Connection();

        public DataTable GetDataTable(string storedProcedure)
        {
            DataTable dataTable             = new DataTable();
            Connection connection           = new Connection();
            SqlCommand sqlCommand           = new SqlCommand();
            SqlDataAdapter sqlDataAdapter   = new SqlDataAdapter();
            sqlCommand.CommandText          = storedProcedure;
            sqlCommand.CommandType          = CommandType.StoredProcedure;
            sqlCommand.Connection           = connection.connectionString;
            sqlDataAdapter.SelectCommand    = sqlCommand;
            connection.Connect();
            sqlDataAdapter.Fill(dataTable);
            connection.Disconnect();

            return dataTable;
        }

        public string GetSingleValueSTRINGById(string storedProcedure, string nameColumn, Int16 id)
        {
            string value = string.Empty;
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter parameter  = new SqlParameter();
            parameter.SqlDbType     = SqlDbType.SmallInt; // Tipo de dato smallint
            parameter.ParameterName = nameColumn;
            parameter.Value         = id;
            sqlCommand.Parameters.Add(parameter);
            
            connection.Connect();
            value   = (string)sqlCommand.ExecuteScalar(); // Devuelve el valor convertido explícitamente a string
            connection.Disconnect();

            return value;
        }

        public int GetSingleValueINTById(string storedProcedure, string nameColumn, string id)
        {
            int value;
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter parameter  = new SqlParameter();
            parameter.SqlDbType     = SqlDbType.NVarChar; // Tipo de dato NVarChar
            parameter.ParameterName = nameColumn;
            parameter.Value         = id;
            sqlCommand.Parameters.Add(parameter);
            
            connection.Connect();
            value   = (int)sqlCommand.ExecuteScalar(); // Devuelve el valor convertido explícitamente a string
            connection.Disconnect();

            return value;
        }

        public decimal GetSingleValueDECIMAL_ByTwoIds(string storedProcedure, string nameColumn1, string id1, string nameColumn2, Int16 id2)
        {
            decimal value;
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter parameter1     = new SqlParameter();
            parameter1.SqlDbType        = SqlDbType.NVarChar;
            parameter1.ParameterName    = nameColumn1;
            parameter1.Value            = id1;
            sqlCommand.Parameters.Add(parameter1);

            SqlParameter parameter2     = new SqlParameter();
            parameter2.SqlDbType        = SqlDbType.SmallInt;
            parameter2.ParameterName    = nameColumn2;
            parameter2.Value            = id2;
            sqlCommand.Parameters.Add(parameter2);
            
            connection.Connect();
            value   = (decimal)sqlCommand.ExecuteScalar(); // Devuelve el valor convertido explícitamente a string
            connection.Disconnect();

            return value;
        }

        public List<string> GetListValuesById(string storedProcedure, string nameColumn, string id)
        {
            List<string> values = new List<string>();
            Connection connection   = new Connection();
            SqlCommand sqlCommand   = new SqlCommand();
            sqlCommand.CommandText  = storedProcedure;
            sqlCommand.CommandType  = CommandType.StoredProcedure;
            sqlCommand.Connection   = connection.connectionString;

            SqlParameter parameter  = new SqlParameter();
            parameter.SqlDbType     = SqlDbType.NVarChar; // Tipo de dato NVarChar
            parameter.ParameterName = nameColumn;
            parameter.Value         = id;
            sqlCommand.Parameters.Add(parameter);
            
            connection.Connect();

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                    values.Add(reader.GetString(0));
            }
            
            connection.Disconnect();

            return values;
        }
    }
}
