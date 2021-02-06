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
    /// Logique d'interaction pour module.xaml
    /// </summary>
    public partial class module : Page
    {
        SqlCommand cmd;
       

        public module()
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
            cmd.CommandText = "select * from [Modules]";
            cmd.Connection = con;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Modules");
            ad.Fill(dt);
            g2.ItemsSource = dt.DefaultView;

        }
        private void Add_module(object sender, RoutedEventArgs e)
        {
            
            NavigationService navService = NavigationService.GetNavigationService(this);
            Ajouter_module s = new Ajouter_module();

            navService.Navigate(s);
        }
        private void Edit(object sender, RoutedEventArgs e)
        {

            DataRowView row = g2.SelectedItem as DataRowView;
            // MessageBox.Show(row.Row.ItemArray[1].ToString());
            NavigationService navService = NavigationService.GetNavigationService(this);

            Modifier_Module s = new Modifier_Module((int)row.Row.ItemArray[0]);

            navService.Navigate(s);

        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("étes vous sur de supprimer cet module ! ", "Gestion d'absence", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                DataRowView row = g2.SelectedItem as DataRowView;
                // MessageBox.Show(row.Row.ItemArray[1].ToString());

                string str_conn = "Data Source=DESKTOP-4H2RVTQ\\SQLEXPRESS;Initial Catalog=gestion_absence;Integrated Security=True";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = str_conn;
                //ouvrir la connexion
                con.Open();

                cmd = new SqlCommand("DELETE FROM Modules WHERE id=@id", con);
                cmd.Parameters.AddWithValue("@id", (int)row.Row.ItemArray[0]);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("module supprimé avec succées!", "Gestion d'absence", MessageBoxButtons.OK);


                NavigationService navService = NavigationService.GetNavigationService(this);
                module s = new module();

                navService.Navigate(s);

            }
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

        private void nom_btn_Initialized(object sender, EventArgs e)
        {
            nom_btn.Content = Login_page.username1;
        }
    }
}

