using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLogin_MVVM.Entity
{
   
    public class EmployeeRegisterEntity
    {
        public EmployeeRegisterEntity()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int EmployeeId { get; set; }
        [MaxLength(20)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string College { get; set; }
        public string Qualification { get; set; }
        public DateTime DateOfBith { get; set; }
        [MaxLength(20)]
        public string Password { get; set; }
        public string EmployeeRole { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}
