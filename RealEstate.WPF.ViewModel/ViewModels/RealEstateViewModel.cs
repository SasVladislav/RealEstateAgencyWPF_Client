using RealEstate.WPF.Model.Interfaces;
using RealEstate.WPF.Model.Models;
using RealEstate.WPF.Model.Models.ModelDTO;
using RealEstate.WPF.Model.Models.ModelViewDTO;
using RealEstate.WPF.Model.Services;
using RealEstate.WPF.ViewModel.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.WPF.Model.Models.ModelFilters;
using System.Windows.Input;
using RealEstate.WPF.ViewModel.Infrastructure;
using RealEstate.WPF.ViewModel.ViewModels.PropertyViewModel;
using System.Threading;

namespace RealEstate.WPF.ViewModel.ViewModels
{
    public class RealEstateViewModel : INotifyPropertyChanged
    {       
        private RealEstateViewDTO RealEstateView = new RealEstateViewDTO();
        private RealEstateFilterModel RealEstateFilter = new RealEstateFilterModel();
        private AddressFilterModel AddressFilter = new AddressFilterModel();
        private RealEstatePropertyViewModel RealEstatePropertyModel;
        public event PropertyChangedEventHandler PropertyChanged;
        private MiddleClassModel middleModel = null;
        public MiddleClassModel MiddleModel
        {
            get { return middleModel; }
            set
            {
                middleModel = value;
            }
        }

        public event Action ShowMainScreenAction;
        private DelegateCommand showMainWindow;
        public ICommand ShowMainWindow
        {
            get { return showMainWindow; }
        }

        private void ShowMainScreen()
        {
            if (ShowMainScreenAction != null)
            {
                MiddleModel = MiddleModel ?? new MiddleClassModel();
                ShowMainScreenAction.Invoke();
            }
        }
        private DelegateCommand _nextRecord;
        public ICommand BtnNextCommand
        {
            get { return _nextRecord; }
        }

        private DelegateCommand _backRecord;
        public ICommand BtnBackCommand
        {
            get { return _backRecord; }
        }
        public event Action ShowContractScreenAction;
        private DelegateCommand showContractWindow;
        public ICommand ShowContractWindow
        {
            get { return showContractWindow; }
        }
        private void ShowContractScreen()
        {
            if (ShowContractScreenAction != null)
            {
                MiddleModel = MiddleModel ?? new MiddleClassModel();
                MiddleModel.RealEstate = RealEstateView;
                ShowContractScreenAction.Invoke();
            }
        }
        private DelegateCommand filterRecords;
        public ICommand BtnFilterCommand
        {
            get { return filterRecords; }
        }
        #region Property  
             
        private bool _viewMode;
        public bool ViewMode
        {
            get { return _viewMode; }
            set
            {
                _viewMode = value;
                OnPropertyChanged("ViewMode");
            }
        }

        private bool _btnViewMode;
        public bool BtnViewMode
        {
            get { return _btnViewMode; }
            set
            {
                _btnViewMode = value;
                OnPropertyChanged("BtnViewMode");
            }
        }
        private void IsEnableMode(bool viewMode)
        {
            ViewMode = viewMode;
            BtnViewMode = !viewMode;
        }
        bool checkStateRealEstate = false; 
        public bool CheckedAccessState
        {
            get { return checkStateRealEstate; }
            set
            {
                checkStateRealEstate = value;
                FilterStateRealEstate();
                OnPropertyChanged("CheckedAccessState");
            }
        }
        public int? cbFilterTypeIdSelected
        {
            get { return RealEstateFilter.RealEstateTypeID; }
            set
            {
                RealEstateFilter.RealEstateTypeID = value;
                OnPropertyChanged("cbFilterTypeIdSelected");
            }
        }
        public int? cbFilterClassIdSelected
        {
            get { return RealEstateFilter.RealEstateClassID; }
            set
            {
                RealEstateFilter.RealEstateClassID = value;
                OnPropertyChanged("cbFilterClassIdSelected");
            }
        }

