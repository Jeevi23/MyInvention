using StudentLogin_MVVM.Entity;
using StudentLogin_MVVM.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLogin_MVVM.ViewModel
{
    public class LoginViewModel
    {
        private readonly SQLiteHelper _database = GlobalValue.Connection;
        public List<RoleTypeEntity> RoleTypes { get; set; }
        public string FirstName { get; set; }     
        public string LastName { get; set; }       
        public DateTime DateOfBith { get; set; }      
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Address { get; set; }
        public int SelectedStandardId { get; set; }
        public int SelectedRoleId { get; set; }
        public int SelectedSection { get; set; }
        public List<StandardEntity> Standard { get; set; }
        public List<AddSectionEntity> Section { get; set; }
        
        public void AddNewPortalMember()
        {
            var regEntity = new RegisterEntity()
            {
                FirstName = FirstName,
                LastName = LastName,
                Password = ConfirmPassword,
                DateOfBith = DateTime.Now,
                Address = Address,
                SectionId = SelectedSection,
                RoleId = SelectedRoleId,
                StandardId = SelectedStandardId

            };
            _database.SaveItem(regEntity);
        }

        public LoginViewModel()
        {
            SetViewModelValues();
            if(Standard.Count<=0)
            Standard = new List<StandardEntity>()
            {
                new StandardEntity() { StandardId=0, StandardClass="None" }
            };
        }

        private void SetViewModelValues()
        {
            RoleTypes = _database.GetRoleType();
            Standard = _database.GetStandardItems();
            Section = _database.GetSectionItems();
        }
    }
}
