using RealEstate.WPF.Model.Models;
using RealEstate.WPF.Model.Models.ModelDTO;
using RealEstate.WPF.Model.Models.ModelFilters;
using RealEstate.WPF.Model.Models.ModelViewDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Services
{
    public class EmployeeService
    {
        public async Task<string> CreateEmployee(EmployeeViewDTO employeeViewDto)
        {
            return (await new SendToServerService<OperationDetails, EmployeeViewDTO>().PostDataByJsonObjectAsync("Employee/CreateEmployeeView", employeeViewDto)).Result.Id;
        }
        public async Task<List<EmployeeViewDTO>> GetAllEmployees()
        {
           return (await new SendToServerService<List<EmployeeViewDTO>, object>().GetDataByJsonObjectAsync("Employee/GetAllEmployeesView")).Result;
        }

        public async Task<ResponsePackage<EmployeeDTO>> UpdateEmployeeRecord(EmployeeDTO user)
        {
            return await new SendToServerService<EmployeeDTO, EmployeeDTO>().PostDataByJsonObjectAsync("Employee/UpdateEmployee", user);
        }
        public async Task<ResponsePackage<OperationDetails>> DismissEmployee(EmployeeDTO user)
        {
            return await new SendToServerService<OperationDetails, SendIDToWebApiDTO>().PostDataByJsonObjectAsync("Employee/DismissEmployee",new SendIDToWebApiDTO() {IdString=user.PersonId });
        }
        public async Task<ResponsePackage<OperationDetails>> EmploymentEmployee(EmployeeDTO user)
        {
            return await new SendToServerService<OperationDetails, SendIDToWebApiDTO>().PostDataByJsonObjectAsync("Employee/CreateExistEmployee", new SendIDToWebApiDTO() { IdString = user.PersonId });
        }
        public async Task<List<EmployeeViewDTO>> FilterEmployeesRecord(EmployeeFilterModel filterModel)
        {
            return (await new SendToServerService<List<EmployeeViewDTO>, EmployeeFilterModel>().PostDataByJsonObjectAsync("Employee/FilterEmployee", filterModel)).Result;
        }
    }
}
