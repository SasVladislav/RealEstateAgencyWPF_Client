using RealEstate.WPF.Model.Models.ModelDTO;
using RealEstate.WPF.Model.Models.ModelViewDTO;
using RealEstate.WPF.Model.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RealEstate.WPF.ViewModel.ViewModels.PropertyViewModel
{
    public class AddressPropertyViewModel : INotifyPropertyChanged
    {
        private AddressViewDTO AddressModel;
        private ObservableCollection<AddressCityDTO> citiesList = new ObservableCollection<AddressCityDTO>();
        private ObservableCollection<AddressRegionDTO> regionsList = new ObservableCollection<AddressRegionDTO>();
        private ObservableCollection<AddressStreetDTO> streetsList = new ObservableCollection<AddressStreetDTO>();
        public AddressPropertyViewModel(){}
        public AddressPropertyViewModel(AddressViewDTO addressModel)
        {
            AddressModel = addressModel ?? new AddressViewDTO();
            ThreadPool.QueueUserWorkItem(InvokeAsync);
        }
        private async void InvokeAsync(Object state)
        {
            Cities = ToObservableCollection<AddressCityDTO>(await new AddressCitiesService().GetAllCities());
            Regions = ToObservableCollection<AddressRegionDTO>(await new AddressRegionService().GetAllRegions());
            Streets = ToObservableCollection<AddressStreetDTO>(await new AddressStreetService().GetAllStreets());
            InsertComboboxAddressInformation(AddressModel);
        }
        //-------------------Comboboxes

        public AddressViewDTO GetAddressModel
        {
            get{return AddressModel;}
        }
        public ObservableCollection<AddressCityDTO> Cities
        {
            get { return citiesList; }
            set
            {
                citiesList = value;
                OnPropertyChanged("Cities");
            }
        }

        public int SelectedCityId
        {
            get { return AddressModel.Address.AddressCityID; }
            set
            {
                AddressModel.Address.AddressCityID = value;
                OnPropertyChanged("SelectedCityId");
            }
        }


        public ObservableCollection<AddressRegionDTO> Regions
        {
            get { return regionsList; }
            set
            {
                regionsList = value;
                OnPropertyChanged("Regions");
            }
        }
        public int SelectedRegionId
        {
            get { return AddressModel.Address.AddressRegionID; }
            set
            {
                AddressModel.Address.AddressRegionID = value;
                OnPropertyChanged("SelectedRegionId");
            }
        }

        public ObservableCollection<AddressStreetDTO> Streets
        {
            get { return streetsList; }
            set
            {
                streetsList = value;
                OnPropertyChanged("Streets");
            }
        }

        public int SelectedStreetId
        {
            get { return AddressModel.Address.AddressStreetID; }
            set
            {
                AddressModel.Address.AddressStreetID = value;
                OnPropertyChanged("SelectedStreetId");
            }
        }

        public AddressCityDTO CityObject
        {
            get { return AddressModel.AddressCity; }
            set
            {
                AddressModel.AddressCity = value;
                OnPropertyChanged("CityObject");
            }
        }
        public AddressRegionDTO RegionObject
        {
            get { return AddressModel.AddressRegion; }
            set
            {
                AddressModel.AddressRegion = value;
                OnPropertyChanged("RegionObject");
            }
        }
        public AddressStreetDTO StreetObject
        {
            get { return AddressModel.AddressStreet; }
            set
            {
                AddressModel.AddressStreet = value;
                OnPropertyChanged("StreetObject");
            }
        }
        public string TbHomeNumber
        {
            get { return AddressModel.Address.HomeNumber; }
            set
            {
                AddressModel.Address.HomeNumber = value;
                OnPropertyChanged("TbHomeNumber");
            }
        }

        public int? TbApartmentNumber
        {
            get { return AddressModel.Address.ApartmentNumber; }
            set
            {
                AddressModel.Address.ApartmentNumber = value;
                OnPropertyChanged("TbApartmentNumber");
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void OnPropertyChanged(string PropertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
        private ObservableCollection<T> ToObservableCollection<T>(List<T> list)
        {
            var observList = new ObservableCollection<T>();
            foreach (var item in list)
                observList.Add(item);
            return observList;
        }
        public void InsertComboboxAddressInformation(AddressViewDTO address)
        {
            address = address ?? new AddressViewDTO();
            this.SelectedCityId = address.Address.AddressCityID;
            this.SelectedRegionId = address.Address.AddressRegionID;
            this.SelectedStreetId = address.Address.AddressStreetID;
            this.TbHomeNumber = address.Address.HomeNumber;
            this.TbApartmentNumber = address.Address.ApartmentNumber;
            this.CityObject = address.AddressCity;
            this.RegionObject = address.AddressRegion;
            this.StreetObject = address.AddressStreet;
        }
    }
}
