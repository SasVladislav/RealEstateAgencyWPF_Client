using RealEstate.WPF.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.WPF.Model.Models;
using RealEstate.WPF.Model.Models.ModelFilters;
using RealEstate.WPF.Model.Models.ModelDTO;

namespace RealEstate.WPF.Model.Services
{
    public class AddressRegionServiceLocal//: IAddressRegionService
    {
        public ResponsePackage<List<AddressRegionDTO>> GetAllRegions()
        {
            return new ResponsePackage<List<AddressRegionDTO>>()
            {
                Result = new LocalRepository().GetRegions()
            };
        }
    };
}

