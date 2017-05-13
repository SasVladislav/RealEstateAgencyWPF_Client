using RealEstate.WPF.Model.Models.ModelDTO;
using RealEstate.WPF.Model.Models.ModelViewDTO;
using RealEstate.WPF.Model.Services;
using RealEstate.WPF.ViewModel.Infrastructure;
using RealEstate.WPF.ViewModel.Model;
using RealEstate.WPF.ViewModel.ViewModels.PropertyViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RealEstate.WPF.ViewModel.ViewModels
{
    public class ContractViewModel : INotifyPropertyChanged
    {
        private PersonPropertyViewModel<UserDTO> PersonModel; 
        private PersonPropertyViewModel<EmployeeDTO> PersonEmployeeModel;
        private RealEstatePropertyViewModel RealEstatePropertyModel;
        private MiddleClassModel middleModel = null;
        private string _tbPost = "";
        public event PropertyChangedEventHandler PropertyChanged;
        private ContractDTO Contract = new ContractDTO();
        public MiddleClassModel MiddleModel
        {
            get { return middleModel; }
            set
            {
                middleModel = value;

                PersonViewModel = new PersonPropertyViewModel<UserDTO>(MiddleModel.User ?? new UserViewDTO() {Person = new UserDTO(), Address =new AddressDTO() });               
                RealEstatePropertyModel = new RealEstatePropertyViewModel(MiddleModel.RealEstate ?? new RealEstateViewDTO { RealEstate = new RealEstateDTO(), Address = new AddressDTO() });
                RealEstatePropertyViewModel.InsertTextBoxRealEstateInformation(MiddleModel.RealEstate ?? new RealEstateViewDTO { RealEstate = new RealEstateDTO(), Address = new AddressDTO() });
                if (middleModel.Employee != null)
                {
                    PersonViewEmployeeModel = new PersonPropertyViewModel<EmployeeDTO>(MiddleModel.Employee??new EmployeeViewDTO {Person=new EmployeeDTO(),Address=new AddressDTO(),Dismisses=new List<EmployeeDismissDTO>() });
                    ThreadPool.QueueUserWorkItem(InokeAsyncMethods);
                }                                
            }
        }
        private DelegateCommand saveContract;
        public ICommand SaveContract
        {
            get { return saveContract; }
        }
        public event Action ShowMainScreenAction;
        private DelegateCommand showMainWindow;
        public ICommand ShowMainWindow
        {
            get { return showMainWindow; }
        }
        public event Action ShowRealEstateScreenAction;
        private DelegateCommand showRealEstateWindow;
        public ICommand ShowRealEstateWindow
        {
            get { return showRealEstateWindow; }
        }
        public event Action ShowUserScreenAction;
        private DelegateCommand showUserWindow;
        public ICommand ShowUserWindow
        {
            get { return showUserWindow; }
        }
        public string TbPost
        {
            get { return _tbPost; }
            set
            {
                _tbPost = value;
                OnPropertyChanged("TbPost");
            }
        }
        public string TbDateContract
        {
            get { return Contract.RecordDate; }
            set
            {
                Contract.RecordDate = value;
                OnPropertyChanged("TbDateContract");
            }
        }
        string _tbTypeContract;
        public string TbTypeContract
        {
            get { return _tbTypeContract; }
            set
            {
                _tbTypeContract = value;
                OnPropertyChanged("TbTypeContract");
            }
        }
        bool _viewModeRealEstate;
        public bool ViewModeRealEstate
        {
            get { return _viewModeRealEstate; }
            set
            {
                _viewModeRealEstate = value;
                OnPropertyChanged("ViewModeRealEstate");
            }
        }
        bool _viewModeUser;
        public bool ViewModeUser
        {
            get { return _viewModeUser; }
            set
            {
                _viewModeUser = value;
                OnPropertyChanged("ViewModeUser");
            }
        }
        private void ShowMainScreen()
        {
            if (ShowMainScreenAction != null)
            {
                ShowMainScreenAction.Invoke();
            }
        }
        private void ShowRealEstateScreen()
        {
            if (ShowRealEstateScreenAction != null)
            {
                ShowRealEstateScreenAction.Invoke();
            }
        }
        private void ShowUserScreen()
        {
            if (ShowUserScreenAction != null)
            {
                ShowUserScreenAction.Invoke();
            }
        }
        public PersonPropertyViewModel<UserDTO> PersonViewModel {
            get { return PersonModel; }
            set {
                PersonModel = value;
                OnPropertyChanged("PersonViewModel");
            }
        }
        public PersonPropertyViewModel<EmployeeDTO> PersonViewEmployeeModel
        {
            get { return PersonEmployeeModel; }
            set
            {
                PersonEmployeeModel = value;
                OnPropertyChanged("PersonEmployeeModel");
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
        public ContractViewModel()
        {
            showMainWindow = new DelegateCommand(ShowMainScreen);
            showRealEstateWindow = new DelegateCommand(ShowRealEstateScreen);
            showUserWindow = new DelegateCommand(ShowUserScreen);
            saveContract = new DelegateCommand(SaveContractMethod);
        }

        private async void SaveContractMethod()
        {
            Contract.EmployeeID = MiddleModel.Employee.Person.PersonId;

            Contract.SellerID = MiddleModel.User!=null? MiddleModel.User.Person.PersonId:await new UserService().CreateUser(new UserViewDTO() {
                                                                                                                                                Person =(UserDTO)PersonViewModel.GetPerson,
                                                                                                                                                Address=PersonViewModel.AddressViewModel.GetAddressModel});

            Contract.RealEstateID = MiddleModel.RealEstate != null ? MiddleModel.RealEstate.RealEstate.RealEstateID : await new RealEstateService().CreateRealEstate(
                                                                                                                                                RealEstatePropertyViewModel.GetRealEstate);

            await new ContractService().CreateContract(Contract);
        }

        private async void InokeAsyncMethods(Object stateInfo)
        {
            
            ViewModeUser = MiddleModel.User != null ? false : true;
            ViewModeRealEstate = MiddleModel.RealEstate != null ? false : true;
            TbDateContract=DateTime.Now.ToShortDateString();
            ContractTypeDTO contractType = (await new ContractTypeService().GetAllContractTypes()).Where(c => c.ContractTypeID == (MiddleModel.RealEstate != null ? 1 : 2)).FirstOrDefault();
            TbTypeContract = contractType.ContractTypeName;
            Contract.ContractTypeID = contractType.ContractTypeID;
            TbPost = (await new EmployeePostService().GetAllPosts())
                .Where(ep => ep.EmployeePostID == MiddleModel.Employee.Person.EmployeePostID)
                .FirstOrDefault()
                .EmployeePostName;
        }
        public ContractViewModel(MiddleClassModel middleModel)
        {
            MiddleModel = middleModel;           
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
