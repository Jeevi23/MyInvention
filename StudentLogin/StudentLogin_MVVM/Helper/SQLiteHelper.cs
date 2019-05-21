using System;
using PCLStorage;
using SQLite;
using StudentLogin_MVVM.Entity;
using StudentLogin_MVVM.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentLogin_MVVM.Helper
{
    public class SQLiteHelper
    {
        static object inProcess = new object();
        readonly SQLiteConnection _database;
        public SQLiteHelper()
        {
            _database = GetConnection();
            // create the tables  
            CreateStudentEmployeeTable();           
        }       
        private void CreateStudentEmployeeTable()
        {
            _database.CreateTable<RegisterEntity>();
            _database.CreateTable<StandardEntity>();
            _database.CreateTable<AddSectionEntity>();
            _database.CreateTable<RoleTypeEntity>();
            _database.CreateTable<EmployeeRegisterEntity>();
        }       
        private SQLite.SQLiteConnection GetConnection()
        {
            SQLiteConnection sqlitConnection;
            var sqliteFilename = "StudentEmployee.db3";
            IFolder folder = FileSystem.Current.LocalStorage;
            string path = PortablePath.Combine(folder.Path.ToString(), sqliteFilename);
            sqlitConnection = new SQLite.SQLiteConnection(path);
            return sqlitConnection;
        }
        public int SaveItem(RoleTypeEntity item)
        {
            lock (inProcess)
            {
                if (item.RoleId != 0)
                {
                    //Update Item  
                    _database.Update(item);
                    return item.RoleId;
                }
                else
                {
                    //Insert item  
                    return _database.Insert(item);
                }
            }
        }
        public int SaveItem(RegisterEntity item)
        {
            lock (inProcess)
            {
                if (item.Id != 0)
                {
                    //Update Item  
                    _database.Update(item);
                    return item.Id;
                }
                else
                {
                    //Insert item  
                    return _database.Insert(item);
                }
            }
        }
        public int SaveItem(StandardEntity item)
        {
            lock (inProcess)
            {
                if (item.StandardId != 0)
                {
                    //Update Item  
                    _database.Update(item);
                    return item.StandardId;
                }
                else
                {
                    //Insert item  
                    return _database.Insert(item);
                }
            }
        }
        public int SaveItem(AddSectionEntity item)
        {
            lock (inProcess)
            {
                if (item.Id != 0)
                {
                    //Update Item  
                    _database.Update(item);
                    return item.Id;
                }
                else
                {
                    //Insert item  
                    return _database.Insert(item);
                }
            }
        }
        public RegisterEntity GetUserDetails(string uName,string password)
        {
            return _database.Table<RegisterEntity>().Where(person => person.FirstName == uName && person.Password == password).FirstOrDefault();
        }
        public List<RegisterEntity> GetUserDetails()
        {
            return _database.Table<RegisterEntity>().ToList();
        }
        public List<RoleTypeEntity> GetRoleType()
        {
            return _database.Table<RoleTypeEntity>().ToList();
        }
        public List<StandardEntity> GetStandardItems()
        {
            return _database.Table<StandardEntity>().ToList();
        }

        public List<AddSectionEntity> GetSectionItems(int standId = 0)
        {
            if (standId > 0)
                return _database.Table<AddSectionEntity>().Where(sec => sec.StandardId == standId).ToList();
            else return _database.Table<AddSectionEntity>().ToList();
        }

    }   
}
