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
    public class AddressStreetServiceLocal //: IAddressStreetService
    {
        public ResponsePackage<List<AddressStreetDTO>> GetAllStreets()
        {
            return new ResponsePackage<List<AddressStreetDTO>>()
            {
                Result = new LocalRepository().GetStreets()
            };
        }
    }
}
