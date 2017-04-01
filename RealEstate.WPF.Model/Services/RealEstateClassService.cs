using RealEstate.WPF.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.WPF.Model.Models;
using RealEstate.WPF.Model.Models.ModelDTO;

namespace RealEstate.WPF.Model.Services
{
    public class RealEstateClassService : IRealEstateClassService
    {
        public async Task<List<RealEstateClassDTO>> GetAllRealEstateClasses()
        {
            return (await new SendToServerService<List<RealEstateClassDTO>, object>().GetDataByJsonObjectAsync("RealEstate/GetAllClasses")).Result;
        }
    }
}
