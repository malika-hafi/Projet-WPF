﻿using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour acceuil_professeur.xaml
    /// </summary>
    public partial class acceuil_professeur : Page
    {
        public acceuil_professeur()
        {
            InitializeComponent();
        }

      
        

        private void filiere_btn_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void statistique_btn_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void gestion_etudiant_btn_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void gestion_absence_btn_Checked(object sender, RoutedEventArgs e)
        {
          
        }

        private void navigationFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void paint(object sender, RoutedEventArgs e)
        {
          
        }

        private void btn_nom_Initialized(object sender, EventArgs e)
        {
            btn_nom.Content = Login_page.username1;
        }

        private void modul_btn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void senace_btn_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
