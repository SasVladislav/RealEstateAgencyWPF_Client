using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RealEstate.WPF.Model.Interfaces;
using RealEstate.WPF.Model.Models;
using RealEstate.WPF.Model.Models.ModelDTO;
using RealEstate.WPF.Model.Models.ModelFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Services
{
    public class AccountService: IAccountService
    {                       
        public async Task<ResponsePackage<EmployeeDTO>> IsAuthorized(LoginDto loginModel)
        {
            return await new SendToServerService<EmployeeDTO, LoginDto>().PostDataByJsonObjectAsync("Account/LoginWPF", loginModel);
        }
    }
}
