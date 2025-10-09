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
    /// Логика взаимодействия для krokmadam.xaml
    /// </summary>
    public partial class krokmadam : Window
    {
        public krokmadam()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Breakfast = new breakfast(); // Создаем экземпляр главной формы
            Breakfast.Show();

            // Скрываем текущее окно
            this.Close(); // З
        }
    }
}
