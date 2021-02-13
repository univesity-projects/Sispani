using Npgsql;
using System;
using System.Windows;

namespace Sispani.Model.DAO
{
    public static class DAO
    {
        private static readonly string _serverName = "127.0.0.1";
        private static readonly string _port = "5432";
        private static readonly string _userName = "postgres";
        private static readonly string _password = "123456";
        private static readonly string _databaseName = "sispani";
        public static NpgsqlConnection PgsqlConnection { get; set; } = null;
        public static string ConnString { get; set; } = null;

        static DAO()
        {
            ConnString = string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                       _serverName, _port, _userName, _password, _databaseName);
        }
    }
}
