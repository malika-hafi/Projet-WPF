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
    /// Logique d'interaction pour inscription.xaml
    /// </summary>
    public partial class inscription : Page
    {
        string str_conn = "Data Source=DESKTOP-4H2RVTQ\\SQLEXPRESS;Initial Catalog=gestion_absence;Integrated Security=True";
        SqlConnection connexion = new SqlConnection();
        public inscription()
        {
            InitializeComponent();
        }

        private void User_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void tologin(object sender, RoutedEventArgs e)
        {
            navigationFrame.Content = new Login_page();
        }

        private void btn_inscription_Click(object sender, RoutedEventArgs e)
        {
            //DONNEE SAISIE
            string Nom = nom.Text.ToString();
            string Prenom = prenom.Text.ToString();
            string Email = email.Text.ToString();

            string password = mot_passe.Password.ToString();
            string con_password = con_motpasse.Password.ToString();
            string date_naissance = date.Text.ToString();
            string num_tel = tel.Text; ToString();
            int id;
            if (radio_etudiant.IsChecked == true)
            {
                id = 1;

            }
            else
            {
                id = 2;
            }
            try
            {
                //connexion avec la base de donnée
                

               
                connexion.ConnectionString = str_conn;
                //ouvrir la connexion
                connexion.Open();
                //definir la commande sql
                SqlCommand commande = new SqlCommand("INSERT INTO utilisateur (nom,prenom,email,mot_passe,date_naissance,num_tel,profession) VALUES (@nom,@prenom,@email,@mot_passe,@date_naissance,@tel,@profession)");
                SqlParameter param = new SqlParameter("@nom", Nom);
                SqlParameter param1 = new SqlParameter("@prenom", Prenom);
                SqlParameter param2 = new SqlParameter("@email", Email);
                SqlParameter param3 = new SqlParameter("@mot_passe", password);
                SqlParameter param4 = new SqlParameter("@date_naissance", date_naissance);
                SqlParameter param5 = new SqlParameter("@tel", num_tel);
                SqlParameter param6 = new SqlParameter("@profession", id);

                commande.Parameters.Add(param);
                commande.Parameters.Add(param1);
                commande.Parameters.Add(param2);
                commande.Parameters.Add(param3);
                commande.Parameters.Add(param4);
                commande.Parameters.Add(param5);
                commande.Parameters.Add(param6);

                commande.Connection = connexion;
                if (!checkTextBoxesValues())
                {
                    //tester si le mot de passe égale au mot d passe de confirmation
                    if (password.Equals(con_password))
                    {
                        if (!checkusername()) {
                            commande.ExecuteNonQuery();
                            MessageBox.Show("félicitation votre compte a été créer,veuillez se connecter!!", "compte crée");
  
                              connexion.Close();
                        }
                        else
                        {
                            MessageBox.Show("cet utilisateur existe déja,veuillez taper un autre", "utilisateur en double");
                        }
                       

                    }
                    else
                    {
                        MessageBox.Show("le mot de passe de confirmation est incorrecte", " erreur de mot de passe");
                    }

                }
                else
                {
                    MessageBox.Show("entrez votre informations!", "manque d'information");
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
        public Boolean checkTextBoxesValues()
        {
            string Nom = nom.Text.ToString();
            string Prenom = prenom.Text.ToString();
            string Email = email.Text.ToString();

            string password = mot_passe.Password.ToString();
            string con_password = con_motpasse.Password.ToString();
            string date_naissance = date.Text.ToString();
            string num_tel = tel.Text; ToString();


            if (nom.Equals("") || Prenom.Equals("") ||
                Email.Equals("") || password.Equals("")
                || con_password.Equals("") || date_naissance.Equals("") || num_tel.Equals("") || ((radio_etudiant.IsChecked == false) && (radio_professeur.IsChecked == false)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean checkusername()
        {
            //DONNEE SAISIE
            
           
                //connexion avec la base de donnée
                SqlConnection connexion = new SqlConnection();
                connexion.ConnectionString = str_conn;
                //ouvrir la connexion
                connexion.Open();
                //inserer la requete sql
                SqlCommand command = connexion.CreateCommand();
                string requete = "SELECT email FROM utilisateur WHERE email=@email";
            //definir les parametres
            SqlParameter param1 = new SqlParameter("@email", email.Text);

                //ajouter les parametres à la requete
                command.Parameters.Add(param1);
                command.CommandText = requete;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            
            
               
            

        }

        private void navigationFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
