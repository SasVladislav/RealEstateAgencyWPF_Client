using RealEstate.WPF.Model.Interfaces;
using RealEstate.WPF.Model.Models;
using RealEstate.WPF.Model.Models.ModelDTO;
using RealEstate.WPF.Model.Models.ModelFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Services
{
    public class UserServiceLocal//:IUserService
    {
        public ResponsePackage<List<UserDTO>> FilterUsersRecord(UserFilterModel userFilterModel)
        {
            
                List<UserDTO> list = GetAllEmployee().Result;
                
                
                    
            if(userFilterModel.Name!=""&& userFilterModel.Surname == ""&& userFilterModel.Patronumic == "")
               list=list.Where(x=>x.Name==userFilterModel.Name
                               || x.Surname == userFilterModel.Name 
                               || x.Patronumic == userFilterModel.Name).ToList();

            if (userFilterModel.Name != "" && userFilterModel.Surname != "" && userFilterModel.Patronumic == "")
                list = list.Where(x => x.Name == userFilterModel.Name && x.Surname == userFilterModel.Surname
                                    || x.Surname == userFilterModel.Name && x.Patronumic == userFilterModel.Surname
                                    || x.Name == userFilterModel.Name && x.Patronumic == userFilterModel.Surname).ToList();

            if (userFilterModel.Name != "" && userFilterModel.Surname != "" && userFilterModel.Patronumic != "")
                list = list.Where(x => x.Name == userFilterModel.Name 
                                    && x.Surname == userFilterModel.Surname 
                                    && x.Name == userFilterModel.Patronumic).ToList();

            return new ResponsePackage<List<UserDTO>>() { Result=list};
        }

        public ResponsePackage<List<UserDTO>> GetAllEmployee()
        {
            return new ResponsePackage<List<UserDTO>>() 
            {
                Errors = null,
                //Result = new LocalRepository().GetEmployees() 
            };
        }

        public async Task<ResponsePackage<EmployeeDTO>> IsAuthorized(LoginDto loginModel)
        {
            return await new SendToServerService<EmployeeDTO, LoginDto>().PostDataByJsonObjectAsync("Account/LoginWPF", loginModel);
        }

        //public ResponsePackage<List<UserDTO>> UpdateUserRecord(UserDTO userDto)
        //{
        //    List<UserDTO> userList = new LocalRepository().GetEmployees();
        //    UserDTO user = userList.Find(x=>x.Name==userDto.Name&&x.Surname== userDto.Surname);

        //    userList.Remove(user);
        //    userList.Add(userDto);
        //    return new ResponsePackage<List<UserDTO>>() { Result=userList/*new OperationDetails(true,"Пользователь успешно изменен","")*/ };
        //}
    }
}
