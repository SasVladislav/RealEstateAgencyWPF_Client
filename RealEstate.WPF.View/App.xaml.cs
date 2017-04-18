
using RealEstate.WPF.ViewModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RealEstate.WPF.View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            try
            {
                
                AccountViewModel accountVM = new AccountViewModel();
                MainViewModel mainVM = new MainViewModel();
                ContractViewModel contractVM = new ContractViewModel();
                ClientViewModel clientVM = new ClientViewModel();
                RealEstateViewModel realEstateVM = new RealEstateViewModel();
                EmployeeViewModel employeeVM = new EmployeeViewModel();
                MainWindow mainView = null;
                AccountWindow accountView = null;
                ContractWindow contractView = null;
                ClientWindow clientView = null;
                RealEstateWindow realEstateView = null;
                EmployeeWindow employeeView = null;
                // open the Users screen
                mainVM.ShowContractScreenAction += () =>
                {
                    contractView=NavigationWindows.CreateContractWindow(mainView, contractView, contractVM, mainVM.MiddleModel);
                };

                mainVM.ShowClientScreenAction += () =>
                {
                    clientView=NavigationWindows.CreateUserWindow(mainView, clientView, clientVM, mainVM.MiddleModel);                    
                };

                mainVM.ShowRealEstateScreenAction += () =>
                {
                    realEstateView = NavigationWindows.CreateRealEstateWindow(mainView, realEstateView, realEstateVM, mainVM.MiddleModel);                   
                };

                mainVM.ShowWorkerScreenAction += () =>
                {
                    employeeView = NavigationWindows.CreateEmployeeWindow(mainView, employeeView, employeeVM, mainVM.MiddleModel);                   
                };
                accountVM.ShowMainScreenAction += () =>
                {
                    mainView = NavigationWindows.CreateMainWindow(accountView, mainView, mainVM, accountVM.MiddleModel);                   
                };

                clientVM.ShowContractScreenAction += () =>
                {
                    contractView = NavigationWindows.CreateContractWindow(clientView, contractView, contractVM, clientVM.MiddleModel);
                };
                clientVM.ShowMainScreenAction += () =>
                {
                    mainView = NavigationWindows.CreateMainWindow(clientView, mainView, mainVM, clientVM.MiddleModel);
                };
                realEstateVM.ShowContractScreenAction += () =>
                {
                    contractView = NavigationWindows.CreateContractWindow(realEstateView, contractView, contractVM, realEstateVM.MiddleModel);
                };
                realEstateVM.ShowMainScreenAction += () =>
                {
                    mainView = NavigationWindows.CreateMainWindow(realEstateView, mainView, mainVM, realEstateVM.MiddleModel);
                };
                contractVM.ShowMainScreenAction += () =>
                {
                    mainView = NavigationWindows.CreateMainWindow(contractView, mainView, mainVM, contractVM.MiddleModel);
                };
                contractVM.ShowUserScreenAction += () =>
                {
                    clientView = NavigationWindows.CreateUserWindow(contractView, clientView, clientVM, contractVM.MiddleModel);
                };
                contractVM.ShowRealEstateScreenAction += () =>
                {
                    realEstateView = NavigationWindows.CreateRealEstateWindow(contractView, realEstateView, realEstateVM, contractVM.MiddleModel);
                };
                employeeVM.ShowMainScreenAction += () =>
                 {
                mainView = NavigationWindows.CreateMainWindow(employeeView,mainView,mainVM,employeeVM.MiddleModel);
                 };
                employeeVM.ShowContractScreenAction += () =>
                 {
                     contractView = NavigationWindows.CreateContractWindow(employeeView,contractView,contractVM,employeeVM.MiddleModel);
                 };
                //mainView = new MainWindow();
                //mainView.DataContext = mainVM;
                //mainView.Show();

                accountView = new AccountWindow();
                accountView.DataContext = accountVM;
                accountView.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
                Application.Current.Shutdown();
            }
        }
    }
}
