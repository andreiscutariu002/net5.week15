namespace Users.Data
{
    using System.Data.SqlClient;

    public static class ConnectionManager
    {
        // TODO - keep in configuration file
        private const string ConnectionString = "Data Source=.; Initial Catalog=Week15;Integrated Security=True;";

        private static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            if (connection != null)
            {
                return connection;
            }

            connection = new SqlConnection
            {
                ConnectionString = ConnectionString
            };

            connection.Open();

            return connection;
        }
    }
}
