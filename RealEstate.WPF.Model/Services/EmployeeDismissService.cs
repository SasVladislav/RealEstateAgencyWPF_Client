using RealEstate.WPF.Model.Models.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Services
{
    public class EmployeeDismissService
    {
        public async Task<List<EmployeeDismissDTO>> GetAllDismisses()
        {
            return (await new SendToServerService<List<EmployeeDismissDTO>, object>().GetDataByJsonObjectAsync("Employee/GetAllDismiss")).Result;
        }
    }
}
