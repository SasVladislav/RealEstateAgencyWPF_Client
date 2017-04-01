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
    public class AddressCitiesServiceLocal //: IAddressRegionService
    {
        public ResponsePackage<List<AddressCityDTO>> GetAllCities()
        {
            return new ResponsePackage<List<AddressCityDTO>>() { Result = new LocalRepository().GetCity() };
        }
    }
}
