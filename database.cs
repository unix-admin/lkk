using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace LKK
{
    class Database
    {
        private SQLiteConnection connection;

        public Database()
        {
            string dir = Directory.GetCurrentDirectory();
            connection = new SQLiteConnection("Data Source=" + dir + "\\database\\database.db;Version=3;New=True;");
        }

        private void connect()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        private void disconnect()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public void createDatabase()
        {
            connect();
            SQLiteCommand create = new SQLiteCommand();
            create.Connection = connection;
            create.CommandText = "CREATE TABLE doctros (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, fio  VARCHAR(50))";
            create.ExecuteNonQuery();
            disconnect();

        }
    }
}
