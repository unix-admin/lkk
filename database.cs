﻿using System;
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
            public string department;
            public string doctor;
            public string fio;
            public string birth;
            public string age;
            public string region;
            public string town;
            public string address;
            public string addressWork;
            public string position;
          //  public string mkbCode;
            public string diagnose;
            public string lkk;
            public string msek;
            public string addition;
            public string sex;
            public string status;
        };
        public enum typesData
        {
            department = 0
           ,doctor
           ,region
           ,town
           ,diagnose
           ,lkk
        }
        private SQLiteConnection connection;
        private SQLiteCommand selectSQLCommand = new SQLiteCommand();
        private SQLiteCommand insertSQLCommand = new SQLiteCommand();
        private SQLiteCommand updateSQLCommand = new SQLiteCommand();
        public Database()
        {
            string dir = Directory.GetCurrentDirectory();
            connection = new SQLiteConnection("Data Source=" + dir + "\\database\\database.db;Version=3;New=True;");
            insertSQLCommand.Connection = connection;
            selectSQLCommand.Connection = connection;
            updateSQLCommand.Connection = connection;

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
           selectData.CommandText = "SELECT codeMKB, title FROM diagnosis";
           data.SelectCommand = selectData;
           connect();
           data.Fill(diagnose);
           disconnect();
           return diagnose;
       }
       public DataTable getLKK()
       {
           DataTable LKK = new DataTable();
           SQLiteDataAdapter data = new SQLiteDataAdapter();
           SQLiteCommand selectData = new SQLiteCommand();
           selectData.Connection = connection;
           selectData.CommandText = "SELECT title FROM inferenceLKK ";
           data.SelectCommand = selectData;
           connect();
           data.Fill(LKK);
           disconnect();
           return LKK;
       }
       
       private SQLiteDataReader reader;
       private string getID(string parameter, typesData type)
       {
           string ID;
           ID = "";
           switch (type)
           {
               case typesData.department:
                   selectSQLCommand.CommandText = "SELECT id FROM departments WHERE title=:parameter";                    
                   break;
               case typesData.doctor:
                   selectSQLCommand.CommandText = "SELECT id FROM doctors WHERE fio=:parameter";
                   break;
               case typesData.region:
                   selectSQLCommand.CommandText = "SELECT id FROM regions WHERE title=:parameter";
                   break;
           }
           selectSQLCommand.Parameters.Add(":parameter", DbType.String);
           selectSQLCommand.Parameters[":parameter"].Value = parameter;                      
           connect();
           reader = selectSQLCommand.ExecuteReader();
           if (reader.Read())
           {
               ID = reader[0].ToString();
           }
           reader.Close();
           reader = null;
           disconnect();
           return ID;
       }
       private string getID(string regionID, string town)
       {
           string ID;
           ID = "";
           selectSQLCommand.CommandText = "SELECT towns.id FROM towns WHERE towns.regionID=:regionID AND towns.type || '.' ||towns.town =:town";
           selectSQLCommand.Parameters.Add(":regionID", DbType.String);
           selectSQLCommand.Parameters[":regionID"].Value = regionID;
           selectSQLCommand.Parameters.Add(":town", DbType.String);
           selectSQLCommand.Parameters[":town"].Value = town;
           connect();
           reader = selectSQLCommand.ExecuteReader();
           if (reader.Read())
           {
               ID = reader[0].ToString();
           }
           reader.Close();
           reader = null;
           disconnect();
           return ID;
       }

       public void insertData(lkkData data)
       {
           insertSQLCommand.CommandText = "INSERT INTO LKK (data,number,departmentID,doctorID,FIO,birth,age,regionID,townID," +
               "address,addressWork,position,diagnose,lkk,msek,addition,sex,status) VALUES(:data,:number,:departmentID," +
               ":doctorID,:FIO,:birth,:age,:regionID,:townID,:address,:addressWork,:position,:diagnose,:lkk,:msek,"+
               ":addition,:sex,:status)";
           insertSQLCommand.Parameters.Add(":data", DbType.String);
           insertSQLCommand.Parameters[":data"].Value = data.date;
           insertSQLCommand.Parameters.Add(":number", DbType.String);
           insertSQLCommand.Parameters[":number"].Value = data.number;
           insertSQLCommand.Parameters.Add(":departmentID", DbType.String);
           insertSQLCommand.Parameters[":departmentID"].Value = getID(data.department, typesData.department);
           insertSQLCommand.Parameters.Add(":doctorID", DbType.String);
           insertSQLCommand.Parameters[":doctorID"].Value = getID(data.doctor, typesData.doctor);
           insertSQLCommand.Parameters.Add(":FIO", DbType.String);
           insertSQLCommand.Parameters[":FIO"].Value = data.fio;
           insertSQLCommand.Parameters.Add(":birth", DbType.String);
           insertSQLCommand.Parameters[":birth"].Value = data.birth;
           insertSQLCommand.Parameters.Add(":age", DbType.String);
           insertSQLCommand.Parameters[":age"].Value = data.age;
           insertSQLCommand.Parameters.Add(":regionID", DbType.String);
           insertSQLCommand.Parameters[":regionID"].Value = getID(data.region, typesData.region);
           insertSQLCommand.Parameters.Add(":townID", DbType.String);
           insertSQLCommand.Parameters[":townID"].Value = getID(insertSQLCommand.Parameters[":regionID"].Value.ToString(), data.town);
           insertSQLCommand.Parameters.Add(":address", DbType.String);
           insertSQLCommand.Parameters[":address"].Value = data.address;
           insertSQLCommand.Parameters.Add(":addressWork", DbType.String);
           insertSQLCommand.Parameters[":addressWork"].Value = data.addressWork;
           insertSQLCommand.Parameters.Add(":position", DbType.String);
           insertSQLCommand.Parameters[":position"].Value = data.position;
           insertSQLCommand.Parameters.Add(":diagnose", DbType.String);
           insertSQLCommand.Parameters[":diagnose"].Value = data.diagnose;
           insertSQLCommand.Parameters.Add(":lkk", DbType.String);
           insertSQLCommand.Parameters[":lkk"].Value = data.lkk;
           insertSQLCommand.Parameters.Add(":msek", DbType.String);
           insertSQLCommand.Parameters[":msek"].Value = data.msek;
           insertSQLCommand.Parameters.Add(":addition", DbType.String);
           insertSQLCommand.Parameters[":addition"].Value = data.addition;
           insertSQLCommand.Parameters.Add(":sex", DbType.String);
           insertSQLCommand.Parameters[":sex"].Value = data.sex;
           insertSQLCommand.Parameters.Add(":status", DbType.String);
           insertSQLCommand.Parameters[":status"].Value = data.status;
           connect();
           insertSQLCommand.ExecuteNonQuery();
           disconnect();
       }
       public void addData(typesData typeData, string value)
       {
           switch (typeData)
           {
               case typesData.department:
                   insertSQLCommand.CommandText = "INSERT INTO departments (title) VALUES(:value)";           
                   break;
               case typesData.diagnose:
                   insertSQLCommand.CommandText = "INSERT INTO diagnosis (title) VALUES(:value)";           
                   break;
               case typesData.doctor:
                   insertSQLCommand.CommandText = "INSERT INTO doctors (fio) VALUES(:value)";           
                   break;
               case typesData.lkk:
                   insertSQLCommand.CommandText = "INSERT INTO infedenceLKK (title) VALUES(:value)";           
                   break;
               case typesData.region:
                   insertSQLCommand.CommandText = "INSERT INTO regions (title) VALUES(:value)";           
                   break;
           }
           insertSQLCommand.Parameters.Add(":value", DbType.String);
           insertSQLCommand.Parameters[":value"].Value = value;
           connect();
           insertSQLCommand.ExecuteNonQuery();
           disconnect();
       }
       public void addTown(string type, string regionID, string value)
       {
           insertSQLCommand.CommandText = "INSERT INTO towns (type, regionID, title) VALUES(:type, :regionID, :title)";
           insertSQLCommand.Parameters.Add(":type", DbType.String);
           insertSQLCommand.Parameters[":type"].Value = type;
           insertSQLCommand.Parameters.Add(":regionID", DbType.String);
           insertSQLCommand.Parameters[":regionID"].Value = type;
           insertSQLCommand.Parameters.Add(":title", DbType.String);
           insertSQLCommand.Parameters[":title"].Value = type;
           connect();
           insertSQLCommand.ExecuteNonQuery();
           disconnect();
       }
       public void updateData(typesData typeData, string oldValue, string newValue)
       {
           switch (typeData)
           {
               case typesData.department:
                   updateSQLCommand.CommandText = "UPDATE departments SET title=:newValue WHERE title=oldValue";
                   break;
               case typesData.diagnose:
                   updateSQLCommand.CommandText = "UPDATE diagnosis SET title=:newValue WHERE title=oldValue";
                   break;
               case typesData.doctor:
                   updateSQLCommand.CommandText = "UPDATE doctors SET fio=:newValue WHERE fio=oldValue";
                   break;
               case typesData.lkk:
                   updateSQLCommand.CommandText = "UPDATE infedenceLKK SET title=:newValue WHERE title=oldValue";
                   break;
               case typesData.region:
                   updateSQLCommand.CommandText = "UPDATE regions SET title=:newValue WHERE title=oldValue";
                   break;
           }
           updateSQLCommand.Parameters.Add(":oldValue", DbType.String);
           updateSQLCommand.Parameters[":oldValue"].Value = newValue;
           updateSQLCommand.Parameters.Add(":newValue", DbType.String);
           updateSQLCommand.Parameters[":newValue"].Value = newValue;
           connect();
           updateSQLCommand.ExecuteNonQuery();
           disconnect();
       }
       public void updateData(string regionID, string oldType, string newType, string oldValue, string newValue)
       {
           updateSQLCommand.CommandText = "UPDATE towns SET title=:newValue, type=:newType WHERE type=:oldType "+
                                           " AND title=:oldValue AND regionID=:regionID ";
           updateSQLCommand.Parameters.Add(":oldValue", DbType.String);
           updateSQLCommand.Parameters[":oldValue"].Value = newValue;
           updateSQLCommand.Parameters.Add(":newValue", DbType.String);
           updateSQLCommand.Parameters[":newValue"].Value = newValue;
           updateSQLCommand.Parameters.Add(":newType", DbType.String);
           updateSQLCommand.Parameters[":newType"].Value = newType;
           updateSQLCommand.Parameters.Add(":oldType", DbType.String);
           updateSQLCommand.Parameters[":oldType"].Value = newType;
           updateSQLCommand.Parameters.Add(":regionID", DbType.String);
           updateSQLCommand.Parameters[":regionID"].Value = regionID;
           connect();
           updateSQLCommand.ExecuteNonQuery();
           disconnect();

       }
    }
}
