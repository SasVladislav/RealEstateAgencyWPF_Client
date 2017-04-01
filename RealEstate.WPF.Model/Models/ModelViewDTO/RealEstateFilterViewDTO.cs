using RealEstate.WPF.Model.Models.ModelFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Models.ModelViewDTO
{
    public class RealEstateFilterViewDTO
    {
        public RealEstateFilterViewDTO()
        {
            RealEstateFilter = new RealEstateFilterModel();
            AddressFilter = new AddressFilterModel();
        }
        public RealEstateFilterModel RealEstateFilter { get; set; }
        public AddressFilterModel AddressFilter { get; set; }
    }
}
