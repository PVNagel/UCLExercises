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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TusindfrydWPF.Domain;

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<FlowerSort> flowerSorts;
        public MainWindow()
        {
            InitializeComponent();
            flowerSorts = new List<FlowerSort>();
        }

        private void buttonOpretBlomstersort_Click(object sender, RoutedEventArgs e)
        {
            CreateFlowerSortDialog flowerSortDialog = new CreateFlowerSortDialog();
            if (flowerSortDialog.ShowDialog() == true)
            {
                flowerSorts.Add(flowerSortDialog.MyFlowerSort);
            }
            else
            {
                throw new Exception("FlowerSort was not valid");
            }
            var textBlock = (TextBlock)FindName("tblock");
            foreach (FlowerSort sort in flowerSorts)
            {
                textBlock.Text = textBlock.Text + "\n" + sort.Name;
            }
        }
    }
}
