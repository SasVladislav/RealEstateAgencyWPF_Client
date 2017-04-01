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
    public class RealEstateTypeService : IRealEstateTypeService
    {
        public async Task<List<RealEstateTypeDTO>> GetAllRealEstateTypes()
        {
            return (await new SendToServerService<List<RealEstateTypeDTO>, object>().GetDataByJsonObjectAsync("RealEstate/GetAllTypes")).Result;
        }
    }
}
