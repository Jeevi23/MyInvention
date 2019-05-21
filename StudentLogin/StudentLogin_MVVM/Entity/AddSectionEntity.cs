using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLogin_MVVM.Entity
{
  
    public class AddSectionEntity
    {
        public AddSectionEntity()
        {
        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string SectionName { get; set; }      
        public int StandardId { get; set; }
    }
}
