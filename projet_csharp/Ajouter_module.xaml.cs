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
    /// Logique d'interaction pour Ajouter_module.xaml
    /// </summary>
    public partial class Ajouter_module : Page
    {
        SqlCommand cmd;
        SqlConnection con;

        public Ajouter_module()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string str_conn = "Data Source=DESKTOP-4H2RVTQ\\SQLEXPRESS;Initial Catalog=gestion_absence;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str_conn;
            //ouvrir la connexion
            con.Open();

            cmd = new SqlCommand("INSERT INTO Modules ( module,responsable) VALUES (@nom,@respo)", con);

            cmd.Parameters.AddWithValue("@nom", nom.Text);
            cmd.Parameters.AddWithValue("@respo", respo.Text);
            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                MessageBox.Show("Module ajouté avec succées!", "Gestion d'absence", MessageBoxButton.OK, MessageBoxImage.Information);
                students p1 = new students();
                NavigationService navService = NavigationService.GetNavigationService(this);
                module nextPage = new module();
                navService.Navigate(nextPage);
            }
            else
            {
                MessageBox.Show("Module non ajouté  !", "Gestion d'absence", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
