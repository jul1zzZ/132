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
using System.IO;
using WpfApp1.Pages;
using WpfApp1.Entity;
using Microsoft.Win32;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для MaterialInfoPage.xaml
    /// </summary>
    public partial class MaterialInfoPage : Page
    {
        public Material Material { get; set; }
        public string _photoDirectory = $@"{Directory.GetCurrentDirectory()}\Images\";

        private string _photoPath;
        private string _photoName;
        public MaterialInfoPage(Material material)
        {
            InitializeComponent();
            Material = material ?? new Material();
            DataContext = Material;
        }

        private void LoadPhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png";
            if (openFileDialog.ShowDialog() == false)
            {
                return;
            }

            FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

            if (fileInfo.Length > 8 * 1024 * 1024 * 6)
            {
                MessageBox.Show("Размер фото не должен превышать 6 мб");
                return;
            }

            _photoName = Guid.NewGuid().ToString();
            _photoPath = fileInfo.FullName;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Material.IdMaterial = (SupplierCb.SelectedItem as Supplier).IdSupplier;
                if (_photoPath != null)
                {
                    Material.Photo = _photoName;
                    File.Copy(_photoPath, _photoDirectory + _photoName);
                }
                if (Material.IdMaterial == 0)
                {
                    Material.Price = 0;
                    DemoSSEntities.GetContext().Materials.Add(Material);
                }
                DemoSSEntities.GetContext().SaveChanges();
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

        }
    }
}
