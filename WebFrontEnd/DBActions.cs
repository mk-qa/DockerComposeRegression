using System;
using Npgsql;

namespace WebFrontEnd
{
    public static class DbActions
    {
        
        public static string GetDbVersion()
        {
            var cs = $"Host=db;Username=postgres;Password=postgres;Database=postgres";
            var con = new NpgsqlConnection(cs);
            con.Open();
            var cmd = new NpgsqlCommand("SELECT version()", con);
            return cmd.ExecuteScalar()?.ToString();
        }
        
    }
}