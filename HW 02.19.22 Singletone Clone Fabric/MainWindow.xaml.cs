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

namespace HW_02._19._22_Singletone_Clone_Fabric
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            IWarrior warrior;
            CloneFabric cloneFabric = new CloneFabric();
            if (Rb1.IsChecked == true)
                warrior = cloneFabric.Clone(1);
            if (Rb2.IsChecked == true)
                warrior = cloneFabric.Clone(2);
        }
    }
}
