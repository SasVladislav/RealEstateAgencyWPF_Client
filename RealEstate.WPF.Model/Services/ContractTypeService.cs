using RealEstate.WPF.Model.Models.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Services
{
    public class ContractTypeService
    {
        public async Task<List<ContractTypeDTO>> GetAllContractTypes()
        {
            return (await new SendToServerService<List<ContractTypeDTO>, object>().GetDataByJsonObjectAsync("Contract/GetAllTypes")).Result;
        }
    }
}
