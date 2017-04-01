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
    public class AddressCitiesService : IAddressCityService
    {
        public async Task<List<AddressCityDTO>> GetAllCities()
        {
            return (await new SendToServerService<List<AddressCityDTO>, object>().GetDataByJsonObjectAsync("Address/GetAllCities")).Result;
        }
    }
}
