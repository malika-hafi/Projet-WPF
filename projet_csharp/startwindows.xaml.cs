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

namespace projet_csharp
{
    /// <summary>
    /// Logique d'interaction pour startwindows.xaml
    /// </summary>
    public partial class startwindows : Window
    {
        public startwindows()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void to_login(object sender, RoutedEventArgs e)
        {
            Login_page log = new Login_page();
            this.Content = log;
        }

        private void to_register(object sender, RoutedEventArgs e)
        {
            inscription insc = new inscription();
            this.Content = insc;

        }
    }
}
