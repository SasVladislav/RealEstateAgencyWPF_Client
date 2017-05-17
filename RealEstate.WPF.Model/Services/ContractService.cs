using RealEstate.WPF.Model.Models.ModelDTO;
using RealEstate.WPF.Model.Models.ModelFilters;
using RealEstate.WPF.Model.Models.ModelViewDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Services
{
    public class ContractService
    {
        public async Task<List<ContractViewDTO>> GetAllContractsView()
        {
            return (await new SendToServerService<List<ContractViewDTO>, object>().GetDataByJsonObjectAsync("Contract/GetAllContractsView")).Result;
        }
        public async Task<ResponsePackage<ContractDTO>> CreateContract(ContractDTO contractDto)
        {
            return await new SendToServerService<ContractDTO, ContractDTO>().PostDataByJsonObjectAsync("Contract/CreateContract", contractDto);
        }
        public async Task<List<ContractViewDTO>> FilterUsersRecord(ContractFilterModel contractFilterModel)
        {
            return (await new SendToServerService<List<ContractViewDTO>, ContractFilterModel>().PostDataByJsonObjectAsync("Contract/FilterContractView", contractFilterModel)).Result;
        }
    }
}
