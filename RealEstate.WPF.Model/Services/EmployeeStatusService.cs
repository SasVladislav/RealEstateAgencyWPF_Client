using RealEstate.WPF.Model.Models.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Services
{
    public class EmployeeStatusService
    {
        public async Task<List<EmployeeStatusDTO>> GetAllStatuses()
        {
            return (await new SendToServerService<List<EmployeeStatusDTO>, object>().GetDataByJsonObjectAsync("Employee/GetAllStatuses")).Result;
        }
    }
}
