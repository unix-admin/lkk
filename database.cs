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
            public string mkbCode;
            public string diagnose;
            public string lkk;
            public string msek;
            public string addition;
            public string sex;
            public string status;
            public bool haveInvalidity;
            public string InvalidityDate;
            public string InvalidityLPZ;
        };

     
        public enum typesData
        {
            department = 0
           ,
            doctor
                ,
            region
                ,
            town
                ,
            diagnose
                ,
            lkk
                , lpz
        };

        private SQLiteConnection connection;
        private SQLiteCommand selectSQLCommand = new SQLiteCommand();
        private SQLiteCommand insertSQLCommand = new SQLiteCommand();
        private SQLiteCommand updateSQLCommand = new SQLiteCommand();
        private SQLiteCommand deleteSQLCommand = new SQLiteCommand();

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
            create.CommandText = "CREATE TABLE doctors (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, fio VARCHAR (50), deleted BOOLEAN DEFAULT false);" +
                                 "CREATE TABLE diagnosis (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, codeMKB VARCHAR(10), title  VARCHAR(100), isOrphan BOOLEAN, deleted BOOLEAN DEFAULT false);" +
                                 "CREATE TABLE license (organsation  VARCHAR(100), department VARCHAR(100), lkk VARCHAR(100),serial VARCHAR(50));" +                                 
                                 "CREATE TABLE lkk (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, data DATE, number VARCHAR(20)," +
                                 " departmentID INTEGER, doctorID INTEGER, FIO VARCHAR(100), birth INTEGER, age INTEGER, regionID INTEGER," +
                                 " townID INTEGER, address VARCHAR(200), addressWork VARCHAR(200), position VARCHAR(200), mkbCode VARCHAR(20), diagnose VARCHAR(2000), " +
                                 " lkk VARCHAR(2000), msek VARCHAR(2000), addition VARCHAR(2000), sex CHAR(2), status INTEGER, deleted BOOLEAN DEFAULT false);" +
                                 "CREATE TABLE members (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, fio VARCHAR(100), active BOOLEAN, head BOOLEAN, deleted BOOLEAN DEFAULT false);" +
                                 "CREATE TABLE departments(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, title VARCHAR(50), deleted BOOLEAN DEFAULT false);" +
                                 "CREATE TABLE regions (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, title  VARCHAR(50), deleted BOOLEAN DEFAULT false);" +
                                 "CREATE TABLE towns (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, type VARCHAR(5), town VARCHAR(100), regionID INTEGER, deleted BOOLEAN DEFAULT false);" +
                                 "CREATE TABLE inferenceLKK (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, title VARCHAR(1000), deleted BOOLEAN DEFAULT false);" +
                                 "CREATE TABLE mkb (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, idDiagnose INTEGER, subCode INTEGER(10), title INTEGER(50), deleted BOOLEAN DEFAULT false);"+
                                 "CREATE TABLE lpz (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, title  VARCHAR(255), deleted BOOLEAN DEFAULT false);";
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
            selectData.CommandText = "SELECT fio FROM doctors";
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
           selectData.CommandText = "SELECT towns.type || '.' ||towns.town AS town FROM towns WHERE towns.regionID=(SELECT id FROM regions WHERE regions.title=:regionName) AND towns.deleted='false'";
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
           selectData.CommandText = "SELECT fio FROM doctors WHERE doctors.deleted='false'";
           data.SelectCommand = selectData;
           connect();
           data.Fill(doctors);
           disconnect();
           return doctors;
       }

       public DataTable getMembersLkk()
       {
           DataTable members = new DataTable();
           SQLiteDataAdapter data = new SQLiteDataAdapter();
           SQLiteCommand selectData = new SQLiteCommand();           
           selectData.Connection = connection;
           selectData.CommandText = "SELECT id,fio,head FROM members WHERE members.active=1 ORDER BY members.head DESC";
           connect();          
           data.SelectCommand = selectData;           
           data.Fill(members);
           disconnect();
           return members;
       }

       private string getMembersLkkToInsert()
       {
           string members = null;
           DataTable membersLkk = getMembersLkk();
           
           for (int i = 0; i < membersLkk.Rows.Count; i++)
           {
               if (i == membersLkk.Rows.Count - 1)
                   members += membersLkk.Rows[i][0];
               else
                   members += membersLkk.Rows[i][0] + ",";
           }
           return members;
       }

       public DataTable getMemberLkkById(string id)
       {
           DataTable members = new DataTable();
           SQLiteDataAdapter data = new SQLiteDataAdapter();
           SQLiteCommand selectData = new SQLiteCommand();           
           selectData.Connection = connection;
           selectData.CommandText = "SELECT fio,head FROM members WHERE members.active=1 AND members.id=:id";
           selectData.Parameters.Add(":id", DbType.String);
           selectData.Parameters[":id"].Value = id;
           connect();
           data.SelectCommand = selectData;
           data.Fill(members);
           disconnect();
           return members;
       }

       public DataTable getDiagnose()
       {
           DataTable diagnose = new DataTable();
           SQLiteDataAdapter data = new SQLiteDataAdapter();
           SQLiteCommand selectData = new SQLiteCommand();
           selectData.Connection = connection;
           selectData.CommandText = "SELECT codeMKB, title AS diagnose FROM diagnosis WHERE deleted='false'";
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
           selectData.CommandText = "SELECT title FROM inferenceLKK WHERE inferenceLKK.deleted='false'";
           data.SelectCommand = selectData;
           connect();
           data.Fill(LKK);
           disconnect();
           return LKK;
       }
       public DataTable getDepartments()
       {
           DataTable departments = new DataTable();
           SQLiteDataAdapter data = new SQLiteDataAdapter();
           SQLiteCommand selectData = new SQLiteCommand();
           selectData.Connection = connection;
           selectData.CommandText = "SELECT title FROM departments WHERE departments.deleted='false'";
           data.SelectCommand = selectData;
           connect();
           data.Fill(departments);
           disconnect();
           return departments;
       }

       public DataTable getLPZ()
       {
           DataTable lpz = new DataTable();
           SQLiteDataAdapter data = new SQLiteDataAdapter();
           SQLiteCommand selectData = new SQLiteCommand();
           selectData.Connection = connection;
           selectData.CommandText = "SELECT title FROM lpz WHERE lpz.deleted='false'";
           data.SelectCommand = selectData;
           connect();
           data.Fill(lpz);
           disconnect();
           return lpz;
       }

       public DataTable getRegions()
       {
           DataTable regions = new DataTable();
           SQLiteDataAdapter data = new SQLiteDataAdapter();
           SQLiteCommand selectData = new SQLiteCommand();
           selectData.Connection = connection;
           selectData.CommandText = "SELECT title FROM regions WHERE regions.deleted='false'";
           data.SelectCommand = selectData;
           connect();
           data.Fill(regions);
           disconnect();
           return regions;
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
               case typesData.lpz:
                   selectSQLCommand.CommandText = "SELECT id FROM lpz WHERE title=:parameter";
                   break;
               case typesData.diagnose:
                   selectSQLCommand.CommandText = "SELECT codeMKB FROM diagnosis WHERE title=:parameter";
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

       public string insertData(lkkData data)
       {
           insertSQLCommand.CommandText = "INSERT INTO LKK (data,number,departmentID,doctorID,FIO,birth,age,regionID,townID," +
               "address,addressWork,position,mkbCode,diagnose,lkk,msek,addition,sex,status,invalidityDate,invalidityLpzID,haveInvalidity,comission) VALUES(:data,:number,:departmentID," +
               ":doctorID,:FIO,:birth,:age,:regionID,:townID,:address,:addressWork,:position,:mkbCode,:diagnose,:lkk,:msek," +
               ":addition,:sex,:status,:invalidityDate,:invalidityLpzID,:haveInvalidity,:comission)";
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
           insertSQLCommand.Parameters.Add(":mkbCode", DbType.String);
           insertSQLCommand.Parameters[":mkbCode"].Value = data.mkbCode;
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
           insertSQLCommand.Parameters.Add(":haveInvalidity", DbType.Boolean);
           insertSQLCommand.Parameters[":haveInvalidity"].Value = data.haveInvalidity;
           if (data.haveInvalidity)
           {
               insertSQLCommand.Parameters.Add(":invalidityDate", DbType.String);
               insertSQLCommand.Parameters[":invalidityDate"].Value = data.InvalidityDate;
               insertSQLCommand.Parameters.Add(":invalidityLpzID", DbType.String);
               insertSQLCommand.Parameters[":invalidityLpzID"].Value = getID(data.InvalidityLPZ, typesData.lpz);               
           }
           else 
           {
               insertSQLCommand.Parameters.Add(":invalidityDate", DbType.String);
               insertSQLCommand.Parameters[":invalidityDate"].Value = null;
               insertSQLCommand.Parameters.Add(":invalidityLpzID", DbType.String);
               insertSQLCommand.Parameters[":invalidityLpzID"].Value = null;               
           }
           insertSQLCommand.Parameters.Add(":comission", DbType.String);
           insertSQLCommand.Parameters[":comission"].Value = getMembersLkkToInsert();
           
           connect();
           insertSQLCommand.ExecuteNonQuery();
       //    insertSQLCommand.Transaction.Commit();
           disconnect();
           
           string id = null;
           SQLiteCommand selectData = new SQLiteCommand();
           selectData.Connection = connection;
           connect();
           selectData.CommandText = "SELECT id FROM lkk WHERE data=:date AND number=:number AND fio=:fio";
           selectData.Parameters.Add(":date", DbType.String);
           selectData.Parameters[":date"].Value = data.date;
           selectData.Parameters.Add(":number", DbType.String);
           selectData.Parameters[":number"].Value = data.number;
           selectData.Parameters.Add(":fio", DbType.String);
           selectData.Parameters[":fio"].Value = data.fio;
           SQLiteDataReader getlkkID;
           getlkkID = selectData.ExecuteReader();
           if (getlkkID.Read())
               id = getlkkID[0].ToString();
           disconnect();
           return id;
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
               case typesData.lpz:
                   insertSQLCommand.CommandText = "INSERT INTO lpz (title) VALUES(:value)";
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
                   updateSQLCommand.CommandText = "UPDATE departments SET title=:newValue WHERE title=:oldValue";
                   break;
               case typesData.diagnose:
                   updateSQLCommand.CommandText = "UPDATE diagnosis SET title=:newValue WHERE title=:oldValue";
                   break;
               case typesData.doctor:
                   updateSQLCommand.CommandText = "UPDATE doctors SET fio=:newValue WHERE fio=:oldValue";
                   break;
               case typesData.lkk:
                   updateSQLCommand.CommandText = "UPDATE infedenceLKK SET title=:newValue WHERE title=:oldValue";
                   break;
               case typesData.region:
                   updateSQLCommand.CommandText = "UPDATE regions SET title=:newValue WHERE title=:oldValue";
                   break;
           }
           updateSQLCommand.Parameters.Add(":oldValue", DbType.String);
           updateSQLCommand.Parameters[":oldValue"].Value = oldValue;
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
       public void deleteData(typesData typeData, string id) 
       {
           switch (typeData)
           {
               case typesData.department:
                   updateSQLCommand.CommandText = "SELECT count() FROM departments WHERE id=:id";
                   break;
               case typesData.diagnose:
                   updateSQLCommand.CommandText = "SELECT count() FROM diagnosis WHERE id=:id";
                   break;
               case typesData.doctor:
                   updateSQLCommand.CommandText = "SELECT count() FROM doctors WHERE id=:id";
                   break;
               case typesData.lkk:
                   updateSQLCommand.CommandText = "SELECT count() FROM lkk WHERE id=:id";
                   break;
               case typesData.region:
                   updateSQLCommand.CommandText = "SELECT count() FROM regions WHERE id=:id";
                   break;
               case typesData.town:
                   updateSQLCommand.CommandText = "SELECT count() FROM towns WHERE id=:id";
                   break;
           }
           connect();
           updateSQLCommand.Parameters.Add(":id", DbType.String);
           updateSQLCommand.Parameters[":id"].Value = id;
           reader = updateSQLCommand.ExecuteReader();
           int count=1;
           if (reader.Read())
           {
               count = Convert.ToInt32(reader[0].ToString());
           }
           reader.Close();
           reader = null;
           disconnect();
           if (count > 0)
               setDeleted(typeData, id);
           else
               realyDelete(typeData, id);

       }

        private void realyDelete(typesData typeData, string id)
        {
            switch (typeData)
            {
                case typesData.department:
                   deleteSQLCommand.CommandText = "DELETE FROM departments WHERE id=:id";
                    break;
                case typesData.diagnose:
                    deleteSQLCommand.CommandText = "DELETE FROM diagnosis WHERE id=:id";
                    break;
                case typesData.doctor:
                    deleteSQLCommand.CommandText = "DELETE FROM doctors WHERE id=:id";
                    break;
                case typesData.lkk:
                    deleteSQLCommand.CommandText = "DELETE FROM lkk WHERE id=:id";
                    break;
                case typesData.region:
                    deleteSQLCommand.CommandText = "DELETE FROM regions WHERE id=:id";
                    break;
                case typesData.town:
                    deleteSQLCommand.CommandText = "DELETE FROM towns WHERE id=:id";
                    break;
            }
            connect();
            deleteSQLCommand.Parameters.Add(":id", DbType.String);
            deleteSQLCommand.Parameters[":id"].Value = id;
            deleteSQLCommand.ExecuteNonQuery();
            disconnect();
        }

        private void setDeleted(typesData typeData, string id)
        {
            switch (typeData)
            {
                case typesData.department:
                    deleteSQLCommand.CommandText = "UPDATE departments SET deleted='true' WHERE id=:id";
                    break;
                case typesData.diagnose:
                    deleteSQLCommand.CommandText = "UPDATE diagnosis SET deleted='true' WHERE id=:id";
                    break;
                case typesData.doctor:
                    deleteSQLCommand.CommandText = "UPDATE doctors SET deleted='true' WHERE id=:id";
                    break;
                case typesData.lkk:
                    deleteSQLCommand.CommandText = "UPDATE lkk SET deleted='true' WHERE id=:id";
                    break;
                case typesData.region:
                    deleteSQLCommand.CommandText = "UPDATE regions SET deleted='true' WHERE id=:id";
                    break;
                case typesData.town:
                    deleteSQLCommand.CommandText = "UPDATE towns SET deleted='true' WHERE id=:id";
                    break;
            }
            connect();
            deleteSQLCommand.Parameters.Add(":id", DbType.String);
            deleteSQLCommand.Parameters[":id"].Value = id;
            deleteSQLCommand.ExecuteNonQuery();
            disconnect();
        }
        public DataSet getInfedenceLKK(string id)
        {
            DataSet infedence = new DataSet();
            SQLiteDataAdapter data = new SQLiteDataAdapter();
            
            infedence.Tables.Add("infedence");
            infedence.Tables.Add("head");
            infedence.Tables.Add("members");
            SQLiteCommand selectData = new SQLiteCommand();                        
            selectData.Connection = connection;
            selectData.CommandText = "SELECT * FROM infedenceView WHERE id=:id";           
            selectData.Parameters.Add(":id", DbType.String);
            selectData.Parameters[":id"].Value = id;
            data.SelectCommand = selectData;
            connect();
            data.Fill(infedence.Tables["infedence"]);
            data.SelectCommand = selectData;
            string[] comission = infedence.Tables["infedence"].Rows[0]["comission"].ToString().Split(',');
            string headLkk = comission[0];
            string membersLKK = null;
            for (int i = 1; i < comission.Length; i++)
            {
                if (i == comission.Length - 1)
                {
                    membersLKK += comission[i];
                }
                else 
                {
                    membersLKK += comission[i] + ",";
                }
            }            
            selectData.CommandText = "SELECT fio FROM members WHERE id IN (" + headLkk + ")";           
            data.Fill(infedence.Tables["head"]);
            selectData.CommandText = "SELECT fio FROM members WHERE id IN (" + membersLKK + ")";
            data.Fill(infedence.Tables["members"]);
            disconnect();
            return infedence;
        }

        public DataTable search(lkkSearchData data)
        {
            DataTable searchResult = new DataTable();
            SQLiteCommand selectData = new SQLiteCommand();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = selectData;
            selectData.Connection = connection;
            selectData.CommandText = "SELECT * FROM infedenceView WHERE data BETWEEN :dataStart AND :dataEnd ";
            selectData.Parameters.Add(":dataStart", DbType.String);
            selectData.Parameters.Add(":dataEnd", DbType.String);
            selectData.Parameters[":dataStart"].Value = data.dateBegin;
            selectData.Parameters[":dataEnd"].Value = data.dateEnd;            
            if (data.fio != null)
            {
                selectData.CommandText += "AND fio=:fio ";                
                selectData.Parameters.Add(":fio", DbType.String);
                selectData.Parameters[":fio"].Value = data.fio;
            }
            if (data.ageStart != null)
            {
                selectData.CommandText += "AND age>=:ageStart AND age <=:endAge ";
                selectData.Parameters.Add(":startAge", DbType.String);
                selectData.Parameters.Add(":endAge", DbType.String);
                selectData.Parameters[":startAge"].Value = data.ageStart;
                selectData.Parameters[":endAge"].Value = data.ageEnd; 
            }
            if (data.region != null)
            {
                selectData.CommandText += "AND region=:region ";
                selectData.Parameters.Add(":region", DbType.String);
                selectData.Parameters[":region"].Value = data.region;
            }
            if (data.diagnose != null)
            {
                selectData.CommandText += "AND mkbCode=:mkbCode ";
                selectData.Parameters.Add(":mkbCode", DbType.String);
                selectData.Parameters[":mkbCode"].Value = getID(data.diagnose, typesData.diagnose);
            }
            if (data.lpz != null)
            {
                selectData.CommandText += "AND invalidityLpzID=:lpz ";
                selectData.Parameters.Add(":lpz", DbType.String);
                selectData.Parameters[":lpz"].Value = data.lpz;
            }
            if (data.orphanDiseases)
            {
                selectData.CommandText += "AND mkbCode IN (SELECT diagnosis.codeMKB FROM diagnosis WHERE diagnosis.isOrphan = 1) ";                
            }
            connect();
            adapter.Fill(searchResult);
            disconnect();
            return searchResult;            
        }
    }
}
