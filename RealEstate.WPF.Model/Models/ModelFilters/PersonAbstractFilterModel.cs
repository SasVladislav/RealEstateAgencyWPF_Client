using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Models.ModelFilters
{
    public abstract class PersonAbstractFilterModel
    {
        public string PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronumic { get; set; }
        public string PassportNumber { get; set; }
        public int? PhoneNumber { get; set; }
        public int? AddressID { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }   
}
