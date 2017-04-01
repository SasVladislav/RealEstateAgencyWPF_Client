using RealEstate.WPF.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.WPF.Model.Models;
using RealEstate.WPF.Model.Models.ModelViewDTO;
using RealEstate.WPF.Model.Models.ModelDTO;
using RealEstate.WPF.Model.Models.ModelFilters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace RealEstate.WPF.Model.Services
{
    public class RealEstateService : IRealEstateService
    {
        public async Task<int> CreateRealEstate(RealEstateViewDTO realEstateViewDto)
        {
            return Convert.ToInt32((await new SendToServerService<OperationDetails, RealEstateViewDTO>().PostDataByJsonObjectAsync("RealEstate/CreateRealEstate", realEstateViewDto)).Result.Id);            
        }
        public async Task<List<RealEstateViewDTO>> GetAllRealEstates()
        {                       
            return (await new SendToServerService<List<RealEstateViewDTO>, object>().GetDataByJsonObjectAsync("RealEstate/GetAllRealEstatesView")).Result;
        }
        public async Task<List<RealEstateViewDTO>> GetAllFilterRealEstates(RealEstateFilterViewDTO realEstateFilterView)
        {           
          return (await new SendToServerService<List<RealEstateViewDTO>, RealEstateFilterViewDTO>().PostDataByJsonObjectAsync("RealEstate/FilterRealEstateView", realEstateFilterView)).Result;           
        }

        public async Task<ResponsePackage<RealEstateDTO>> UpdateRealEstateRecord(RealEstateDTO realEstate)
        {
            return await new SendToServerService<RealEstateDTO, RealEstateDTO>().PostDataByJsonObjectAsync("RealEstate/UpdateRealEstate", realEstate);
        }
    }
}
