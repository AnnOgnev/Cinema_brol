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

namespace Cinema_brol
{
    /// <summary>
    /// Логика взаимодействия для Name.xaml
    /// </summary>
    public partial class Name : Window
    {
        public Name()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string UName = MyName.Text;
            this.Hide();
            MainWindow ds = new MainWindow();
            ds.Name = UName;
            ds.Show();
        }
    }
}
