using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Models.ModelDTO
{
    public class EmployeeDismissDTO
    {
        public int EmployeeDismissId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime EmploymentDate { get; set; }
        public DateTime? DismissDate { get; set; }
        
    }
 
}
