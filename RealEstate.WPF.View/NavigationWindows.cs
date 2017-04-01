using RealEstate.WPF.ViewModel.Model;
using RealEstate.WPF.ViewModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using static System.Net.Mime.MediaTypeNames;

namespace RealEstate.WPF.View
{
    public static class NavigationWindows
    {
        public static MainWindow CreateMainWindow(Window currentWindowView, MainWindow mainView, MainViewModel mainVM, MiddleClassModel MiddleModel)
        {
            try
            {
                //MainViewModel mainVMi = new MainViewModel(accountVM.MiddleModel);
                // ensure only one view is loaded, and the same one remains open for multiple requests

                mainView = mainView ?? new MainWindow();

                if (!mainView.IsLoaded)
                {
                    mainView.Close();
                    mainView = new MainWindow();
                    mainVM.MiddleModel = MiddleModel;//---------------
                    mainView.DataContext = mainVM;

                    currentWindowView.Close();
                }

                mainView.Show();
                return mainView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
                Application.Current.Shutdown();
                return null;
            }
        }
        public static ContractWindow CreateContractWindow(Window currentWindowView, ContractWindow contractView, ContractViewModel contractVM, MiddleClassModel MiddleModel)
        {
            try
            {
                // ensure only one view is loaded, and the same one remains open for multiple requests
                contractView = contractView ?? new ContractWindow();

                if (!contractView.IsLoaded)
                {
                    contractView.Close();
                    contractView = new ContractWindow();
                    contractVM.MiddleModel = MiddleModel;
                    contractView.DataContext = contractVM;
                    currentWindowView.Close();
                }
                
                contractView.Show();
                return contractView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
                //System.Net.Mime.MediaTypeNames.Application.Current.Shutdown();
                return null;
            }
        }
        public static ClientWindow CreateUserWindow(Window currentWindowView, ClientWindow userView, ClientViewModel clientVM, MiddleClassModel MiddleModel)
        {
            try
            {
                // ensure only one view is loaded, and the same one remains open for multiple requests
                userView = userView ?? new ClientWindow();

                if (!userView.IsLoaded)
                {
                    userView.Close();
                    userView = new ClientWindow();
                    clientVM.MiddleModel = MiddleModel;
                    userView.DataContext = clientVM;
                    currentWindowView.Close();
                }

                userView.Show();
                return userView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
                //Application.Current.Shutdown();
                return userView;
            }
        }

        public static RealEstateWindow CreateRealEstateWindow(Window currentWindowView, RealEstateWindow realEstateView, RealEstateViewModel realEstateVM, MiddleClassModel MiddleModel)
        {
            try
            {
                // ensure only one view is loaded, and the same one remains open for multiple requests
                realEstateView = realEstateView ?? new RealEstateWindow();

                if (!realEstateView.IsLoaded)
                {
                    realEstateView.Close();
                    realEstateView = new RealEstateWindow();
                    realEstateVM.MiddleModel = MiddleModel;
                    realEstateView.DataContext = realEstateVM;
                    currentWindowView.Close();
                }

                realEstateView.Show();
                return realEstateView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
                //Application.Current.Shutdown();
                return realEstateView;
            }
        }
        public static EmployeeWindow CreateEmployeeWindow(Window currentWindowView, EmployeeWindow employeeView, EmployeeViewModel workerVM, MiddleClassModel MiddleModel)
        {
            try
            {
                // ensure only one view is loaded, and the same one remains open for multiple requests
                employeeView = employeeView ?? new EmployeeWindow();

                if (!employeeView.IsLoaded)
                {
                    employeeView.Close();
                    employeeView = new EmployeeWindow();
                    workerVM.MiddleModel = MiddleModel;
                    employeeView.DataContext = workerVM;
                    currentWindowView.Close();
                }

                employeeView.Show();
                return employeeView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
                //Application.Current.Shutdown();
                return employeeView;
            }
        }               
    }
}
