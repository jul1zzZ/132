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
using WpfApp1.Entity;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListMaterialsPage.xaml
    /// </summary>
    public partial class ListMaterialsPage : Page
    {
        public List<Material> Material { get; set; }
        public ListMaterialsPage()
        {
            InitializeComponent();
            Material = DemoSSEntities.GetContext().Materials.ToList();
            DataContext = this;
        }

        private void AddMaterial_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.MaterialInfoPage(null));
        }

        private void MaterialInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.MaterialInfoPage((Material)(sender as Button).DataContext));
        }
    }
}
