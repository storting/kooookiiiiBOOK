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
using System.Windows.Shapes;

namespace koookiiii
{
    /// <summary>
    /// Логика взаимодействия для breakfast.xaml
    /// </summary>
    public partial class breakfast : Window
    {
        public breakfast()
        {
            InitializeComponent();
           
        }
       
        

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var mainWindow = new MainWindow(); // Создаем экземпляр главной формы
            mainWindow.Show();

            // Скрываем текущее окно
            this.Close(); // З
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tvorog newWindow = new tvorog();
            newWindow.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            pankeiki newWindow = new pankeiki();
            newWindow.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            krokmadam newWindow = new krokmadam();
            newWindow.Show();
            this.Hide();
        }
    }
}
