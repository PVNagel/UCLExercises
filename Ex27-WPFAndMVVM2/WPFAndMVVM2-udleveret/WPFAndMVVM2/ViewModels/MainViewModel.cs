using System;
using System.Collections.Generic;
using System.Text;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel
    {
        private PersonRepository personRepo = new PersonRepository();
        public List<PersonViewModel> PersonsVM { get; set; } = new();

        public MainViewModel()
        {
            foreach (Person person in personRepo.GetAll())
            {
                PersonViewModel personVM = new(person);
                PersonsVM.Add(personVM);
            }
        }
    }
}
