using RealEstate.WPF.Model.Models;
using RealEstate.WPF.Model.Models.ModelDTO;
using RealEstate.WPF.Model.Models.ModelViewDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.ViewModel.Model
{
    public class MiddleClassModel
    {
        public EmployeeViewDTO Employee { get; set; }
        public UserViewDTO User { get; set; }
        public RealEstateViewDTO RealEstate { get; set; }
    }
}
