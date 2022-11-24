using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PersonRepository personRepo = new PersonRepository();

        // Implement the rest of this MainViewModel class below to 
        // establish the foundation for data binding !

        public ObservableCollection<PersonViewModel> PersonsVM { get; set;} = new();

        private PersonViewModel personViewModel;
        public PersonViewModel SelectedPersonVM 
        { 
            get { return personViewModel; } 
            set 
            { 
                personViewModel = value; 
                OnPropertyChanged("SelectedPersonVM");
            }
        }

        public MainViewModel()
        {
            foreach (Person p in personRepo.GetAll())
            {
                PersonViewModel personVM = new(p);
                PersonsVM.Add(personVM);
            }
        }

        public void AddDefaultPerson()
        {
            Person p = personRepo.Add("Specify FirstName", "Specify LastName", 0, "Specify Phone");
            PersonViewModel pVM = new(p);
            PersonsVM.Add(pVM);
            SelectedPersonVM= pVM;
        }

        public void DeleteSelectedPerson()
        {
            SelectedPersonVM.RemovePerson(personRepo);
            PersonsVM.Remove(SelectedPersonVM);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
