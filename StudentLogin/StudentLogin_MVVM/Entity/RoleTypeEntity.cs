using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLogin_MVVM.Entity
{
   
    public class RoleTypeEntity
    {
        public RoleTypeEntity()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
