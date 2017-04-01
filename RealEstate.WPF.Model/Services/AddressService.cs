using RealEstate.WPF.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.WPF.Model.Models;
using RealEstate.WPF.Model.Models.ModelDTO;
using RealEstate.WPF.Model.Models.ModelFilters;

namespace RealEstate.WPF.Model.Services
{
    public class AddressService : IAddressService
    {
        public async Task<List<AddressDTO>> GetAllAddresses()
        {
            return (await new SendToServerService<List<AddressDTO>, object>().GetDataByJsonObjectAsync("Address/GetAllAddresses")).Result;
        }

        public async Task<ResponsePackage<AddressDTO>> UpdateAddressRecord(AddressDTO address)
        {
            return await new SendToServerService<AddressDTO, AddressDTO>().PostDataByJsonObjectAsync("Address/UpdateAddress", address);
        }

        public async Task<List<AddressDTO>> GetAllFilterAddresses(AddressFilterModel AddressFilter)
        {
            return (await new SendToServerService<List<AddressDTO>, AddressFilterModel>().PostDataByJsonObjectAsync("Address/FilterAddress", AddressFilter)).Result;
        }
    }
}
