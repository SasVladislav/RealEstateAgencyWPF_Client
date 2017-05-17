using RealEstate.WPF.ViewModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.WPF.Model.Services;
using RealEstate.WPF.Model.Models;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows.Threading;
using RealEstate.WPF.Model.Models.ModelViewDTO;
using RealEstate.WPF.Model.Models.ModelDTO;
using RealEstate.WPF.Model.Models.ModelFilters;
using RealEstate.WPF.ViewModel.Infrastructure;
using RealEstate.WPF.ViewModel.ViewModels.PropertyViewModel;
using System.Threading;

namespace RealEstate.WPF.ViewModel.ViewModels
{
    public class ClientViewModel: INotifyPropertyChanged
    {       
        private UserViewDTO UserViewModel = new UserViewDTO();
        private PersonPropertyViewModel<UserDTO> PersonModel;
                   

        private DelegateCommand showContractWindow;      
        private DelegateCommand showMainWindow;

        public event PropertyChangedEventHandler PropertyChanged;
        public event Action ShowContractScreenAction;
        public event Action ShowMainScreenAction;             
        
        #region Commands
        public ICommand ShowContractWindow
        {
            get { return showContractWindow; }
        }
        private void ShowContractScreen()
        {
            if (ShowContractScreenAction != null)
            {
                MiddleModel = MiddleModel ?? new MiddleClassModel();
                MiddleModel.User = SelectedCurentClientDataGrid;
                ShowContractScreenAction.Invoke();
            }
        }

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

        private DelegateCommand _searchRecord;
        public ICommand SearchCommand
        {
            get { return _searchRecord; }
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

        #endregion  

        #region Properties
        private MiddleClassModel middleModel;
        public MiddleClassModel MiddleModel
        {
            get { return middleModel; }
            set
            {
                middleModel = value;
            }
        }
        
        
        public PersonPropertyViewModel<UserDTO> PersonViewModel
        {
            get { return PersonModel; }
            set
            {
                PersonModel = value;
                OnPropertyChanged("PersonViewModel");
            }
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

        private string _tbSearch;
        public string TbSearch
        {
            get { return _tbSearch; }
            set
            {
                _tbSearch = value;
                OnPropertyChanged("TbSearch");
            }
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

        //--------------DataGrid       
        ObservableCollection<UserViewDTO> dg;
        public ObservableCollection<UserViewDTO> DataGridListUsers
        {
            get { return dg; }
            set { dg = value;OnPropertyChanged("DataGridListUsers"); }
        }
        int ind;
        public int SelectIndexDataGrid
        {
            get { return ind; }
            set { ind = value; OnPropertyChanged("SelectIndexDataGrid"); }
        }

        private UserViewDTO p;
        public UserViewDTO SelectedCurentClientDataGrid
        {
            get { return p; }
            set { if (value != null) { p = value; InsertTextBoxClientInformation(p); } }
        }
        #endregion      
        public  ClientViewModel()
        {
            ThreadPool.QueueUserWorkItem(InokeAsyncMethods);
            IsEnableMode(false);
            _changeRecord      = new DelegateCommand(()=> AccessFildsAndButton(true, "Hidden", "Visible"));
            _searchRecord      = new DelegateCommand(FilterUser);
            _saveRecord        = new DelegateCommand(SaveChangedRecord);
            _nextRecord        = new DelegateCommand(BtnNext);
            _backRecord        = new DelegateCommand(BtnBack);
            showMainWindow     = new DelegateCommand(ShowMainScreen);
            showContractWindow = new DelegateCommand(ShowContractScreen);                        
        }
        private async void InokeAsyncMethods(Object stateInfo)
        {
            List<UserViewDTO> list = new List<UserViewDTO>();
            if (await new UserService().GetAllUsers() != null)
            {
                list = await new UserService().GetAllUsers();
                DataGridListUsers = ToObservableCollection<UserViewDTO>(list);
                SelectIndexDataGrid = 0;
                //UserViewModel = DataGridListUsers[SelectIndexDataGrid];
                PersonViewModel = new PersonPropertyViewModel<UserDTO>(SelectedCurentClientDataGrid??new UserViewDTO());
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

        private ObservableCollection<T> ToObservableCollection<T>(List<T> list)
        {
            var observList = new ObservableCollection<T>();
                foreach (var item in list)
                  observList.Add(item);
            return observList;
        }

        

        private async void FilterUser()
        {
            string[] splitList = TbSearch.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            List<UserViewDTO> list = await new UserService().FilterUsersRecord(
                            new UserFilterModel
                            {
                                Name = splitList.Count() >= 1 ? splitList[0] : "",
                                Surname = splitList.Count() >= 2 ? splitList[1] : "",
                                Patronumic = splitList.Count() == 3 ? splitList[2] : ""
                            });
            DataGridListUsers =  ToObservableCollection<UserViewDTO>(list);

            //UserViewModel = SelectedCurentClientDataGrid;
            SelectIndexDataGrid = 0;
            PersonViewModel = new PersonPropertyViewModel<UserDTO>(SelectedCurentClientDataGrid);
        }

        private void AccessFildsAndButton(bool viewMode,string btnChangeVisibleMode,string btnSaveVisibleMode)
        {
            IsEnableMode(viewMode);
            ChangeVisibilityMode = btnChangeVisibleMode;
            SaveVisibilityMode = btnSaveVisibleMode;
        }       

        private async void SaveChangedRecord()
        {
            AccessFildsAndButton(false, "Visible", "Hidden");
            await new UserService().UpdateUserRecord((UserDTO)PersonViewModel.GetPerson);
            await new AddressService().UpdateAddressRecord(PersonViewModel.AddressViewModel.GetAddressModel.Address);
            ThreadPool.QueueUserWorkItem(InokeAsyncMethods);
        }

        private void IsEnableMode(bool viewMode)
        {
            ViewMode = viewMode;
            BtnViewMode = !viewMode;
        }
        private void BtnNext()
        {
            if (SelectIndexDataGrid + 1 >= DataGridListUsers.Count)
                SelectIndexDataGrid = DataGridListUsers.Count - 1;
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
        public void InsertTextBoxClientInformation(UserViewDTO user)
        {
            PersonViewModel = PersonViewModel ?? new PersonPropertyViewModel<UserDTO>(user);          
            PersonViewModel.InsertComboboxPersonInformation(user.Person);
            PersonViewModel.AddressViewModel.InsertComboboxAddressInformation(user.AddressView);         
        }
    }
}
