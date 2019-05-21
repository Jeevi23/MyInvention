using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLogin_MVVM.Entity
{
 
    public class RegisterEntity
    {
        public RegisterEntity()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(20)]
        public string FirstName { get; set; }
        [MaxLength(15)]
        public string LastName { get; set; }
        private string _user;
          
        public string Username {
            get {
             return  _user = FirstName.Substring(0, 3) + LastName.Substring(0, 3);
            }

            set {   _user = value; }
        }       
        public int StandardId { get; set; }
        public int SectionId { get; set; }
        public int RoleId { get; set; }
        public DateTime DateOfBith { get; set; }      

        [MaxLength(20)]
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
