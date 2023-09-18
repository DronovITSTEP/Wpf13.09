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

namespace Wpf15._09
{

    class A
    {
        public void Show()
        {
            Console.WriteLine("A");
        }
    }
    class B : A {
        public void Show()
        {
            Console.WriteLine("B");
        }
    }
    class C: B 
    {
        public void Show()
        {
            Console.WriteLine("C");
        }
    }

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вот и хорошо. Продолжай работать");
        }

        private void No_MouseEnter(object sender, MouseEventArgs e)
        {
            //Console.WriteLine("Мышка в кнопке");
            
            /*double windowWidth = Canva.ActualWidth;
            double windowHeight = Canva.ActualHeight;

            double buttonWidth = NoButton.ActualWidth;
            double buttonHeight = NoButton.ActualHeight;

            double maxX = windowWidth - buttonWidth;
            double maxY = windowHeight - buttonHeight;

            double randomX = random.NextDouble() * maxX;
            double randomY = random.NextDouble() * maxY;

            Canvas.SetLeft(NoButton, randomX);
            Canvas.SetTop(NoButton, randomY);*/


            if ((sender as Button).Name == "NoButton")
            {
                NoButton.Content = "Да";
                YesButton.Content = "Нет";
            }          
            else
            {
                NoButton.Content = "Нет";
                YesButton.Content = "Да";
            }
        }
    }
}
