using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TusindfrydWPF.Domain;

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for CreateFlowerSortDialog.xaml
    /// </summary>
    public partial class CreateFlowerSortDialog : Window
    {
        public FlowerSort MyFlowerSort { get; set; }

        public CreateFlowerSortDialog()
        {
            InitializeComponent();

            buttonOk.IsEnabled = false;
        }

        private void tbName_TextChanged(object sender, TextChangedEventArgs e)
        {
            IsEmpty();
        }

        private void tbBillede_TextChanged(object sender, TextChangedEventArgs e)
        {
            changeImage();
            IsEmpty();
        }

        private void changeImage()
        {
            flowerImage.Source = new BitmapImage(new Uri("C:\\Users\\phili\\Pictures\\test.png"));
        }
        private void tbProduktionstid_TextChanged(object sender, TextChangedEventArgs e)
        {
            IsEmpty();
        }

        private void tbHalveringstid_TextChanged(object sender, TextChangedEventArgs e)
        {
            IsEmpty();
        }

        private void tbSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            IsEmpty();
        }

        private void IsEmpty()
        {
            if (tbName.Text != "" && tbBillede.Text != "" && tbProduktionstid.Text != "" && tbHalveringstid.Text != "" && tbSize.Text != "")
            {
                buttonOk.IsEnabled = true;
            }
        }

        private void buttonOk_Click(object sender, RoutedEventArgs e)
        {
            MyFlowerSort = new FlowerSort(tbName.Text, tbBillede.Text, int.Parse(tbProduktionstid.Text), int.Parse(tbHalveringstid.Text), int.Parse(tbSize.Text));
            DialogResult = true;
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