        public double? TbFilterBeginGrossArea
        {
            get { return RealEstateFilter.BeginGrossArea; }
            set
            {
                RealEstateFilter.BeginGrossArea = value;
                OnPropertyChanged("TbFilterBeginGrossArea");
            }
        }
        public double? TbFilterEndGrossArea
        {
            get { return RealEstateFilter.EndGrossArea; }
            set
            {
                RealEstateFilter.EndGrossArea = value;
                OnPropertyChanged("TbFilterEndGrossArea");
            }
        }
        public double? TbFilterBeginPrice
        {
            get { return RealEstateFilter.BeginPrice; }
            set
            {
                RealEstateFilter.BeginPrice = value;
                OnPropertyChanged("TbFilterBeginPrice");
            }
        }
        public double? TbFilterEndPrice
        {
            get { return RealEstateFilter.EndPrice; }
            set
            {
                RealEstateFilter.EndPrice = value;
                OnPropertyChanged("TbFilterEndPrice");
            }
        }
        public int? TbFilterBeginLevel
        {
            get { return RealEstateFilter.BeginLevel; }
            set
            {
                RealEstateFilter.BeginLevel = value;
                OnPropertyChanged("TbFilterBeginLevel");
            }
        }
        public int? TbFilterEndLevel
        {
            get { return RealEstateFilter.EndLevel; }
            set
            {
                RealEstateFilter.EndLevel = value;
                OnPropertyChanged("TbFilterEndLevel");
            }
        }
        public int? TbFilterBeginNumberOfRooms
        {
            get { return RealEstateFilter.BeginNumberOfRooms; }
            set
            {
                RealEstateFilter.BeginNumberOfRooms = value;
                OnPropertyChanged("TbFilterBeginNumberOfRooms");
            }
        }
        public int? TbFilterEndNumberOfRooms
        {
            get { return RealEstateFilter.EndNumberOfRooms; }
            set
            {
                RealEstateFilter.EndNumberOfRooms = value;
                OnPropertyChanged("TbFilterEndNumberOfRooms");
            }
        }

        public int? cbFilterTypeWallIdSelected
        {
            get { return RealEstateFilter.RealEstateTypeWallID; }
            set
            {
                RealEstateFilter.RealEstateTypeWallID = value;
                OnPropertyChanged("cbFilterTypeWallIdSelected");
            }
        }

        public int? cbFilterCityIdSelected
        {
            get { return AddressFilter.AddressCityID; }
            set
            {
                AddressFilter.AddressCityID = value;
                OnPropertyChanged("cbFilterCityIdSelected");
            }
        }
        public int? cbFilterRegionIdSelected
        {
            get { return AddressFilter.AddressRegionID; }
            set
            {
                AddressFilter.AddressRegionID = value;
                OnPropertyChanged("cbFilterRegionIdSelected");
            }
        }

        public int? cbFilterStreetIdSelected
        {
            get { return AddressFilter.AddressStreetID; }
            set
            {
                AddressFilter.AddressStreetID = value;
                OnPropertyChanged("cbFilterStreetIdSelected");
            }
        }

        public RealEstatePropertyViewModel RealEstatePropertyViewModel
        {
            get { return RealEstatePropertyModel; }
            set
            {
                RealEstatePropertyModel = value;
                OnPropertyChanged("RealEstatePropertyViewModel");
            }
        }

        private ObservableCollection<RealEstateViewDTO> _realEstateDataGridSource;
        public ObservableCollection<RealEstateViewDTO> RealEstateDataGridSource
        {
            get { return _realEstateDataGridSource; }
            set { _realEstateDataGridSource = value;
                OnPropertyChanged("RealEstateDataGridSource");
            }
        }
        private int _selectIndexDataGrid;
        public int SelectIndexDataGrid
        {
            get { return _selectIndexDataGrid; }
            set
            {
                _selectIndexDataGrid = value;
                OnPropertyChanged("SelectIndexDataGrid");
            }
        }

