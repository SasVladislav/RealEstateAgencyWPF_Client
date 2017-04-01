using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Models.ModelFilters
{
    public class EmployeeDismissFilterModel
    {
        public int? EmployeeDismissId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime EmploymentDate { get; set; }
        public DateTime? DismissDate { get; set; }
        
    }
}
