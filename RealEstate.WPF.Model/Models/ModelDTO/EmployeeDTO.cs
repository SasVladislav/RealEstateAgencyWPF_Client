using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Models.ModelDTO
{
    public class EmployeeDTO:PersonAbstractDTO
    {
        public int EmployeePostID { get; set; }
        public int EmployeeStatusID { get; set; }
        public bool StateOnline { get; set; }
    }
}
