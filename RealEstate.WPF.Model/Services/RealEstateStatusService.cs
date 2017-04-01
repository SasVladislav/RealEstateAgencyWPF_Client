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
    public class RealEstateStatusService : IRealEstateStatusService
    {
        public async Task<List<RealEstateStatusDTO>> GetAllRealEstateStatuses()
        {
            return (await new SendToServerService<List<RealEstateStatusDTO>, object>().GetDataByJsonObjectAsync("RealEstate/GetAllStatuses")).Result;
        }
    }
}
