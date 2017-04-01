using RealEstate.WPF.Model.Models.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Services
{
    public class EmployeePostService
    {
        public async Task<List<EmployeePostDTO>> GetAllPosts()
        {
            return (await new SendToServerService<List<EmployeePostDTO>, object>().GetDataByJsonObjectAsync("Employee/GetAllPosts")).Result;
        }
    }
}
