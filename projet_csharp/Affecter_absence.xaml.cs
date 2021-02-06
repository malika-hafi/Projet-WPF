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
    /// Logique d'interaction pour Affecter_absence.xaml
    /// </summary>
    public partial class Affecter_absence : Page
    {

        int id_s;
        public Affecter_absence()
        {
            InitializeComponent();
        }

        private void chercher(object sender, RoutedEventArgs e)
        {
            string str_conn = "Data Source=DESKTOP-4H2RVTQ\\SQLEXPRESS;Initial Catalog=gestion_absence;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str_conn;
            //ouvrir la connexion
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from [Seance] WHERE  (heure_début = '"
                              + debut.Text
                              + "') and (heure_fin = '"
                              + fin.Text
                              + "') and (date = '"
                              + date.Text
                              + "') ";
            cmd.Connection = con;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Seance");
            ad.Fill(dt);
            g2.ItemsSource = dt.DefaultView;


            foreach (DataRow dr in dt.Rows)
            {
                this.id_s = (int)dr["id"];




            }

            if (g2.Items.Count < 1)
            {
                MessageBox.Show("Cette seance n'existe pas! vérifier ses informations !");
            }
            else
            {

                
                SqlCommand cm = new SqlCommand();
                cm.CommandText = "select * from [Etudiant]";
                cm.Connection = con;
                SqlDataAdapter a = new SqlDataAdapter(cm);
                DataTable d = new DataTable("Etudiant");
                a.Fill(d);
                g3.ItemsSource = d.DefaultView;
            }
        }
        private void Marquer_absence(object sender, RoutedEventArgs e)
        {
            // ItemCollection row = g2.Items as ItemCollection;
            DataRowView row1 = g3.SelectedItem as DataRowView;

            NavigationService navService = NavigationService.GetNavigationService(this);
            Affectation s = new Affectation((int)row1.Row.ItemArray[0], id_s);

            navService.Navigate(s);
        }
    }
}

