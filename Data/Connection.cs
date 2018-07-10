using System;
using System.Data.SqlClient;

namespace Data
{
    public class Connection
    {
        //public SqlConnection connectionString = new SqlConnection("data source=localhost\\MSSQLSERVER01;initial catalog=mundodeluz;user id=sa;password=1qaz2wsxM@123;MultipleActiveResultSets=True;");
        public SqlConnection connectionString = new SqlConnection("data source=TOSHIBA;initial catalog=mundodeluz;user id=sa;password=1qaz2wsxM@123;MultipleActiveResultSets=True;");
        //Server=tcp:servidornuevo.database.windows.net,1433;Initial Catalog=mundodeluz;Persist Security Info=False;User ID=jorgeluis;Password=1qaz2wsxM@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
        //public SqlConnection connectionString = new SqlConnection("Server = tcp:servidornuevo.database.windows.net, 1433; Initial Catalog = mundodeluz; Persist Security Info=False;User ID = jorgeluis; Password=1qaz2wsxM@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");

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
