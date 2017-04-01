using RealEstate.WPF.Model.Models.ModelDTO;
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
using System.Threading.Tasks;
using System.Windows.Input;

namespace RealEstate.WPF.ViewModel.ViewModels
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<EmployeePostDTO> postsList = new ObservableCollection<EmployeePostDTO>();
        private ObservableCollection<EmployeeStatusDTO> statusesList = new ObservableCollection<EmployeeStatusDTO>();
        private EmployeeViewDTO EmployeeModel = new EmployeeViewDTO();
        private PersonPropertyViewModel<EmployeeDTO> PersonModel;
        private ObservableCollection<EmployeeViewDTO> DgListEmployees;
        private MiddleClassModel middleModel = null;
        private List<string> emplDismissList = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;

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

        
        private string _tbPasswordVisibility;
        public string TbPasswordVisibility
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
        public List<string> CbDismissDate
        {
            get { 
                return emplDismissList;
            }
            set {
                emplDismissList = value;
                OnPropertyChanged("CbDismissDate");
            }          
        }
        public string CbDismissDateSelected
        {
            get { return CbDismissDate.LastOrDefault(); }
            set
            {
                //EmployeeModel.Dismiss.DismissDate= value;
                OnPropertyChanged("CbDismissDateSelected");
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

        public EmployeeViewDTO SelectedCurentEmployeeDataGrid
        {
            get { return EmployeeModel; }
            set
            {
                if (SelectIndexDataGrid >= 0 && value != null)
                {
                    EmployeeModel = value;
                    InsertTextBoxEmployeeInformation(EmployeeModel);
                }
                else SelectIndexDataGrid = 0;

            }
        }

        private void InsertTextBoxEmployeeInformation(EmployeeViewDTO employeeModel)
        {
            EmployeePropertyViewModel = EmployeePropertyViewModel ?? new PersonPropertyViewModel<EmployeeDTO>(employeeModel);
            EmployeePropertyViewModel.InsertComboboxPersonInformation(employeeModel.Person);
            SelectedPostId = employeeModel.Person.EmployeePostID;
            SelectedStatusId = employeeModel.Person.EmployeeStatusID;
            List<string> listDism = new List<string>();
            EmployeeModel.Dismisses.ForEach(ds => listDism.Add($"{ds.EmploymentDate}-{ds.DismissDate}"));
            CbDismissDate = listDism;
            this.TbPasswordVisibility = "Hidden";
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
            
            InokeAsyncMethods();            
        }

        private async void EmploymentEmployee()
        {
            await new EmployeeService().EmploymentEmployee(EmployeeModel.Person);
        }

        private async void DismissEmployee()
        {
            await new EmployeeService().DismissEmployee(EmployeeModel.Person);
        }

        private void ChangeEmployee()
        {
            AccessFildsAndButton(true, "Hidden", "Visible");
            BtnChangeEmployeeVisibility = "Hidden";
            BtnSaveChangeVisibility = "Visible";
        }

        private async void SaveChangeEmployee()
        {
            AccessFildsAndButton(false, "Visible", "Hidden");
            await new EmployeeService().UpdateEmployeeRecord(EmployeeModel.Person);
            await new AddressService().UpdateAddressRecord(EmployeeModel.Address);
            InokeAsyncMethods();
        }

        private async void SaveNewEmployee()
        {
            AccessFildsAndButton(false, "Visible", "Hidden");
            await new EmployeeService().CreateEmployee(EmployeeModel);
            InokeAsyncMethods();
            //EmployeeModel = new EmployeeViewDTO { Address = new AddressDTO(), Person = new EmployeeDTO(), Dismisses = new List<EmployeeDismissDTO>() };
            //EmployeePropertyViewModel = new PersonPropertyViewModel<EmployeeDTO>(EmployeeModel);
            //InsertTextBoxEmployeeInformation(EmployeeModel);
        }
        private void NewEmployee()
        {
            AccessFildsAndButton(true, "Hidden", "Visible");
            EmployeeModel = new EmployeeViewDTO {Address=new AddressDTO(),Person= new EmployeeDTO(),Dismisses=new List<EmployeeDismissDTO>() };
            EmployeePropertyViewModel = new PersonPropertyViewModel<EmployeeDTO>(EmployeeModel);
            InsertTextBoxEmployeeInformation(EmployeeModel);
        }

        private async void InokeAsyncMethods()
        {
            List<EmployeeViewDTO> listEmployees = new List<EmployeeViewDTO>();
            if (await new EmployeeService().GetAllEmployees()!=null)
            {
                listEmployees = await new EmployeeService().GetAllEmployees();
                Posts = ToObservableCollection<EmployeePostDTO>(await new EmployeePostService().GetAllPosts());
                Statuses = ToObservableCollection<EmployeeStatusDTO>(await new EmployeeStatusService().GetAllStatuses());
                DataGridListEmployees = ToObservableCollection<EmployeeViewDTO>(listEmployees);
                EmployeeModel = listEmployees.FirstOrDefault();
                EmployeePropertyViewModel = new PersonPropertyViewModel<EmployeeDTO>(EmployeeModel);
                //InsertTextBoxEmployeeInformation(EmployeeModel);
            }
                
                      
        }
        private void AccessFildsAndButton(bool viewMode, string btnChangeVisibleMode, string btnSaveVisibleMode)
        {
            IsEnableMode(viewMode);
            //ChangeVisibilityMode = btnChangeVisibleMode;
            //SaveVisibilityMode = btnSaveVisibleMode;
        }
        private void IsEnableMode(bool viewMode)
        {
            ViewMode = viewMode;
            BtnViewMode = !viewMode;
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
