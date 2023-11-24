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

namespace labb4
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

        private void ansver_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(textbox2.Text, out int n))
            {
                MessageBox.Show("Введите трехзначное число");

            }
            int firstDitit = n / 100;
            int secondDigit = n / 10 % 10;
            if (firstDitit > secondDigit)
            {
                textbox3.Text=("Первая цифра больше второй").ToString();
            }
            else if (firstDitit < secondDigit)
            {
                textbox3.Text = ("Вторая цифра больше первой").ToString();
            }
            else
            {
                textbox3.Text = ("Первая и вторая цифры равны").ToString();
            }
        }
    }
}
