using RealEstate.WPF.Model.Models;
using RealEstate.WPF.Model.Models.ModelDTO;
using RealEstate.WPF.Model.Models.ModelFilters;
using RealEstate.WPF.Model.Models.ModelViewDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Interfaces
{
    public interface IUserService
    {
        Task<List<UserViewDTO>> GetAllUsers();
        Task<ResponsePackage<UserDTO>> UpdateUserRecord(UserDTO user);
        Task<List<UserViewDTO>> FilterUsersRecord(UserFilterModel userFilterModel);
    }
}
