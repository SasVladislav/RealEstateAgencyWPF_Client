using RealEstate.WPF.Model.Models.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Models.ModelViewDTO
{
    public class EmployeeViewDTO : AbstractPersonViewModel<EmployeeDTO>
    {
        public EmployeeViewDTO()
        {
            Person = new EmployeeDTO();
            AddressView = new AddressViewDTO();
            Dismisses = new List<EmployeeDismissDTO>();
            Post = new EmployeePostDTO();
        }
        public EmployeePostDTO Post { get; set; }
        public List<EmployeeDismissDTO> Dismisses { get; set; }
    }
}
