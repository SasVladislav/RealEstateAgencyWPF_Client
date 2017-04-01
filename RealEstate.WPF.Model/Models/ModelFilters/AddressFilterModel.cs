using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Models.ModelFilters
{
    public class AddressFilterModel
    {
        public int? AddressID { get; set; }
        public int? AddressCityID { get; set; }
        public int? AddressRegionID { get; set; }
        public int? AddressStreetID { get; set; }
        public string HomeNumber { get; set; }
        public int? ApartmentNumber { get; set; }
    }
}
