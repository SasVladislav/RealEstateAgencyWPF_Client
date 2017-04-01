using RealEstate.WPF.Model.Models.ModelDTO;
using RealEstate.WPF.Model.Models.ModelFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Services
{
    public class ContractService
    {
        public async Task<List<ContractDTO>> GetAllContracts()
        {
            return (await new SendToServerService<List<ContractDTO>, object>().GetDataByJsonObjectAsync("Contract/GetAllContracts")).Result;
        }
        public async Task<ResponsePackage<ContractDTO>> CreateContract(ContractDTO contractDto)
        {
            return await new SendToServerService<ContractDTO, ContractDTO>().PostDataByJsonObjectAsync("Contract/CreateContract", contractDto);
        }
    }
}
