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
using System.Windows.Shapes;

namespace Ismogy
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private string? name;

        public new string? Name { get => name; set => name = value; }
        public string Surname { get; set; }
        public string Rank { get; set; }
        public string House { get; set; }
        public AddWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            StudentContext context = new();
            Zavod i = new();
            i.Name = name;
            i.Surname = Surname;
            i.Rank = Rank;
            i.House = House;
            context.Zavods.Add(i);
            context.SaveChanges();
        }
    }
}
