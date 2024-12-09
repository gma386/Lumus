using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumus.database
{
    public class Database
    {

        private readonly string _connectionString;

        public Database()
        { 
            _connectionString = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=lumusdb";
        }

        public NpgsqlConnection OpenConnection()
        {
            var connection = new NpgsqlConnection(_connectionString);
            connection.Open();
            return connection;

        }

        public DataTable ExecuteQuery(string query, Dictionary<string, object>? parameters = null)
        {
            using (var conn = OpenConnection())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        var tabela = new DataTable();
                        adapter.Fill(tabela);
                        return tabela;
                    }
                }
            }
        }

        public DataTable GetAll(string tableName)
        {
            string query = $"SELECT * FROM {tableName}";
            return ExecuteQuery(query);
        }

    }
}
