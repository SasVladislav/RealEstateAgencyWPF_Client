using RealEstate.WPF.Model.Models.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Models.ModelViewDTO
{
    public class UserViewDTO : AbstractPersonViewModel<UserDTO>
    {
        public UserViewDTO() 
        {
            Person = new UserDTO();
            Address = new AddressDTO();
        }

    }
}
