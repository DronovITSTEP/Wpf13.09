using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System;

namespace Wpf13._09
{
    class Person {
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender {  get; set; }
        public List<string> ListInteres { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return $"Фамилия: {Surname} Имя: {FirstName} Отчество: {LastName}\n" +
                $"Дата Рождения: {BirthDate.ToShortDateString()}\n" +
                $"Пол: {Gender}\nСписок интересов:{Inter()}\n";
        }
        private string Inter()
        {
            string str = "";
            foreach (string i in ListInteres)
                str += i + " ";

            return str;
        }

    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person;
        List<string> items;
        public MainWindow()
        {
            InitializeComponent();

            items = new List<string>
           {
               "Россия",
               "Америка",
               "Турция"
           };
            CountryBox.ItemsSource = items;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            person = new Person
            {
                FirstName = FirstName.Text, LastName = LastName.Text,
                Surname = SurName.Text, BirthDate = BirthDate.DisplayDate,
                Country = items[CountryBox.SelectedIndex],
                ListInteres = new List<string>()
                
            };

            if (Male.IsChecked == true) { person.Gender = Male.Content.ToString(); }
            else { person.Gender = Female.Content.ToString(); }

            foreach (CheckBox i in Interes.Children)
            {
                if (i.IsChecked == true) 
                    person.ListInteres.Add(i.Content.ToString());
            }
            
            MessageBox.Show(person.ToString());            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FirstName.Text = string.Empty;
            LastName.Text = string.Empty;
            SurName.Text = string.Empty;
            BirthDate.Text = string.Empty;

            Male.IsChecked = false;
            Female.IsChecked = false;

            CountryBox.SelectedIndex = -1;

            foreach (CheckBox i in Interes.Children)
            {
                i.IsChecked = false;
            }

        }
    }
}
