using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace LKK
{
    class Database
    {
        public struct lkkData
        {
            
            public string date;
            public string number;
            public int departmentID;
            public int doctorID;
            public string fio;
            public string birth;
            public int age;
            public int regionID;
            public int townID;
            public string address;
            public string addressWork;
            public string position;
            public string mkbCode;
            public string diagnose;
            public string lkk;
            public string msek;
            public string addition;
            public string sex;
            public string status;
        };
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
            create.CommandText = "CREATE TABLE doctors (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, fio VARCHAR (50));" +
                                 "CREATE TABLE diagnosis (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, codeMKB VARCHAR(10), title  VARCHAR(100));" +
                                 "CREATE TABLE license (organsation  VARCHAR(100), department VARCHAR(100), lkk VARCHAR(100),serial VARCHAR(50));" +                                 
                                 "CREATE TABLE lkk (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, data DATE, number VARCHAR(20)," +
                                 " departmentID INTEGER, doctorID INTEGER, FIO VARCHAR(100), birth INTEGER, age INTEGER, regionID INTEGER," +
                                 " townID INTEGER, address VARCHAR(200), addressWork VARCHAR(200), position VARCHAR(200), mkbCode VARCHAR(20), diagnose VARCHAR(2000), " +
                                 " lkk VARCHAR(2000), msek VARCHAR(2000), addition VARCHAR(2000), sex CHAR(2), status INTEGER);" +
                                 "CREATE TABLE members (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, fio VARCHAR(100), active BOOLEAN, head BOOLEAN);" +
                                 "CREATE TABLE departments(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, title VARCHAR(50));" +
                                 "CREATE TABLE regions (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, title  VARCHAR(50));" +
                                 "CREATE TABLE towns (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, type VARCHAR(5), town VARCHAR(100), regionID INTEGER);" +
                                 "CREATE TABLE inferenceLKK (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, title VARCHAR(1000));"+
                                 "CREATE TABLE mkb (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, idDiagnose INTEGER, subCode INTEGER(10), title INTEGER(50));";
            create.ExecuteNonQuery();
            
            disconnect();
        }
       public DataSet getData()
        {
            DataSet lkkData = new DataSet();
            lkkData.Tables.Add("departments");
            lkkData.Tables.Add("regions");
            lkkData.Tables.Add("doctors");
            SQLiteDataAdapter data = new SQLiteDataAdapter();
            SQLiteCommand selectData = new SQLiteCommand();
            selectData.Connection = connection;
            selectData.CommandText = "SELECT title FROM departments";
            data.SelectCommand = selectData;
            connect();
            data.Fill(lkkData.Tables["departments"]);
            selectData.CommandText = "SELECT title FROM regions";
            data.Fill(lkkData.Tables["regions"]);
            selectData.CommandText = "SELECT fio FROM doctors ORDER BY fio ASC";
            data.Fill(lkkData.Tables["doctors"]);
            lkkData.Tables["departments"].Rows.Add();
            lkkData.Tables["regions"].Rows.Add();
            lkkData.Tables["doctors"].Rows.Add();
            disconnect();           
            return lkkData;
        }
       public DataTable getTown(string regionName)
       {
           DataTable towns = new DataTable();
           SQLiteDataAdapter data = new SQLiteDataAdapter();
           SQLiteCommand selectData = new SQLiteCommand();
           selectData.Connection = connection;
           selectData.CommandText = "SELECT towns.type || '.' ||towns.town AS town FROM towns WHERE towns.regionID=(SELECT id FROM regions WHERE regions.title=:regionName)";
           selectData.Parameters.Add(":regionName", DbType.String);
           selectData.Parameters[":regionName"].Value = regionName;           
           data.SelectCommand = selectData;
           connect();
           data.Fill(towns);
           disconnect();
           return towns;
       }
       public DataTable getDoctors() 
       {
           DataTable doctors = new DataTable();
           SQLiteDataAdapter data = new SQLiteDataAdapter();
           SQLiteCommand selectData = new SQLiteCommand();
           selectData.Connection = connection;
           selectData.CommandText = "SELECT fio FROM doctors";
           data.SelectCommand = selectData;
           connect();
           data.Fill(doctors);
           disconnect();
           return doctors;
       }

       public DataTable getDiagnose()
       {
           DataTable diagnose = new DataTable();
           SQLiteDataAdapter data = new SQLiteDataAdapter();
           SQLiteCommand selectData = new SQLiteCommand();
           selectData.Connection = connection;
           selectData.CommandText = "SELECT title FROM diagnose";
           data.SelectCommand = selectData;
           connect();
           data.Fill(diagnose);
           disconnect();
           return diagnose;
       }
    }
}
