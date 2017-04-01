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
    public class RealEstateTypeWallService : IRealEstateTypeWallService
    {
        public async Task<List<RealEstateTypeWallDTO>> GetAllRealEstateTypeWalls()
        {
            return (await new SendToServerService<List<RealEstateTypeWallDTO>, object>().GetDataByJsonObjectAsync("RealEstate/GetAllTypeWalls")).Result;
        }
    }
}
