//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Input;
//using WPFex30.ViewModel;

//namespace WPFex30.Commands
//{
//    public class UpdateCommand : ICommand
//    {
//        public event EventHandler CanExecuteChanged;

//        public bool CanExecute(object parameter)
//        {
//            return true;
//        }

//        public void Execute(object parameter)
//        {
//            ProductRepo repo = new ProductRepo();
//            if (parameter is MainViewModel mvm)
//            {
//                mvm.ProductVM = ;
//            }
//            else
//                throw new ArgumentException("Illegal parameter");
//        }
//    }
//}
