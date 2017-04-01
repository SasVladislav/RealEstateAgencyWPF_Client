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
    public class AddressRegionService : IAddressRegionService
    {
        public async Task<List<AddressRegionDTO>> GetAllRegions()
        {
            return (await new SendToServerService<List<AddressRegionDTO>, object>().GetDataByJsonObjectAsync("Address/AllRegions")).Result;
        }
    }
}
