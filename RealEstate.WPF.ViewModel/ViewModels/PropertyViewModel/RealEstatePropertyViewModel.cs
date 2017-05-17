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
    public class RealEstatePropertyViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<RealEstateClassDTO> realEstateClassesList = new ObservableCollection<RealEstateClassDTO>();
        private ObservableCollection<RealEstateStatusDTO> realEstateStatusesList = new ObservableCollection<RealEstateStatusDTO>();
        private ObservableCollection<RealEstateTypeDTO> realEstateTypesList = new ObservableCollection<RealEstateTypeDTO>();
        private ObservableCollection<RealEstateTypeWallDTO> realEstateTypeWallsList = new ObservableCollection<RealEstateTypeWallDTO>();
        private RealEstateViewDTO RealEstateModel;
        private AddressPropertyViewModel AddressModel;
        public event PropertyChangedEventHandler PropertyChanged;

        public RealEstatePropertyViewModel(RealEstateViewDTO realEstateModel)
        {
            AddressViewModel = AddressViewModel ?? new AddressPropertyViewModel(realEstateModel.AddressView);
            RealEstateModel = realEstateModel ?? new RealEstateViewDTO();

            InsertTextBoxRealEstateInformation(RealEstateModel);
            AddressViewModel.InsertComboboxAddressInformation(realEstateModel.AddressView);
            ThreadPool.QueueUserWorkItem(InokeAsyncMethods);
        }
        public RealEstateViewDTO GetRealEstate {
            get {
                RealEstateModel.RealEstate.RealEstateStatusID = 1;
                return RealEstateModel;
            }
        }
        public AddressPropertyViewModel AddressViewModel
        {
            get { return AddressModel; }
            set
            {
                AddressModel = value;
                OnPropertyChanged("AddressViewModel");
            }
        }
        private async void InokeAsyncMethods(Object state)
        {
            cbClassesSource = ToObservableCollection<RealEstateClassDTO>(await new RealEstateClassService().GetAllRealEstateClasses());
            cbStatusesSource = ToObservableCollection<RealEstateStatusDTO>(await new RealEstateStatusService().GetAllRealEstateStatuses());
            cbTypesSource = ToObservableCollection<RealEstateTypeDTO>(await new RealEstateTypeService().GetAllRealEstateTypes());
            cbTypeWallsSource = ToObservableCollection<RealEstateTypeWallDTO>(await new RealEstateTypeWallService().GetAllRealEstateTypeWalls());                      
        }

        public void InsertTextBoxRealEstateInformation(RealEstateViewDTO realEstate)
        {           
            cbTypeIdSelected = realEstate.RealEstate.RealEstateTypeID;
            cbStatusIdSelected = realEstate.RealEstate.RealEstateStatusID;
            cbTypeWallIdSelected = realEstate.RealEstate.RealEstateTypeWallID;
            cbClassIdSelected = realEstate.RealEstate.RealEstateClassID;
            TbPrice = realEstate.RealEstate.Price;
            TbNumberOfRooms = realEstate.RealEstate.NumberOfRooms;
            TbLevel = realEstate.RealEstate.Level;
            TbGrossArea = realEstate.RealEstate.GrossArea;
            TbNearSubway = realEstate.RealEstate.NearSubway;
            CheckElevator = realEstate.RealEstate.Elevator;
        }
        
        private ObservableCollection<T> ToObservableCollection<T>(List<T> list)
        {
            var observList = new ObservableCollection<T>();
            foreach (var item in list)
                observList.Add(item);
            return observList;
        }
        
        public bool CheckElevator
        {
            get { return RealEstateModel.RealEstate.Elevator; }
            set
            {
                RealEstateModel.RealEstate.Elevator = value;
                OnPropertyChanged("CheckElevator");
            }
        }
        public double TbPrice
        {
            get { return RealEstateModel.RealEstate.Price; }
            set
            {
                RealEstateModel.RealEstate.Price = value;
                OnPropertyChanged("TbPrice");
            }
        }
        public int TbNumberOfRooms
        {
            get { return RealEstateModel.RealEstate.NumberOfRooms; }
            set
            {
                RealEstateModel.RealEstate.NumberOfRooms = value;
                OnPropertyChanged("TbNumberOfRooms");
            }
        }
        public int TbLevel
        {
            get { return RealEstateModel.RealEstate.Level; }
            set
            {
                RealEstateModel.RealEstate.Level = value;
                OnPropertyChanged("TbLevel");
            }
        }
        public double TbGrossArea
        {
            get { return RealEstateModel.RealEstate.GrossArea; }
            set
            {
                RealEstateModel.RealEstate.GrossArea = value;
                OnPropertyChanged("TbGrossArea");
            }
        }
        public string TbNearSubway
        {
            get { return RealEstateModel.RealEstate.NearSubway; }
            set
            {
                RealEstateModel.RealEstate.NearSubway = value;
                OnPropertyChanged("TbNearSubway");
            }
        }

        public ObservableCollection<RealEstateTypeDTO> cbTypesSource
        {
            get { return realEstateTypesList; }
            set
            {
                realEstateTypesList = value;
                OnPropertyChanged("cbTypesSource");
            }
        }

        public int cbTypeIdSelected
        {
            get { return RealEstateModel.RealEstate.RealEstateTypeID; }
            set
            {
                RealEstateModel.RealEstate.RealEstateTypeID = value;
                OnPropertyChanged("cbTypeIdSelected");
            }
        }

        public ObservableCollection<RealEstateStatusDTO> cbStatusesSource
        {
            get { return realEstateStatusesList; }
            set
            {
                realEstateStatusesList = value;
                OnPropertyChanged("cbStatusesSource");
            }
        }

        public int cbStatusIdSelected
        {
            get { return RealEstateModel.RealEstate.RealEstateStatusID; }
            set
            {
                RealEstateModel.RealEstate.RealEstateStatusID = value;
                OnPropertyChanged("cbStatusIdSelected");
            }
        }

        public ObservableCollection<RealEstateTypeWallDTO> cbTypeWallsSource
        {
            get { return realEstateTypeWallsList; }
            set
            {
                realEstateTypeWallsList = value;
                OnPropertyChanged("cbTypeWallsSource");
            }
        }

        public int cbTypeWallIdSelected
        {
            get { return RealEstateModel.RealEstate.RealEstateTypeWallID; }
            set
            {
                RealEstateModel.RealEstate.RealEstateTypeWallID = value;
                OnPropertyChanged("cbTypeWallIdSelected");
            }
        }

        public ObservableCollection<RealEstateClassDTO> cbClassesSource
        {
            get { return realEstateClassesList; }
            set
            {
                realEstateClassesList = value;
                OnPropertyChanged("cbClassesSource");
            }
        }

        public int cbClassIdSelected
        {
            get { return RealEstateModel.RealEstate.RealEstateClassID; }
            set
            {
                RealEstateModel.RealEstate.RealEstateClassID = value;
                OnPropertyChanged("cbClassIdSelected");
            }
        }        

        protected void OnPropertyChanged(string PropertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

    }
}
