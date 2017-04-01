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
    public class AddressStreetService : IAddressStreetService
    {
        public async Task<List<AddressStreetDTO>> GetAllStreets()
        {
            return (await new SendToServerService<List<AddressStreetDTO>, object>().GetDataByJsonObjectAsync("Address/GetAllStreets")).Result;
        }
    }
}
