using RealEstate.WPF.Model.Models.ModelDTO;
using RealEstate.WPF.Model.Models.ModelFilters;
using RealEstate.WPF.Model.Models.ModelViewDTO;
using RealEstate.WPF.Model.Services;
using RealEstate.WPF.ViewModel.Infrastructure;
using RealEstate.WPF.ViewModel.Model;
using RealEstate.WPF.ViewModel.ViewModels.PropertyViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RealEstate.WPF.ViewModel.ViewModels
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<EmployeePostDTO> postsList = new ObservableCollection<EmployeePostDTO>();
        private ObservableCollection<EmployeeStatusDTO> statusesList = new ObservableCollection<EmployeeStatusDTO>();
        private EmployeeViewDTO EmployeeModel = new EmployeeViewDTO();
        private ContractViewDTO ContractModel = new ContractViewDTO();
        private PersonPropertyViewModel<EmployeeDTO> PersonModel;
        private ObservableCollection<EmployeeViewDTO> DgListEmployees;
        private ObservableCollection<ContractViewDTO> DgListContracts;
        private MiddleClassModel middleModel = null;
        private List<string> emplDismissList = new List<string>();


        #region Commands
        public event PropertyChangedEventHandler PropertyChanged;

        private DelegateCommand _ShowMainWindow;
        public event Action ShowMainScreenAction;
        public ICommand ShowMainWindow
        {
            get { return _ShowMainWindow; }
        }

        private void ShowMainScreen()
        {
            if (ShowMainScreenAction != null)
            {
                MiddleModel = MiddleModel ?? new MiddleClassModel();
                ShowMainScreenAction.Invoke();
            }
        }

        private DelegateCommand _ShowContractWindow;
        public event Action ShowContractScreenAction;
        public ICommand ShowContractWindow
        {
            get { return _ShowContractWindow; }
        }

        private void ShowContractScreen()
        {
            if (ShowContractScreenAction != null)
            {
                MiddleModel = MiddleModel ?? new MiddleClassModel();
                ShowContractScreenAction.Invoke();
            }
        }
        private DelegateCommand _searchRecord;
        public ICommand SearchCommand
        {
            get { return _searchRecord; }
        }
        private DelegateCommand _NewRecord;       
        public ICommand BtnNewEmployeeCommand
        {
            get { return _NewRecord; }
        }
        private DelegateCommand _SaveNewRecord;
        public ICommand BtnSaveNewEmployeeCommand
        {
            get { return _SaveNewRecord; }
        }
        private DelegateCommand _BtnSaveChangeEmployee;
        public ICommand BtnSaveChangeEmployeeCommand
        {
            get { return _BtnSaveChangeEmployee; }
        }
        private DelegateCommand _BtnChangeEmployee;
        public ICommand BtnChangeEmployeeCommand
        {
            get { return _BtnChangeEmployee; }
        }
        private DelegateCommand _BtnDismissEmployee;
        public ICommand BtnDismissEmployeeCommand
        {
            get { return _BtnDismissEmployee; }
        }
        private DelegateCommand _BtnEmploymentEmployee;
        public ICommand BtnEmploymentEmployeeCommand
        {
            get { return _BtnEmploymentEmployee; }
        }
        #endregion

        #region Properties
        public PersonPropertyViewModel<EmployeeDTO> EmployeePropertyViewModel
        {
            get { return PersonModel; }
            set
            {
                PersonModel = value;
                OnPropertyChanged("EmployeePropertyViewModel");
            }
        }

        public MiddleClassModel MiddleModel
        {
            get { return middleModel; }
            set
            {
                middleModel = value;
            }
        }
        private string _btnSaveChangeVisibility;
        public string BtnSaveChangeVisibility
        {
            get { return _btnSaveChangeVisibility; }
            set { _btnSaveChangeVisibility = value;
                OnPropertyChanged("BtnSaveChangeVisibility");
            }
        }

        private string _btnChangeEmployeeVisibility;
        public string BtnChangeEmployeeVisibility
        {
            get { return _btnChangeEmployeeVisibility; }
            set
            {
                _btnChangeEmployeeVisibility = value;
                OnPropertyChanged("BtnChangeEmployeeVisibility");
            }
        }

        private string _btnDismissVisibility;
        public string BtnDismissVisibility
        {
            get { return _btnDismissVisibility; }
            set
            {
                _btnDismissVisibility = value;
                OnPropertyChanged("BtnDismissVisibility");
            }
        }

        
        private Visibility _tbPasswordVisibility;
        public Visibility TbPasswordVisibility
        {
            get { return _tbPasswordVisibility; }
            set
            {
                _tbPasswordVisibility = value;
                OnPropertyChanged("TbPasswordVisibility");
            }
        }
        private string _btnEmploymentVisibility;
        public string BtnEmploymentVisibility
        {
            get { return _btnEmploymentVisibility; }
            set
            {
                _btnEmploymentVisibility = value;
                OnPropertyChanged("BtnEmploymentVisibility");
            }
        }
        private string _btnNewEmployeeVisibility;
        public string BtnNewEmployeeVisibility
        {
            get { return _btnNewEmployeeVisibility; }
            set
            {
                _btnNewEmployeeVisibility = value;
                OnPropertyChanged("BtnNewEmployeeVisibility");
            }
        }
        private string _btnSaveNewEmployeeVisibility;
        public string BtnSaveNewEmployeeVisibility
        {
            get { return _btnSaveNewEmployeeVisibility; }
            set
            {
                _btnSaveNewEmployeeVisibility = value;
                OnPropertyChanged("BtnSaveNewEmployeeVisibility");
            }
        }

        private bool _isEnabledForFields;
        public bool IsEnabledForFields
        {
            get { return _isEnabledForFields; }
            set
            {
                _isEnabledForFields = value;
                OnPropertyChanged("IsEnabledForFields");
            }
        }
        
        private bool _isEnableChangeBtn;
        public bool IsEnableChangeBtn
        {
            get { return _isEnableChangeBtn; }
            set
            {
                _isEnableChangeBtn = value;
                OnPropertyChanged("IsEnableChangeBtn");
            }
        }

        private bool _isEnableNewBtn;
        public bool IsEnableNewBtn
        {
            get { return _isEnableNewBtn; }
            set
            {
                _isEnableNewBtn = value;
                OnPropertyChanged("IsEnableNewBtn");
            }
        }
        private bool _isEnableDismissBtn;
        public bool IsEnableDismissBtn
        {
            get { return _isEnableDismissBtn; }
            set
            {
                _isEnableDismissBtn = value;
                OnPropertyChanged("IsEnableDismissBtn");
            }
        }
        public ObservableCollection<EmployeePostDTO> Posts
        {
            get { return postsList; }
            set
            {
                postsList = value;
                OnPropertyChanged("Posts");
            }
        }

        public int SelectedPostId
        {
            get { return EmployeeModel.Person.EmployeePostID; }
            set
            {
                EmployeeModel.Person.EmployeePostID = value;
                OnPropertyChanged("SelectedPostId");
            }
        }
        private int _selectFilterPost;
        public int SelectedFilterPostId
        {
            get { return _selectFilterPost; }
            set
            {
                _selectFilterPost = value;
                FilterByPost(_selectFilterPost);
                OnPropertyChanged("SelectedFilterPostId");
            }
        }

        public List<string> CbDismissDate
        {
            get
            {
                return emplDismissList;
            }
            set
            {
                emplDismissList = value;
                OnPropertyChanged("CbDismissDate");
            }
        }
        private string SelectFire;
        public string CbDismissDateSelected
        {
            get { return SelectFire; }
            set
            {
                SelectFire = value;
                OnPropertyChanged("CbDismissDateSelected");
            }
        }
        private string tbSearch;
        public string TbSearch
        {
            get { return tbSearch; }
            set
            {
                tbSearch = value;
                OnPropertyChanged("TbSearch");
            }
        }
        public ObservableCollection<EmployeeStatusDTO> Statuses
        {
            get { return statusesList; }
            set
            {
                statusesList = value;
                OnPropertyChanged("Statuses");
            }
        }

        public int SelectedStatusId
        {
            get { return EmployeeModel.Person.EmployeeStatusID; }
            set
            {
                EmployeeModel.Person.EmployeeStatusID = value;
                OnPropertyChanged("SelectedStatusId");
            }
        }
        //--------------DataGrid       
        public ObservableCollection<EmployeeViewDTO> DataGridListEmployees
        {
            get { return DgListEmployees; }
            set
            {
                DgListEmployees = value;
                OnPropertyChanged("DataGridListEmployees");
            }
        }

        private int _selectIndexEmployeeDataGrid;
        public int SelectIndexEmployeeDataGrid
        {
            get { return _selectIndexEmployeeDataGrid; }
            set
            {
                _selectIndexEmployeeDataGrid = value;
                OnPropertyChanged("SelectIndexEmployeeDataGrid");
            }
        }

        public EmployeeViewDTO SelectedCurentEmployeeDataGrid
        {
            get { return EmployeeModel; }
            set
            {
                if (value != null)
                {
                    EmployeeModel = value;
                    InsertTextBoxEmployeeInformation(EmployeeModel);
                }

            }
        }
        //--------------DataGridContract--------------       
        public ObservableCollection<ContractViewDTO> DataGridListContracts
        {
            get { return DgListContracts; }
            set
            {
                DgListContracts = value;
                OnPropertyChanged("DataGridListContracts");
            }
        }

        private int _selectIndexContractDataGrid;
        public int SelectIndexContractDataGrid
        {
            get { return _selectIndexContractDataGrid; }
            set
            {
                _selectIndexContractDataGrid = value;
                OnPropertyChanged("SelectIndexContractDataGrid");
            }
        }

        public ContractViewDTO SelectedCurentContractDataGrid
        {
            get { return ContractModel; }
            set
            {
                if (value != null)
                {
                    ContractModel = value;
                }

            }
        }

        #endregion

        private async void FilterByPost(int postId)
        {
            List<EmployeeViewDTO> list = await new EmployeeService().FilterEmployeesRecord(
                                        new EmployeeFilterModel
                                        {
                                            EmployeePostID = postId
                                        });
            DataGridListEmployees = ToObservableCollection<EmployeeViewDTO>(list);
            EmployeeModel = SelectedCurentEmployeeDataGrid;
            EmployeePropertyViewModel = new PersonPropertyViewModel<EmployeeDTO>(SelectedCurentEmployeeDataGrid);
        }
        

        private void InsertTextBoxEmployeeInformation(EmployeeViewDTO employeeModel)
        {
            EmployeePropertyViewModel = EmployeePropertyViewModel ?? new PersonPropertyViewModel<EmployeeDTO>(employeeModel);
            EmployeePropertyViewModel.InsertComboboxPersonInformation(employeeModel.Person);
            EmployeePropertyViewModel.AddressViewModel.InsertComboboxAddressInformation(employeeModel.AddressView);

            SelectedPostId = employeeModel.Person.EmployeePostID;
            SelectedStatusId = employeeModel.Person.EmployeeStatusID;

            List<string> listDism = new List<string>();
            EmployeeModel.Dismisses.ForEach(ds => listDism.Add($"{ds.EmploymentDate}-{ds.DismissDate}"));
            CbDismissDate = listDism;
            CbDismissDateSelected = listDism.LastOrDefault();

            this.TbPasswordVisibility = Visibility.Hidden;
            this.BtnChangeEmployeeVisibility = "Visible";
            this.BtnSaveChangeVisibility = "Hidden";

            this.BtnDismissVisibility = EmployeeModel.Person.EmployeeStatusID == 1 ? "Visible" : "Hidden";
            this.BtnEmploymentVisibility = EmployeeModel.Person.EmployeeStatusID == 2 ? "Visible" : "Hidden";
        }

        public EmployeeViewModel()
        {
            this._NewRecord = new DelegateCommand(NewEmployee);
            this._SaveNewRecord = new DelegateCommand(SaveNewEmployee);
            this._BtnSaveChangeEmployee = new DelegateCommand(SaveChangeEmployee);
            this._BtnChangeEmployee = new DelegateCommand(ChangeEmployee);
            this._BtnDismissEmployee = new DelegateCommand(DismissEmployee);
            this._BtnEmploymentEmployee = new DelegateCommand(EmploymentEmployee);
            this._ShowMainWindow = new DelegateCommand(ShowMainScreen);
            this._ShowContractWindow = new DelegateCommand(ShowContractScreen);
            this._searchRecord = new DelegateCommand(FilterUser);
            ThreadPool.QueueUserWorkItem(InokeAsyncMethods);

        }
        private async void InokeAsyncMethods(Object stateInfo)
        {
            List<EmployeeViewDTO> listEmployees = new List<EmployeeViewDTO>();
            if (await new EmployeeService().GetAllEmployees() != null)
            {
                listEmployees = await new EmployeeService().GetAllEmployees();
                Posts = ToObservableCollection<EmployeePostDTO>(await new EmployeePostService().GetAllPosts());
                Statuses = ToObservableCollection<EmployeeStatusDTO>(await new EmployeeStatusService().GetAllStatuses());
                DataGridListEmployees = ToObservableCollection<EmployeeViewDTO>(listEmployees);
                //EmployeeModel = SelectedCurentEmployeeDataGrid;
                SelectIndexEmployeeDataGrid = 0;
                EmployeePropertyViewModel = new PersonPropertyViewModel<EmployeeDTO>(SelectedCurentEmployeeDataGrid ?? new EmployeeViewDTO());
                AccessFildsAndButton(false);
                DataGridListContracts = ToObservableCollection<ContractViewDTO>(await new ContractService().GetAllContractsView());
                SelectIndexContractDataGrid = 0;
            }
        }
        private async void EmploymentEmployee()
        {
            await new EmployeeService().EmploymentEmployee(EmployeeModel.Person);
            ThreadPool.QueueUserWorkItem(InokeAsyncMethods);
        }

        private async void DismissEmployee()
        {
            await new EmployeeService().DismissEmployee(EmployeeModel.Person);
            ThreadPool.QueueUserWorkItem(InokeAsyncMethods);
        }

        private void ChangeEmployee()
        {
            AccessFildsAndButton(true);
            IsEnableChangeBtn = true;
            BtnChangeEmployeeVisibility = "Hidden";
            BtnSaveChangeVisibility = "Visible";
        }

        private async void SaveChangeEmployee()
        {
            AccessFildsAndButton(false);
            EmployeeDTO emp = (EmployeeDTO)EmployeePropertyViewModel.GetPerson;
            emp.EmployeePostID = SelectedPostId;
            emp.EmployeeStatusID = SelectedStatusId;
            await new EmployeeService().UpdateEmployeeRecord(emp);
            await new AddressService().UpdateAddressRecord(EmployeePropertyViewModel.AddressViewModel.GetAddressModel.Address);
            ThreadPool.QueueUserWorkItem(InokeAsyncMethods);
        }
        
        private async void FilterUser()
        {
            string[] splitList = TbSearch.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            List<EmployeeViewDTO> list = await new EmployeeService().FilterEmployeesRecord(
                            new EmployeeFilterModel
                            {
                                Name = splitList.Count() >= 1 ? splitList[0] : "",
                                Surname = splitList.Count() >= 2 ? splitList[1] : "",
                                Patronumic = splitList.Count() == 3 ? splitList[2] : "",
                                EmployeePostID = SelectedFilterPostId !=0? SelectedFilterPostId:0
                            });
            DataGridListEmployees = ToObservableCollection<EmployeeViewDTO>(list);
            SelectIndexEmployeeDataGrid = 0;
            //EmployeeModel = SelectedCurentEmployeeDataGrid;
            EmployeePropertyViewModel = new PersonPropertyViewModel<EmployeeDTO>(SelectedCurentEmployeeDataGrid);
        }
        private void NewEmployee()
        {
            AccessFildsAndButton(true);
            IsEnableNewBtn = true;            
            BtnNewEmployeeVisibility = "Hidden";
            BtnSaveNewEmployeeVisibility = "Visible";
            EmployeeModel = new EmployeeViewDTO {AddressView=new AddressViewDTO(),Person= new EmployeeDTO(),Dismisses=new List<EmployeeDismissDTO>() };
            EmployeePropertyViewModel = new PersonPropertyViewModel<EmployeeDTO>(EmployeeModel);
            InsertTextBoxEmployeeInformation(EmployeeModel);
            TbPasswordVisibility = Visibility.Visible;
        }
        private async void SaveNewEmployee()
        {
            AccessFildsAndButton(false);
            await new EmployeeService().CreateEmployee(EmployeeModel);
            ThreadPool.QueueUserWorkItem(InokeAsyncMethods);
        }

        private void AccessFildsAndButton(bool viewMode)
        {
            IsEnableMode(viewMode);
        }
        private void IsEnableMode(bool viewMode)
        {
            IsEnabledForFields = viewMode;
            IsEnableChangeBtn = !viewMode;
            IsEnableNewBtn = !viewMode;
            IsEnableDismissBtn = !viewMode;
        }
        private ObservableCollection<T> ToObservableCollection<T>(List<T> list)
        {
            var observList = new ObservableCollection<T>();
            foreach (var item in list)
                observList.Add(item);
            return observList;
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
