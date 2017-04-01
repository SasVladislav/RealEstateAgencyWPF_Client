using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.WPF.Model.Models;
using RealEstate.WPF.Model.Models.ModelDTO;

namespace RealEstate.WPF.Model
{
    public class LocalRepository
    {
        //public List<UserDTO> GetEmployees()
        //{ 
        //    return new List<UserDTO>()
        //    {
        //        new UserDTO(){
        //            Name ="vlad",
        //            Surname ="Sas",
        //            Patronumic ="Massage",
        //            PhoneNumber =05789644,
        //            City=1,
        //            Region=1,
        //            Street=1,
        //            HomeNumber="Home1",
        //            ApartmentNumber=58,
        //            Email="Email@gmail.com1"},
        //        new UserDTO(){Name="Igor",Surname="Roslyacov",Patronumic="Victorovich",PhoneNumber=121547,
        //            City=2,
        //            Region=2,
        //            Street=2,
        //            HomeNumber="Home2",
        //            ApartmentNumber=51,
        //            Email="Email2@gmail.com"},
        //        new UserDTO(){Name="Maksim",Surname="Kek",Patronumic="Hmm",PhoneNumber=9654487,
        //            City=3,
        //            Region=3,
        //            Street=3,
        //            HomeNumber="Home3",
        //            ApartmentNumber=53,
        //            Email="Email3@gmail.com"},
        //        new UserDTO(){Name="Nikita",Surname="Lol",Patronumic="Wtf",PhoneNumber=587100,
        //            City=4,
        //            Region=4,
        //            Street=4,
        //            HomeNumber="Home4",
        //            ApartmentNumber=54,
        //            Email="Email4@gmail.com"},
        //        new UserDTO(){Name="Viktor",Surname="Heh",Patronumic="Mem",PhoneNumber=0001405,
        //            City=1,
        //            Region=1,
        //            Street=1,
        //            HomeNumber="Home5",
        //            ApartmentNumber=55,
        //            Email="Email5@gmail.com"},
        //    };
        //}
        public List<AddressCityDTO> GetCity()
        {
            return new List<AddressCityDTO>()
            {
                new AddressCityDTO { AddressCityID=1,AddressCityName="London"},
                new AddressCityDTO { AddressCityID=2,AddressCityName="Kharkov"},
                new AddressCityDTO { AddressCityID=3,AddressCityName="Kiev"},
                new AddressCityDTO { AddressCityID=4,AddressCityName="Moskov"}

            };
        }
        public List<AddressRegionDTO> GetRegions()
        {
            return new List<AddressRegionDTO>()
            {
                new AddressRegionDTO { AddressRegionID=1,AddressRegionName="LondonRegion"},
                new AddressRegionDTO { AddressRegionID=2,AddressRegionName="KharkovRegion"},
                new AddressRegionDTO { AddressRegionID=3,AddressRegionName="KievRegion"},
                new AddressRegionDTO { AddressRegionID=4,AddressRegionName="MoskovRegion"}

            };
        }
        public List<AddressStreetDTO> GetStreets()
        {
            return new List<AddressStreetDTO>()
            {
                new AddressStreetDTO { AddressStreetID=1,AddressStreetName="LondonStreet"},
                new AddressStreetDTO { AddressStreetID=2,AddressStreetName="KharkovStreet"},
                new AddressStreetDTO { AddressStreetID=3,AddressStreetName="KievStreet"},
                new AddressStreetDTO { AddressStreetID=4,AddressStreetName="MoskovStreet"}

            };
        }
    }
}
