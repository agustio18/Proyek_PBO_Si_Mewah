using Npgsql;

namespace SiMewah.Data
{
    public static class DatabaseConnection
    {
        private static readonly string connectionString =
            "Host=localhost;" +
            "Port=5432;" +
            "Database=SiMewah;" +
            "Username=postgres;" +
            "Password=Agustio1085";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}