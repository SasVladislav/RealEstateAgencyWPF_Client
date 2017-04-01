using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Models.ModelFilters
{
    public class ResponsePackage<T> where T :class
    {
        public List<string> Errors { get; set; }

        public T Result { get; set; }
    }
}
