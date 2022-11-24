using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
// using WPFex30.Commands;
using WPFex30.Model;

namespace WPFex30.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        ProductRepo productRepo = new ProductRepo();

        public ObservableCollection<ProductViewModel> ProductVM { get; set; } = new();

        public MainViewModel()
        {
            foreach (Product p in productRepo.GetAll())
            {
                ProductViewModel productVM = new(p);
                ProductVM.Add(productVM);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
