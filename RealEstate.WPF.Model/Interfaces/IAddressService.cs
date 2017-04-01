using RealEstate.WPF.Model.Models;
using RealEstate.WPF.Model.Models.ModelDTO;
using RealEstate.WPF.Model.Models.ModelFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Interfaces
{
    public interface IAddressService
    {
        Task<List<AddressDTO>> GetAllAddresses();
        Task<ResponsePackage<AddressDTO>> UpdateAddressRecord(AddressDTO address);
    }
}
