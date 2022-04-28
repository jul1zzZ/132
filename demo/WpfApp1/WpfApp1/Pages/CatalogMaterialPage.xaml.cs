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
using WpfApp1.Pages;
using WpfApp1.Entity;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для CatalogMaterialPage.xaml
    /// </summary>
    public partial class CatalogMaterialPage : Page
    {
        public CatalogMaterialPage()
        {
            InitializeComponent();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            MaterialLb.ItemsSource = DemoSSEntities.GetContext().Materials.ToList();


            List<Supplier> suppliers = DemoSSEntities.GetContext().Suppliers.ToList();
            suppliers.Insert(0, new Supplier
            {
                Name = "Все"
            });
           MaterialFilterCb.ItemsSource = suppliers;
            MaterialFilterCb.DisplayMemberPath = "Name";
            MaterialFilterCb.SelectedIndex = 0;

            MaterialSortCb.SelectedIndex = 0;
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void MaterialSortCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void MaterialFilterCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void Update()
        {
            List<Material> materials = DemoSSEntities.GetContext().Materials
                .OrderBy(p => p.Name)
                .ToList();

            if (SearchTb.Text.Trim() != "")
            {
                materials = materials
                    .Where(p => p.Name.Trim().ToLower().Contains(SearchTb.Text.Trim().ToLower()) ||
                     p.Supplier.Name.Trim().ToLower().Contains(SearchTb.Text.Trim().ToLower()) 
                    ).ToList();
            }

            if (MaterialFilterCb.SelectedIndex > 0)
            {
                materials = materials.Where(p => p.IdMaterial == (MaterialFilterCb.SelectedItem as Material).IdMaterial).ToList();
            }

            if (MaterialSortCb.SelectedIndex > 0)
            {
                switch (MaterialSortCb.SelectedIndex)
                {
                    case 1:
                        materials = materials.OrderBy(p => p.Price).ToList();
                        break;
                    case 2:
                        materials = materials.OrderByDescending(p => p.Price).ToList();
                        break;
                }
            }

        }
    }
}
