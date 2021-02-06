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
    /// Logique d'interaction pour Affectation.xaml
    /// </summary>
    public partial class Affectation : Page
    {
        SqlCommand cmd; SqlCommand cmd1, cmd3, cmd4, cmd5;
        SqlConnection con;
        int id_seance;
        int id_etudiant;
        int id_module;
        string module;
        public Affectation(int id_etudiant, int id_seance)
        {
            InitializeComponent();
            this.id_seance = id_seance;
            this.id_etudiant = id_etudiant;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("étes vous sur de quitter cette page ! ", "Gestion d'absence", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                NavigationService navService = NavigationService.GetNavigationService(this);
                Affecter_absence s = new Affecter_absence();

                navService.Navigate(s);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {



            string str_conn = "Data Source=DESKTOP-4H2RVTQ\\SQLEXPRESS;Initial Catalog=gestion_absence;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str_conn;
            //ouvrir la connexion
            con.Open();

            cmd = new SqlCommand("INSERT INTO Absence ( cne,module,nom,prénom,date,heure_début,heure_fin,type_séance,justifier," +
                "justification) VALUES (@cne,@mdl,@nom,@prenom,@date,@heure_début,@heure_fin,@type,@justifier,@justification)", con);



            cmd.Parameters.AddWithValue("@cne", id_etudiant);
            cmd.Parameters.AddWithValue("@justifier", isJustifie.Text);
            cmd.Parameters.AddWithValue("@justification", justification.Text);




            //select etudiant info
            cmd1 = new SqlCommand("SELECT * FROM Etudiant WHERE cne=@id", con);
            cmd1.Parameters.AddWithValue("@id", id_etudiant);
            cmd1.ExecuteNonQuery();
            //edit nb absence etudiant
            cmd3 = new SqlCommand("UPDATE Etudiant SET nombre_absence=@nb WHERE cne=@id", con);
            cmd3.Parameters.AddWithValue("@id", id_etudiant);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                cmd.Parameters.AddWithValue("@nom", dr["nom"].ToString());
                cmd.Parameters.AddWithValue("@prenom", dr["prenom"].ToString());
                cmd3.Parameters.AddWithValue("@nb", Convert.ToInt32(dr["nombre_absence"]) + 1);

            }
            cmd3.ExecuteNonQuery();
            //get info de la seance
            cmd4 = new SqlCommand("SELECT * FROM Seance WHERE id=@id_s", con);
            cmd4.Parameters.AddWithValue("@id_s", id_seance);
            cmd4.ExecuteNonQuery();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd4);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                cmd.Parameters.AddWithValue("@heure_fin", dr1["heure_fin"].ToString());
                cmd.Parameters.AddWithValue("@date", dr1["date"].ToString());
                cmd.Parameters.AddWithValue("@type", dr1["type"].ToString());
                cmd.Parameters.AddWithValue("@heure_début", dr1["heure_début"].ToString());
                this.id_module = Convert.ToInt32(dr1["id_module"]);

            }

            //nom du module
            cmd5 = new SqlCommand("SELECT * FROM Modules WHERE id=@id_m", con);
            cmd5.Parameters.AddWithValue("@id_m", id_module);
            cmd5.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd5);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                this.module = dr2["module"].ToString();


            }
            cmd.Parameters.AddWithValue("@mdl", module);

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                MessageBox.Show("Absence effectué avec succées!", "Gestion d'absence", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
                NavigationService navService = NavigationService.GetNavigationService(this);
                gestion_absnc nextPage = new gestion_absnc();
                navService.Navigate(nextPage);
            }
            else
            {
                MessageBox.Show("Absence non ajouté  !", "Gestion d'absence", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
            }
        }
    }
}

