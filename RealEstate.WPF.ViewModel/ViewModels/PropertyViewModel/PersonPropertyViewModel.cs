using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.WPF.Model.Models.ModelDTO;
using System.ComponentModel;
using RealEstate.WPF.Model.Models.ModelViewDTO;

namespace RealEstate.WPF.ViewModel.ViewModels.PropertyViewModel
{
    public class PersonPropertyViewModel<T>: INotifyPropertyChanged
    {
        private PersonAbstractDTO PersonModel;
        public event PropertyChangedEventHandler PropertyChanged;
        private AddressPropertyViewModel AddressModel;
        
        public PersonPropertyViewModel(AbstractPersonViewModel<T> userViewModel)
        {
            PersonModel = userViewModel.Person as PersonAbstractDTO;
            InsertComboboxPersonInformation(userViewModel);           
        }
        public PersonAbstractDTO GetPerson {
            get
            {
                return PersonModel;
            }
        }
        public AddressPropertyViewModel AddressViewModel
        {
            get { return AddressModel; }
            set
            {
                AddressModel = value;
                OnPropertyChanged("AddressViewModel");
            }
        }

        public string TbName
        {
            get { return PersonModel.Name; }
            set
            {
                PersonModel.Name = value;
                OnPropertyChanged("TbName");
            }
        }

        public string TbSurname
        {
            get { return PersonModel.Surname; }
            set
            {
                PersonModel.Surname = value;
                OnPropertyChanged("TbSurname");
            }
        }

        public string TbPatronumic
        {
            get { return PersonModel.Patronumic; }
            set
            {
                PersonModel.Patronumic = value;
                OnPropertyChanged("TbPatronumic");
            }
        }
        
        public string TbPassport
        {
            get { return PersonModel.PassportNumber; }
            set
            {
                PersonModel.PassportNumber = value;
                OnPropertyChanged("TbPassport");
            }
        }
        public int TbPhoneNumber
        {
            get { return PersonModel.PhoneNumber; }
            set
            {
                PersonModel.PhoneNumber = value;
                OnPropertyChanged("TbPhoneNumber");
            }
        }

        public string TbEmail
        {
            get { return PersonModel.Email; }
            set
            {
                PersonModel.Email = value;
                OnPropertyChanged("TbEmail");
            }
        }
        public string TbPassword
        {
            get { return PersonModel.Password; }
            set
            {
                PersonModel.Password = value;
                OnPropertyChanged("TbPassword");
            }
        }
        public string TbRole
        {
            get { return PersonModel.Role; }
            set
            {
                PersonModel.Role = value;
                OnPropertyChanged("TbRole");
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
        public void InsertComboboxPersonInformation(AbstractPersonViewModel<T> user)
        {
            AddressViewModel = AddressViewModel ?? new AddressPropertyViewModel(user.Address);
            var person = user.Person as PersonAbstractDTO;
            TbName = person.Name;
            TbSurname = person.Surname;
            TbPatronumic = person.Patronumic;
            TbPassport = person.PassportNumber;
            TbPhoneNumber = person.PhoneNumber;
            TbEmail = person.Email;
            AddressViewModel.InsertComboboxAddressInformation(user.Address);
        }
    }
}
