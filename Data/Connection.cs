using System;
using System.Data.SqlClient;

namespace Data
{
    public class Connection
    {
        public SqlConnection connectionString = new SqlConnection("data source=localhost\\MSSQLSERVER01;initial catalog=mundodeluz;user id=sa;password=1qaz2wsxM@123;MultipleActiveResultSets=True;");

        public void Connect()
        {
            try
            {
                connectionString.Open();
            }
            catch (Exception ex)
            {
                
            }
        }
        public void Disconnect()
        {
            try
            {
                connectionString.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
