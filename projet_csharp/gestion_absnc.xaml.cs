using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
    /// Logique d'interaction pour gestion_absnc.xaml
    /// </summary>
    public partial class gestion_absnc : Page
    {
        public gestion_absnc()
        {
            InitializeComponent();
            binddatagrid();
        }
        private void binddatagrid()
        {
            string str_conn = "Data Source=DESKTOP-4H2RVTQ\\SQLEXPRESS;Initial Catalog=gestion_absence;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str_conn;
            //ouvrir la connexion
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from [Absence]";
            cmd.Connection = con;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Absence");
            ad.Fill(dt);
            g2.ItemsSource = dt.DefaultView;

        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            string str_conn = "Data Source=DESKTOP-4H2RVTQ\\SQLEXPRESS;Initial Catalog=gestion_absence;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str_conn;
            //ouvrir la connexion
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from [Absence] WHERE  (nom = '"
                              + search.Text
                              + "') or (prénom = '"
                              + search.Text
                              + "') or (module = '"
                              + search.Text
                              + "') ";
            cmd.Connection = con;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Absence");
            ad.Fill(dt);
            g2.ItemsSource = dt.DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
            Affecter_absence s = new Affecter_absence();

            navService.Navigate(s);
        }

        private void acceuil_prof_Checked(object sender, RoutedEventArgs e)
        {
            navigationFrame.Content = new acceuil_professeur();
        }

        private void statistique_Checked(object sender, RoutedEventArgs e)
        {
            navigationFrame.Content = new statistique();
        }

        private void gestion_etudiant_Checked(object sender, RoutedEventArgs e)
        {
            navigationFrame.Content = new students();
        }

        private void filiere_btn_Checked(object sender, RoutedEventArgs e)
        {
            navigationFrame.Content = new gestion_filiere();
        }

        private void navigationFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void nom_btn_Initialized(object sender, EventArgs e)
        {
            nom_btn.Content = Login_page.username1;
        }
    }
}
