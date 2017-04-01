using RealEstate.WPF.Model.Models.ModelViewDTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.ViewModel.ViewModels
{
    public class DataGridPropertyViewModel<T> : INotifyPropertyChanged where T:class
    {
        private ObservableCollection<T> DgListViewModel;
        private T ViewModel;
        public delegate void FillProperty(T Item);
        FillProperty FillProp;
        Action UserAction;
        public DataGridPropertyViewModel(FillProperty fillProp,T item, ObservableCollection<T> ListViewModel)
        {
            //FillProp = new FillProperty(new ClientViewModel().InsertTextBoxClientInformation(item));
            SelectedCurentClientDataGrid = item;
            DataGridSourceList = ListViewModel;
            FillProp = fillProp;
        }

        //--------------DataGrid       
        public ObservableCollection<T> DataGridSourceList
        {
            get { return DgListViewModel; }
            set
            {
                DgListViewModel = value;
                OnPropertyChanged("DataGridSourceList");
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
        private int _selectIndexDataGrid;

        public event PropertyChangedEventHandler PropertyChanged;

        public int SelectIndexDataGrid
        {
            get { return _selectIndexDataGrid; }
            set
            {
                _selectIndexDataGrid = value;
                OnPropertyChanged("SelectIndexDataGrid");
            }
        }

        public T SelectedCurentClientDataGrid
        {
            get { return ViewModel; }
            set
            {
                if (SelectIndexDataGrid >= 0 && value != null)
                {
                    ViewModel = value;
                    FillProp(ViewModel);
                }
                else SelectIndexDataGrid = 0;

            }
        }

        public void BtnNext()
        {
            if (SelectIndexDataGrid + 1 >= DataGridSourceList.Count)
                SelectIndexDataGrid = DataGridSourceList.Count - 1;
            else
                SelectIndexDataGrid++;
        }
        public void BtnBack()
        {
            if (SelectIndexDataGrid - 1 <= 0)
                SelectIndexDataGrid = 0;
            else
                SelectIndexDataGrid--;
        }
    }
}
