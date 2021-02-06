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
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace projet_csharp
{
    /// <summary>
    /// Logique d'interaction pour students.xaml
    /// </summary>
    public partial class students : Page
    {
        SqlCommand cmd;
        SqlConnection con;
        public students()
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
            cmd.CommandText = "select * from [Etudiant]";
            cmd.Connection = con;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Etudiant");
            ad.Fill(dt);
            g1.ItemsSource = dt.DefaultView;

        }
        private void Edit(object sender, RoutedEventArgs e)
        {

            DataRowView row = g1.SelectedItem as DataRowView;
            // MessageBox.Show(row.Row.ItemArray[1].ToString());
            NavigationService navService = NavigationService.GetNavigationService(this);
            edit_student s = new edit_student((int)row.Row.ItemArray[0]);


            navService.Navigate(s);

        }
        private void HomePage(object sender, RoutedEventArgs e)
        {
            Login pg = new Login();
            this.Content = pg;
        }

        

        private void acceuil_prof_Checked(object sender, RoutedEventArgs e)
        {
            navigationFrame.Content = new acceuil_professeur();
        }

        private void statistique_Checked(object sender, RoutedEventArgs e)
        {
            navigationFrame.Content = new statistique();
        }

        private void filiere_btn_Checked(object sender, RoutedEventArgs e)
        {
            navigationFrame.Content = new gestion_filiere();
        }

        private void gestion_absence_Checked(object sender, RoutedEventArgs e)
        {
            navigationFrame.Content = new gestion_absnc();
        }

        private void navigationFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void nom_btn_Initialized(object sender, EventArgs e)
        {
            nom_btn.Content = Login_page.username1;
        }

        private void Add_student(object sender, RoutedEventArgs e)
        {
            ajouter_user add = new ajouter_user();
            this.Content = add;
        }
        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["connDatabse"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from [Etudiant] WHERE  (nom = '"
                              + search.Text
                              + "') or (prenom = '"
                              + search.Text
                              + "') or (sexe = '"
                              + search.Text
                              + "') ";
            cmd.Connection = con;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Etudiant");
            ad.Fill(dt);
            g1.ItemsSource = dt.DefaultView;
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("étes vous sur de supprimer cet étudiant ! ", "Gestion d'absence", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                DataRowView row = g1.SelectedItem as DataRowView;
                // MessageBox.Show(row.Row.ItemArray[1].ToString());

                string str_conn = "Data Source=DESKTOP-4H2RVTQ\\SQLEXPRESS;Initial Catalog=gestion_absence;Integrated Security=True";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = str_conn;
                //ouvrir la connexion
                con.Open();
                cmd = new SqlCommand("DELETE FROM Etudiant WHERE cne=@cne", con);
                cmd.Parameters.AddWithValue("@cne", (int)row.Row.ItemArray[0]);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Etudiant supprimé avec succées!", "Gestion d'absence", MessageBoxButtons.OK);


                NavigationService navService = NavigationService.GetNavigationService(this);
                students s = new students();

                navService.Navigate(s);

            }
        }
    }
}
