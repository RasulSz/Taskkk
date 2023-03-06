
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace Taskkk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Person person = new();
            person.Name=name.Text;
            person.Surname=surname.Text;
            person.Email=email.Text;
            person.PhoneNumber = phone.Text;
            person.DateTime=birth.Text;
            list.Items.Add(person.Name);
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            List<Person> people = new();
            var json=JsonSerializer.Serialize(list.Items);
            File.WriteAllText("Humanity.json", json);
        }

        private void list_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            button.Content = "Change";
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            File.ReadAllText("Humanity.json");
        }
    }
}
