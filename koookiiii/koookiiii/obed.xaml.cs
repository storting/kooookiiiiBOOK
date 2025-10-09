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
    /// Логика взаимодействия для obed.xaml
    /// </summary>
    public partial class obed : Window
    {
        public obed()
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
    }
}
