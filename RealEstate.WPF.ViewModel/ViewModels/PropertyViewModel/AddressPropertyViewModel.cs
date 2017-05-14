using RealEstate.WPF.Model.Models.ModelDTO;
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
        private AddressDTO AddressModel;
        private ObservableCollection<AddressCityDTO> citiesList = new ObservableCollection<AddressCityDTO>();
        private ObservableCollection<AddressRegionDTO> regionsList = new ObservableCollection<AddressRegionDTO>();
        private ObservableCollection<AddressStreetDTO> streetsList = new ObservableCollection<AddressStreetDTO>();
        public AddressPropertyViewModel(){}
        public AddressPropertyViewModel(AddressDTO addressModel)
        {
            AddressModel = addressModel ?? new AddressDTO();
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

        public AddressDTO GetAddressModel
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
            get { return AddressModel.AddressCityID; }
            set
            {
                AddressModel.AddressCityID = value;
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
            get { return AddressModel.AddressRegionID; }
            set
            {
                AddressModel.AddressRegionID = value;
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
            get { return AddressModel.AddressStreetID; }
            set
            {
                AddressModel.AddressStreetID = value;
                OnPropertyChanged("SelectedStreetId");
            }
        }
        public string TbHomeNumber
        {
            get { return AddressModel.HomeNumber; }
            set
            {
                AddressModel.HomeNumber = value;
                OnPropertyChanged("TbHomeNumber");
            }
        }

        public int? TbApartmentNumber
        {
            get { return AddressModel.ApartmentNumber; }
            set
            {
                AddressModel.ApartmentNumber = value;
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
        public void InsertComboboxAddressInformation(AddressDTO address)
        {
            address = address ?? new AddressDTO();
            SelectedCityId = address.AddressCityID;
            SelectedRegionId = address.AddressRegionID;
            SelectedStreetId = address.AddressStreetID;
            TbHomeNumber = address.HomeNumber;
            TbApartmentNumber = address.ApartmentNumber;
        }
    }
}
