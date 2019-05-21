using SQLite;
using StudentLogin_MVVM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLogin_MVVM.Helper
{
    public static class GlobalValue
    {
        private static SQLiteHelper _connection;

        public static SQLiteHelper Connection {
            get
            {
                if (_connection == null)
                    return _connection = new SQLiteHelper();
                else
                    return _connection;
            }
        }     
    }
}