        public RealEstateViewDTO RealEstateDataGridSelected
        {
            get { return RealEstateView; }
            set
            {
                if (SelectIndexDataGrid >= 0 && value != null)
                {
                    RealEstateView = value;
                    RealEstatePropertyViewModel.InsertTextBoxRealEstateInformation(RealEstateView);
                }
                else SelectIndexDataGrid = 0;                
            }
        }
        #endregion
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
        private DelegateCommand _changeRecord;
        public ICommand BtnChangeRecordCommand
        {
            get { return _changeRecord; }
        }
        private DelegateCommand _saveRecord;
        public ICommand BtnSaveRecordCommand
        {
            get { return _saveRecord; }
        }
        private void AccessFildsAndButton(bool viewMode, string btnChangeVisibleMode, string btnSaveVisibleMode)
        {
            IsEnableMode(viewMode);
            ChangeVisibilityMode = btnChangeVisibleMode;
            SaveVisibilityMode = btnSaveVisibleMode;
        }
        private string _saveVisibilityMode;
        public string SaveVisibilityMode
        {
            get { return _saveVisibilityMode; }
            set
            {
                _saveVisibilityMode = value;
                OnPropertyChanged("SaveVisibilityMode");
            }
        }
        private List<string> _lBoxNotification = null;
        public List<string> LBoxNotification
        {
            get { return _lBoxNotification; }
            set
            {
                _lBoxNotification = value;
                OnPropertyChanged("LBoxNotification");
            }
        }
        private async void SaveChangedRecord()
        {
            AccessFildsAndButton(false, "Visible", "Hidden");
            LBoxNotification = (await new RealEstateService().UpdateRealEstateRecord(RealEstateView.RealEstate)).Errors;
            await new AddressService().UpdateAddressRecord(RealEstateView.Address);
            ThreadPool.QueueUserWorkItem(InokeAsyncMethods);
        }
        private string _changeVisibilityMode;
        public string ChangeVisibilityMode
        {
            get { return _changeVisibilityMode; }
            set
            {
                _changeVisibilityMode = value;
                OnPropertyChanged("ChangeVisibilityMode");
            }
        }
        public RealEstateViewModel()
        {
            IsEnableMode(false);
            _changeRecord = new DelegateCommand(() => AccessFildsAndButton(true, "Hidden", "Visible"));
            _saveRecord = new DelegateCommand(SaveChangedRecord);
            filterRecords = new DelegateCommand(FilterRealEstate);
            showMainWindow = new DelegateCommand(ShowMainScreen);
            showContractWindow = new DelegateCommand(ShowContractScreen);
            _nextRecord = new DelegateCommand(BtnNext);
            _backRecord = new DelegateCommand(BtnBack);
            ThreadPool.QueueUserWorkItem(InokeAsyncMethods);
        }
        private async void InokeAsyncMethods(Object stateInfo)
        {
            List<RealEstateViewDTO> list = new List<RealEstateViewDTO>();
            if (await new RealEstateService().GetAllRealEstates() != null)
            {
                
                list = await new RealEstateService().GetAllRealEstates();
                RealEstateDataGridSource = ToObservableCollection<RealEstateViewDTO>(list);
                RealEstateView = list.FirstOrDefault();
                RealEstatePropertyViewModel = new RealEstatePropertyViewModel(RealEstateView);
            }
        }
        private void BtnNext()
        {
            if (SelectIndexDataGrid + 1 >= RealEstateDataGridSource.Count)
                SelectIndexDataGrid = RealEstateDataGridSource.Count - 1;
            else
                SelectIndexDataGrid++;
        }
        private void BtnBack()
        {
            if (SelectIndexDataGrid - 1 <= 0)
                SelectIndexDataGrid = 0;
            else
                SelectIndexDataGrid--;
        }
        private async void FilterStateRealEstate()
        {
            ObservableCollection<RealEstateViewDTO> listFilterRealEstate =
                 ToObservableCollection<RealEstateViewDTO>(
                     await new RealEstateService()
                     .GetAllFilterRealEstates(
                                new RealEstateFilterViewDTO {
                                    RealEstateFilter =new RealEstateFilterModel() { RealEstateStatusID = CheckedAccessState ? 1 : 2 },
                                    AddressFilter = AddressFilter }));
            RealEstateDataGridSource = listFilterRealEstate;
            RealEstateView = listFilterRealEstate.FirstOrDefault();
        }

        private async void FilterRealEstate()
        {
            ObservableCollection<RealEstateViewDTO> listFilterRealEstate =
                 ToObservableCollection<RealEstateViewDTO>(await new RealEstateService().GetAllFilterRealEstates(new RealEstateFilterViewDTO {RealEstateFilter= RealEstateFilter,AddressFilter= AddressFilter }));
            RealEstateDataGridSource = listFilterRealEstate;
            RealEstateView = listFilterRealEstate.FirstOrDefault();
        }
        
    }

}