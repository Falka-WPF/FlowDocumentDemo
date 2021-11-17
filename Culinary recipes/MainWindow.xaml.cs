using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Culinary_recipes
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RecipesListBox.Items.Add("Салат");
            RecipesListBox.Items.Add("Морской салат");
            RecipesListBox.Items.Add("Греческий");
            RecipesListBox.Items.Add("Вверх ногами");
            RecipesListBox.Items.Add("Ананасовый");
            RecipesListBox.Items.Add("Лансай");
            RecipesListBox.Items.Add("Уреве");
        }

        private void RecipesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            string new_path = @"../../Recipes/"+ RecipesListBox.SelectedItem.ToString()+".xaml";
            if (File.Exists(new_path))
            {
                Reader.Document = (FlowDocument)XamlReader.Load(File.OpenRead(new_path));
            }
            else
            {
                MessageBox.Show("Invalid path!\n", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
