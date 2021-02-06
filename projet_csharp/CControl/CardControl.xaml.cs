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

namespace projet_csharp.CControl
{
    /// <summary>
    /// Logique d'interaction pour CardControl.xaml
    /// </summary>
    public partial class CardControl : UserControl
    {
        public CardControl()
        {
            InitializeComponent();
        }



        public Uri ImageSource
        {
            get { return (Uri)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(Uri), typeof(CardControl));


        public string DriveName
        {
            get { return (string)GetValue(DriveNameProperty); }
            set { SetValue(DriveNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DriveName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DriveNameProperty =
            DependencyProperty.Register("DriveName", typeof(string), typeof(CardControl));



        public string ListeLink
        {
            get { return (string)GetValue(ListeLinkProperty); }
            set { SetValue(ListeLinkProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ListeLink.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ListeLinkProperty =
            DependencyProperty.Register("ListeLink", typeof(string), typeof(CardControl));



        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsChecked.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register("IsChecked", typeof(bool), typeof(CardControl));

        public string LastChange
        {
            get { return (String)GetValue(lastChangeProperty); }
            set { SetValue(lastChangeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for lastChange.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty lastChangeProperty =
            DependencyProperty.Register("LastChange", typeof(String), typeof(CardControl));

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}

