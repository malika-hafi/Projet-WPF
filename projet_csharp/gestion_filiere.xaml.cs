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

namespace projet_csharp
{
    /// <summary>
    /// Logique d'interaction pour gestion_filiere.xaml
    /// </summary>
    public partial class gestion_filiere : Page
    {
        public gestion_filiere()
        {
            InitializeComponent();
        }

       

        private void acceuil_prof_Checked(object sender, RoutedEventArgs e)
        {
            navigationFrame.Content = new acceuil_professeur();

        }

        private void statiqtique_Checked(object sender, RoutedEventArgs e)
        {
            navigationFrame.Content = new statistique();
        }

        private void gestion_etudiant_Checked(object sender, RoutedEventArgs e)
        {
            navigationFrame.Content = new students();
        }

       

        private void gestion_absence_Checked(object sender, RoutedEventArgs e)
        {
            navigationFrame.Content = new gestion_absnc();
        }

        private void navigationFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void nom_btn_Initialized(object sender, EventArgs e)
        {
            nom_btn.Content = Login_page.username1;
        }
    }
}
