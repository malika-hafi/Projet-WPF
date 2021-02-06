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
    /// Logique d'interaction pour Modifier_Module.xaml
    /// </summary>
    public partial class Modifier_Module : Page
    {
        
        int id;

        public Modifier_Module(int e)
        {
            id = e;
            InitializeComponent();
            string str_conn = "Data Source=DESKTOP-4H2RVTQ\\SQLEXPRESS;Initial Catalog=gestion_absence;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str_conn;
            //ouvrir la connexion
            con.Open();

            string myquery = "Select * from Modules where id=" + e;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                nom.Text = ds.Tables[0].Rows[0]["module"].ToString();
                respo.Text = ds.Tables[0].Rows[0]["responsable"].ToString();

            }
            con.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string str_conn = "Data Source=DESKTOP-4H2RVTQ\\SQLEXPRESS;Initial Catalog=gestion_absence;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str_conn;
            //ouvrir la connexion
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("update Modules set module=@nom,responsable=@pre  where id=@id", con);
            
            
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nom", nom.Text);
            cmd.Parameters.AddWithValue("@pre", respo.Text);

            cmd.ExecuteNonQuery();
            System.Windows.MessageBox.Show("module modifié  avec succées ");
            con.Close();
            NavigationService navService = NavigationService.GetNavigationService(this);
            module s = new module();

            navService.Navigate(s);
        }
        private void Annuler(object sender, EventArgs e)
        {



            if (MessageBox.Show("étes vous sur de quitter cette page ! ", "Gestion d'absence", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                NavigationService navService = NavigationService.GetNavigationService(this);
                module s = new module();

                navService.Navigate(s);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

