using RealEstate.WPF.Model.Models;
using RealEstate.WPF.Model.Models.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Interfaces
{
    public interface IAddressStreetService
    {
        Task<List<AddressStreetDTO>> GetAllStreets();
    }
}
