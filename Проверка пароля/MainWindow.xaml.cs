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

namespace Проверка_пароля
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = txtVvod.Text;// раскладываем строку пароля на знаки
            char[] array = s.ToCharArray();
            int d = s.Length;
            int k = 0;
            int u = 0;
            int b = 0;
            char p = '$';
            char j = '!';
            char f = '@';
            char h = '%';
            char z = '^';
            char x = '#';

            try
            {
                // проверка на Верхний регистр
                for (int i = 0; i < d; i++)
                {
                    if (char.IsUpper(array[i]))
                    {
                        k++;
                    }

                }
                // проверка на число
                for (int i = 0; i < d; i++)
                {
                    if (char.IsNumber(array[i]))//вычисляем числа
                    {
                        u++;
                    }
                }
                // проверка на знак
                for (int i = 0; i < d; i++)
                {
                    if (Convert.ToChar(p) == (array[i]) ||
                         Convert.ToChar(j) == (array[i]) ||
                          Convert.ToChar(h) == (array[i]) ||
                           Convert.ToChar(f) == (array[i]) ||
                            Convert.ToChar(z) == (array[i]) ||
                             Convert.ToChar(x) == (array[i]))
                    {
                        b++;
                    }
                }
                if ((k >= 1) && (txtVvod.Text.Length >= 6) && (u >= 1) && (b >= 1))
                {
                    MessageBox.Show("Пароль подходит!");
                }
                else MessageBox.Show("Пароль должен содержать специальные символы ($ ! @ # ^ %), одну цифру и одну заглавную букву, а так же должен состоять минимум из 6 символов");
            }
            catch
            {
                MessageBox.Show("Введите корректные данные!");
            }
        }
    }
}
