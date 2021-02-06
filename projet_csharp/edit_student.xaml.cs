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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace projet_csharp
{
    /// <summary>
    /// Logique d'interaction pour edit_student.xaml
    /// </summary>
    public partial class edit_student : Page
    {
         

 


        public edit_student(int e)
        {

            InitializeComponent();
            string mycon = "Data Source=DESKTOP-4H2RVTQ\\SQLEXPRESS;Initial Catalog=gestion_absence;Integrated Security=True";
           
          
            //ouvrir la connexion
          
            
            string myquery = "Select * from Etudiant where cne=" + e;
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cne.Text = ds.Tables[0].Rows[0]["cne"].ToString();
                nom.Text = ds.Tables[0].Rows[0]["nom"].ToString();
                prenom.Text = ds.Tables[0].Rows[0]["prenom"].ToString();
                sexe.Text = ds.Tables[0].Rows[0]["sexe"].ToString();
                dtn.Text = ds.Tables[0].Rows[0]["date_Naissance"].ToString();
            }
            con.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {

            string str_conn = "Data Source=DESKTOP-4H2RVTQ\\SQLEXPRESS;Initial Catalog=gestion_absence;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str_conn;
            SqlCommand cmd;
            //ouvrir la connexion
            con.Open();
            cmd = new SqlCommand("update Etudiant set nom=@nom,prenom=@pre,sexe=@s,date_Naissance=@dn where cne=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", cne.Text);
            cmd.Parameters.AddWithValue("@nom", nom.Text);
            cmd.Parameters.AddWithValue("@pre", prenom.Text);
            cmd.Parameters.AddWithValue("@s", sexe.Text);
            cmd.Parameters.AddWithValue("@dn", dtn.Text);
            cmd.ExecuteNonQuery();
            System.Windows.MessageBox.Show("Etudiant modifié  avec succées ");
            con.Close();
            NavigationService navService = NavigationService.GetNavigationService(this);
            students s = new students();

            navService.Navigate(s);
        }
        private void Annuler(object sender, EventArgs e)
        {



            if (MessageBox.Show("étes vous sur de quitter cette page ! ", "Gestion d'absence", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                NavigationService navService = NavigationService.GetNavigationService(this);
                students s = new students();

                navService.Navigate(s);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string str_conn = "Data Source=DESKTOP-4H2RVTQ\\SQLEXPRESS;Initial Catalog=gestion_absence;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str_conn;
            SqlCommand cmd;
            //ouvrir la connexion
          
            cmd = new SqlCommand("update Etudiant set nom=@nom,prenom=@pre,sexe=@s,date_Naissance=@dn where cne=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", cne.Text);
            cmd.Parameters.AddWithValue("@nom", nom.Text);
            cmd.Parameters.AddWithValue("@pre", prenom.Text);
            cmd.Parameters.AddWithValue("@s", sexe.Text);
            cmd.Parameters.AddWithValue("@dn", dtn.Text);
            cmd.ExecuteNonQuery();
            System.Windows.MessageBox.Show("Etudiant modifié  avec succées ");
            con.Close();
            NavigationService navService = NavigationService.GetNavigationService(this);
            students s = new students();

            navService.Navigate(s);
        }
    }
}
