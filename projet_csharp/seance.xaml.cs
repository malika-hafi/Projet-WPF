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
using MessageBox = System.Windows.Forms.MessageBox;

namespace projet_csharp
{
    /// <summary>
    /// Logique d'interaction pour seance.xaml
    /// </summary>
    public partial class seance : Page
    {

        SqlCommand cmd;
        public seance()
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
            cmd.CommandText = "select * from [Seance]";
            cmd.Connection = con;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Seance");
            ad.Fill(dt);
            g2.ItemsSource = dt.DefaultView;

        }

        private void nom_btn_Initialized(object sender, EventArgs e)
        {
            nom_btn.Content = Login_page.username1;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["connDatabse"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from [Modules] WHERE (module = '" + search.Text + "') or (responsable = '" + search.Text + "')";
            cmd.Connection = con;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Modules");
            ad.Fill(dt);
            g2.ItemsSource = dt.DefaultView;
            

        }
    }

   

      
}

