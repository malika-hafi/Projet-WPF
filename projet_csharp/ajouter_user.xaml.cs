using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour ajouter_user.xaml
    /// </summary>
    public partial class ajouter_user : UserControl
    {
        SqlCommand cmd;
        SqlConnection con;

        public ajouter_user()
        {
            InitializeComponent();
        }

        private void btn_ajouter_user_Click(object sender, RoutedEventArgs e)
        {
            string str_conn = "Data Source=DESKTOP-4H2RVTQ\\SQLEXPRESS;Initial Catalog=gestion_absence;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str_conn;
            //ouvrir la connexion
            con.Open();
            cmd = new SqlCommand("INSERT INTO Etudiant( cne,nom,prenom) VALUES (@cne,@nom, @prenom)", con);
            cmd.Parameters.AddWithValue("@cne", CNE.Text);
            cmd.Parameters.AddWithValue("@nom", prenom.Text);
            cmd.Parameters.AddWithValue("@prenom", nom.Text);
            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                MessageBox.Show("Etudiant ajouté avec succées!", "Gestion d'absence", MessageBoxButton.OK, MessageBoxImage.Information);
                students p1 = new students();
                NavigationService navService = NavigationService.GetNavigationService(this);
                students nextPage = new students();
                navService.Navigate(nextPage);
            }
            else
            {
                MessageBox.Show("Etudiant non ajouté  !", "Gestion d'absence", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
