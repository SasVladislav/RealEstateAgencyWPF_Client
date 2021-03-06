﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.WPF.Model.Models.ModelDTO;

namespace RealEstate.WPF.Model.Models.ModelViewDTO
{
    public class ContractViewDTO
    {

        public ContractViewDTO()
        {
            Contract = new ContractDTO();
            ContractType = new ContractTypeDTO();
            UserView = new UserViewDTO();
            RealEstateView = new RealEstateViewDTO();
            Employee = new EmployeeDTO();
        }

        public ContractDTO Contract { get; set; }
        public ContractTypeDTO ContractType { get; set; }
        public UserViewDTO UserView { get; set; }
        public RealEstateViewDTO RealEstateView { get; set; }
        public EmployeeDTO Employee { get; set; }
    }
}
