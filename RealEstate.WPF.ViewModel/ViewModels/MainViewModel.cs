using RealEstate.WPF.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.WPF.Model.Services;
using System.ComponentModel;
using RealEstate.WPF.ViewModel.Model;
using System.Windows.Input;
using RealEstate.WPF.ViewModel.Infrastructure;

namespace RealEstate.WPF.ViewModel.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string EmployeeName = string.Empty;
        private string Visible = string.Empty;
        private MiddleClassModel middleModel = null;

        private DelegateCommand showContractWindow;
        public event Action ShowContractScreenAction;

        private DelegateCommand showClientWindow;
        public event Action ShowClientScreenAction;

        private DelegateCommand showRealEstateWindow;
        public event Action ShowRealEstateScreenAction;

        private DelegateCommand showWorkerWindow;
        public event Action ShowWorkerScreenAction;

        public ICommand ShowContractWindow
        {
            get { return showContractWindow; }
        }

        public ICommand ShowClientWindow
        {
            get { return showClientWindow; }
        }

        public ICommand ShowRealEstateWindow
        {
            get { return showRealEstateWindow; }
        }

        public ICommand ShowWorkerWindow
        {
            get { return showWorkerWindow; }
        }
        public string TbEmployeeName
        {
            get { return EmployeeName; }
            set
            {
                EmployeeName = value;
                OnPropertyChanged("TbEmployeeName");
            }
        }

        public string VisibleProp
        {
            get { return Visible; }
            set
            {
                Visible = value;
                OnPropertyChanged("Visible");
            }
        }

        public MiddleClassModel MiddleModel
        {
            get { return middleModel; }
            set { middleModel = value;
                if (MiddleModel != null)
                {
                    TbEmployeeName = MiddleModel.Employee.Person.Name ?? "";
                    VisibleProp = middleModel.Employee.Person.Role == "Admin" ? "Hidden" : "Visible";
                }
            }
        }

        public MainViewModel()
        {                 
            showContractWindow = new DelegateCommand(ShowContractScreen);
            showClientWindow = new DelegateCommand(ShowClientScreen);
            showRealEstateWindow = new DelegateCommand(ShowRealEstateScreen);
            showWorkerWindow = new DelegateCommand(ShowWorkerScreen);
        }
        public MainViewModel(MiddleClassModel middleModel)
        {
            

        }
        private void ShowContractScreen()
        {
            if (ShowContractScreenAction != null)
            {
                ShowContractScreenAction.Invoke();
            }
        }
        private void ShowClientScreen()
        {
            if (ShowClientScreenAction != null)
            {
                ShowClientScreenAction.Invoke();
            }
        }
        private void ShowRealEstateScreen()
        {
            if (ShowRealEstateScreenAction != null)
            {
                ShowRealEstateScreenAction.Invoke();
            }
        }
        private void ShowWorkerScreen()
        {
            if (ShowWorkerScreenAction != null)
            {
                ShowWorkerScreenAction.Invoke();
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
        public event PropertyChangedEventHandler PropertyChanged;


    }
}
