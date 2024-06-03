using Npgsql;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace Destiny 
{
    public class PostgreSqlDatabase : IDataAccess 
    {

        const string _connectionString = "Host=localhost;Username=dev;Password=dev;Database=destiny";

        public PostgreSqlDatabase()
        {
            using NpgsqlConnection connection = new NpgsqlConnection(_connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connected to PostgreSQL database");

                using NpgsqlCommand cmd = new NpgsqlCommand("SELECT version()", connection);

                string? version = cmd.ExecuteScalar().ToString();
                Console.WriteLine($"PostgreSQL version: {version}");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public string GetVersion() 
        {

            using NpgsqlConnection connection = new NpgsqlConnection(_connectionString);
                connection.Open();
                using NpgsqlCommand cmd = new NpgsqlCommand("SELECT version()", connection);
                string? version = cmd.ExecuteScalar().ToString();

                return version;

        }
    }

}