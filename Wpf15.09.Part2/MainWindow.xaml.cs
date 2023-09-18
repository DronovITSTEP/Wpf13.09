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

namespace Wpf15._09.Part2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> cats = new List<string>();
        private List<string> dogs = new List<string>();
        private List<string> parrots = new List<string>();

        private Random Random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            cats.AddRange(new string[] { "Барсик", "Мурзик", "Пушок" });
            dogs.AddRange(new string[] { "Жучка", "Бобик", "Шарик" });
            parrots.AddRange(new string[] { "Кеша", "Гоша", "Ара" });

            Cats.ItemsSource = cats;
            Dogs.ItemsSource = dogs;
            Parrots.ItemsSource = parrots;
        }

        private void Click_Mouse(object sender, MouseButtonEventArgs e)
        {
            List<string> animalsList = null;
            int rand = Random.Next(3);
            
            if (sender is RadioButton)
            {
                animalsList = SelectAnimal((sender as RadioButton).Content.ToString());
                IndexAnimal((sender as RadioButton).Content.ToString(), rand);
                TabEnum((sender as RadioButton).Content.ToString());
            }
            if (sender is TabItem)
            {
                animalsList = SelectAnimal((sender as TabItem).Header.ToString());
                IndexAnimal((sender as TabItem).Header.ToString(), rand);
                RadioEnum((sender as TabItem).Header.ToString());
            }

            nameAnimal.Text = animalsList[rand];
        }

        private List <string> SelectAnimal(string anim)
        {
            if (anim == "Кот")
            {
                return cats;
            }
            else if (anim == "Попугай")
            {
                return parrots;
            }
            else if (anim == "Собака")
            {
                return dogs;

            }
            return null;
        }
        private void IndexAnimal(string anim, int rand)
        {
            if (anim == "Кот")
            {
                Cats.SelectedIndex = rand;

            }
            else if (anim == "Попугай")
            {
                Parrots.SelectedIndex = rand;
            }
            else if (anim == "Собака")
            {
                Dogs.SelectedIndex = rand;
            }
        }

        private void TabEnum(string anim)
        {
            foreach (TabItem i in animals.Items)
            {
                if (i.Header.ToString() == anim)
                {
                    i.IsSelected = true;
                    break;
                }
            }
        }
        private void RadioEnum (string anim)
        {
            foreach (RadioButton i in pets.Children)
            {
                if (i.Content.ToString() == anim)
                {
                    i.IsChecked = true;
                    break;
                }
            }
        }
    }
}
