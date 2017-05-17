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
        public AddressViewDTO AddressView { get; set; }
        public T Person { get; set; }
    }
}
