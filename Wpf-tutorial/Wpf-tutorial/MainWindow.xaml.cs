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

namespace Wpf_tutorial
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            people.Add(new Person { FirstName = "Tim", LastName = "Corney" });
            people.Add(new Person { FirstName = "Joe", LastName = "Smith" });
            people.Add(new Person { FirstName = "Sue", LastName = "Storm" });

            myComboBox.ItemsSource = people; // Przypisanie listy obiektów pod comboboxa żeby 
            //wyświetlali sie w nim
        }

        private void SubbmitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {FirstnameText.Text}"); // taki alert w js
        }
    }
}
