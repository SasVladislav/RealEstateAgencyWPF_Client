using RealEstate.WPF.Model.Models.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Models.ModelViewDTO
{
    public abstract class AbstractPersonViewModel<T>
    {
        public AddressDTO Address { get; set; }
        public T Person { get; set; }
    }
}
