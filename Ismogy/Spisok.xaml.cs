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
using Ismogy.VM;

namespace Ismogy
{
    /// <summary>
    /// Логика взаимодействия для Spisok.xaml
    /// </summary>
    public partial class Spisok : Window
    {
        public Spisok()
        {
            InitializeComponent();
            DataContext = new DelVM();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            Spisok s = new Spisok();
            s.Show();
            this.Close();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            AddWindow a = new AddWindow();
            a.Show();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
