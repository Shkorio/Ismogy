using Ismogy.DB;
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

namespace Ismogy
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

        private void Sign(object sender, RoutedEventArgs e)
        {
            var res = StudentContext.GetInstance().Users.ToList();
            if(res == null)
            {
                MessageBox.Show("Error");
            }
            else
            {
                Spisok s = new Spisok();
                s.Show();
                this.Close();
            }
        }
    }
}
