using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Models.ModelDTO
{
    public class ContractDTO
    {
        public int ContractID { get; set; }
        public int RealEstateID { get; set; }
        public string BuyerID { get; set; }
        public string SellerID { get; set; }
        public string EmployeeID { get; set; }
        public int ContractTypeID { get; set; }
        public string RecordDate { get; set; }
    }
}
