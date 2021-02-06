using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour Login_page.xaml
    /// </summary>
    public partial class Login_page : Page
    {
        //CONNEXION AVEC LA BASE DE DONNEE
        string str_conn = "Data Source=DESKTOP-4H2RVTQ\\SQLEXPRESS;Initial Catalog=gestion_absence;Integrated Security=True";
        SqlConnection connexion = new SqlConnection();

        public static string username1;//NOM ET PRENOM DE L'UTILISATEUR
        public static int profession_id;//LA PROFESSION
        public Login_page()
        {
            InitializeComponent();
        }

        private void txt_Usuario_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void toregister(object sender, RoutedEventArgs e)
        {
            navigationFrame.Content = new inscription();
          
        }

       

        private void btn_connexion_Click(object sender, RoutedEventArgs e)
        {
            //DONNEE SAISIE
            string email = mail.Text.ToString();
            string mot_de_passe = mot_passe.Password.ToString();

            //connexion avec la base de donnée
            try
            {
                
                connexion.ConnectionString = str_conn;
                //ouvrir la connexion
                connexion.Open();
                //inserer la requete sql
                SqlCommand command = connexion.CreateCommand();
                string requete = "SELECT nom,prenom,email,mot_passe,profession FROM utilisateur WHERE email=@email AND mot_passe=@password";
                //definir les parametres
                SqlParameter param1 = new SqlParameter("@email", email);
                SqlParameter param2 = new SqlParameter("@password", mot_de_passe);
                //ajouter les parametres à la requete
                command.Parameters.Add(param1);
                command.Parameters.Add(param2);
                command.CommandText = requete;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    SqlDataReader lire=command.ExecuteReader();
                 
                        while (lire.Read())
                        {
                            username1 = lire["nom"].ToString() + " " + lire["prenom"].ToString();
                            profession_id = Convert.ToInt32(lire["profession"]);
                            if (profession_id == 1) {
                            NavigationService navService = NavigationService.GetNavigationService(this);
                            acceuil_professeur s = new acceuil_professeur();

                            navService.Navigate(s);

                        }
                            else
                            {
                            NavigationService navService = NavigationService.GetNavigationService(this);
                            acceuil_etudiant s = new acceuil_etudiant();

                            navService.Navigate(s);

                        }
                            
                        }
                    
                        
                    
                }

                else
                {
                    if (email.Trim().Equals(""))
                    {
                        MessageBox.Show("Entrez votre email", "le manque de nom d'utilisateur");
                    }
                    // check if the password field is empty
                    else if (mot_de_passe.Trim().Equals(""))
                    {
                        MessageBox.Show("Entrez votre mot de passe", "le manque de motdepasse");
                    }

                    // check if the username or the password don't exist
                    else
                    {
                        MessageBox.Show("l'email ou le mot de passe est incorrecte", "informations incorrecte");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connexion.Close();
            }
        }

        private void navigationFrame_Navigated(object sender, NavigationEventArgs e)
        {
            
        }
    }
}
