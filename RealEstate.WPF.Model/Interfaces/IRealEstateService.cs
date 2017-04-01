using RealEstate.WPF.Model.Models;
using RealEstate.WPF.Model.Models.ModelViewDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Interfaces
{
    public interface IRealEstateService
    {
        Task<List<RealEstateViewDTO>> GetAllRealEstates();
    }
}
