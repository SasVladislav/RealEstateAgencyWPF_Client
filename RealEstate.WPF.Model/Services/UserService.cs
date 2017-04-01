using RealEstate.WPF.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.WPF.Model.Models;
using RealEstate.WPF.Model.Models.ModelViewDTO;
using RealEstate.WPF.Model.Models.ModelFilters;
using RealEstate.WPF.Model.Models.ModelDTO;

namespace RealEstate.WPF.Model.Services
{
    public class UserService : IUserService
    {
        public async Task<string> CreateUser(UserViewDTO userViewDto)
        {          
            return (await new SendToServerService<OperationDetails, UserViewDTO>().PostDataByJsonObjectAsync("User/CreateUserViewAsync", userViewDto)).Result.Id;
        }
        public async Task<List<UserViewDTO>> FilterUsersRecord(UserFilterModel userFilterModel)
        {         
            return (await new SendToServerService<List<UserViewDTO>, UserFilterModel>().PostDataByJsonObjectAsync("User/FilterFullNameUsers", userFilterModel)).Result;
        }

        public async Task<List<UserViewDTO>> GetAllUsers()
        {
            return (await new SendToServerService<List<UserViewDTO>, object>().GetDataByJsonObjectAsync("User/GetAllUsersView")).Result;
        }

        public async Task<ResponsePackage<UserDTO>> UpdateUserRecord(UserDTO user)
        {
           return await new SendToServerService<UserDTO, UserDTO>().PostDataByJsonObjectAsync("User/UpdateUser", user);
        }
    }
}
