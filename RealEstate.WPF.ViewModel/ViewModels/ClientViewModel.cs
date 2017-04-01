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

namespace RealEstate.WPF.ViewModel.ViewModels
{
    public class ClientViewModel: INotifyPropertyChanged
    {       
        private UserViewDTO UserViewModel = new UserViewDTO();
        private PersonPropertyViewModel<UserDTO> PersonModel;
        
        private ObservableCollection<UserViewDTO> DgListUsers;       

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
                MiddleModel.User = UserViewModel;
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
        public ObservableCollection<UserViewDTO> DataGridListUsers
        {
            
            get { return DgListUsers; }
            set
            {
                DgListUsers = value;             
                OnPropertyChanged("DataGridListUsers");
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

        public UserViewDTO SelectedCurentClientDataGrid
        {
            get { return UserViewModel; }
            set
            {
                if (SelectIndexDataGrid >= 0 && value!=null)
                {
                    UserViewModel = value;
                    InsertTextBoxClientInformation(UserViewModel);
                }
                else SelectIndexDataGrid = 0;
                
            }
        }
        #endregion      

        public  ClientViewModel()
        {            
            InokeAsyncMethods();
            IsEnableMode(false);
            _changeRecord      = new DelegateCommand(()=> AccessFildsAndButton(true, "Hidden", "Visible"));
            _searchRecord      = new DelegateCommand(FilterUser);
            _saveRecord        = new DelegateCommand(SaveChangedRecord);
            _nextRecord        = new DelegateCommand(BtnNext);
            _backRecord        = new DelegateCommand(BtnBack);
            showMainWindow     = new DelegateCommand(ShowMainScreen);
            showContractWindow = new DelegateCommand(ShowContractScreen);                        
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

        private async void InokeAsyncMethods()
        {
            List<UserViewDTO> list = new List<UserViewDTO>();
            if (await new UserService().GetAllUsers()!=null)
            {
                list = await new UserService().GetAllUsers();
                DataGridListUsers = ToObservableCollection<UserViewDTO>(list);
                UserViewModel = list.FirstOrDefault();
                PersonViewModel = new PersonPropertyViewModel<UserDTO>(UserViewModel);
            }
                                                   
        }

        private async void FilterUser()
        {
            int count = 0;
            string a = "";
            string b = "";
            string c = "";
            for (int i = 0; i < TbSearch.Length; i++)
            {
                //if (TbSearch[i] == ' ' && TbSearch[i + 1] == ' ')
                    //MessageBox.Show("error");
            }
            for (int i = 0; i < TbSearch.Length; i++)
            {
                if (TbSearch[i] == ' ')
                    count++;
                else
                {
                    switch (count)
                    {
                        case (0): { a += TbSearch[i]; break; }
                        case (1): { b += TbSearch[i]; break; }
                        case (2): { c += TbSearch[i]; break; }
                    }

                }
            }
            DataGridListUsers =  ToObservableCollection<UserViewDTO>(
                           await new UserService().FilterUsersRecord(
                            new UserFilterModel { Name = a, Surname = b, Patronumic = c }));
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
            await new UserService().UpdateUserRecord(UserViewModel.Person);
            await new AddressService().UpdateAddressRecord(UserViewModel.Address);
            InokeAsyncMethods();
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
        }
    }
}
