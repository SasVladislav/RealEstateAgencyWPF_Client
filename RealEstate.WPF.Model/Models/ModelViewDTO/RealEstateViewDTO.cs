using RealEstate.WPF.Model.Models.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Models.ModelViewDTO
{
    public class RealEstateViewDTO
    {
        public RealEstateViewDTO():base()
        {
            RealEstate = new RealEstateDTO();
            Address = new AddressDTO();
        }
        public RealEstateDTO RealEstate { get; set; }
        public AddressDTO Address { get; set; }
    }
}
