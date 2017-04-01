using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.WPF.Model.Services;
using RealEstate.WPF.Model.Interfaces;
using RealEstate.WPF.Model.Models;
using System.ComponentModel;
using System.Windows.Input;
using RealEstate.WPF.ViewModel.Model;
using RealEstate.WPF.Model.Models.ModelDTO;
using RealEstate.WPF.Model.Models.ModelFilters;
using RealEstate.WPF.ViewModel.Infrastructure;
using RealEstate.WPF.Model.Models.ModelViewDTO;

namespace RealEstate.WPF.ViewModel.ViewModels
{
    public class AccountViewModel :  INotifyPropertyChanged
    {
        public ICommand MainCommand { get; set; }
        private ButtonCommand objCommand;
        private LoginDto login = new LoginDto();
        private AccountService service;
        private List<string> _lBoxNotification = null;
        private MiddleClassModel middleModel= null;


        private DelegateCommand showMainWindow;
        public event Action ShowMainScreenAction;
        public event PropertyChangedEventHandler PropertyChanged;

       

        public string TbEmail
        {
            get { return login.Email; }
            set { login.Email = value; }
        }

        public string TbPassword
        {
            get { return login.Password; }
            set { login.Password = value; }
        }

        public List<string> LBoxNotification
        {
            get { return _lBoxNotification; }
            set { _lBoxNotification = value;
                OnPropertyChanged("LBoxNotification");
            }
        }

        public ICommand ShowMainWindow
        {
            get { return showMainWindow; }
        }

        protected void OnPropertyChanged(string _lBoxNotification)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(_lBoxNotification));
            }
        }
        public MiddleClassModel MiddleModel
        {
            get { return middleModel; }
            set { middleModel = value; }
        }

        public AccountViewModel()
        {
            MiddleModel = new MiddleClassModel();
            objCommand = new ButtonCommand(this);
            service = new AccountService();
            showMainWindow = new DelegateCommand(ShowMainScreen);
        }

        private void ShowMainScreen()
        {
            if (ShowMainScreenAction != null)
            {
                ShowMainScreenAction.Invoke();
            }
        }

        public async void Authorized()
        {
            ResponsePackage<EmployeeDTO> responsePackage = await service.IsAuthorized(login);
            if (responsePackage.Errors.Count == 0)
            {
                MiddleModel = new MiddleClassModel()
                {
                    Employee = new EmployeeViewDTO { Person= responsePackage.Result }/*new EmployeeDTO() { Name="Suric"}*///
                };

            ShowMainScreen();
            }
            else
            {
                LBoxNotification = responsePackage.Errors;
            }
        }
        public ICommand btnClick
        {
            get { return objCommand; }
        }       
    }
}

