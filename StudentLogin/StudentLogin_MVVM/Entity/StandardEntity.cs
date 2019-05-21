using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLogin_MVVM.Entity
{   
    public class StandardEntity
    {
        public StandardEntity()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int StandardId { get; set; }
        public string StandardClass { get; set; }
        public string StandardLevel { get; set; }
    
    }
}
