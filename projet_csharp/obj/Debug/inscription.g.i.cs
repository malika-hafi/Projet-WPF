﻿#pragma checksum "..\..\inscription.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B1DEF2B520E9EF8184578E1D1CCE4E0C052DAB52D55C5F2296ABE6EA7F363EBF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using projet_csharp;


namespace projet_csharp {
    
    
    /// <summary>
    /// inscription
    /// </summary>
    public partial class inscription : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run username;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nom;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox prenom;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox mot_passe;
        
        #line default
        #line hidden
        
        
        #line 214 "..\..\inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox con_motpasse;
        
        #line default
        #line hidden
        
        
        #line 236 "..\..\inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker date;
        
        #line default
        #line hidden
        
        
        #line 264 "..\..\inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tel;
        
        #line default
        #line hidden
        
        
        #line 269 "..\..\inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_etudiant;
        
        #line default
        #line hidden
        
        
        #line 286 "..\..\inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_inscription;
        
        #line default
        #line hidden
        
        
        #line 293 "..\..\inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_professeur;
        
        #line default
        #line hidden
        
        
        #line 296 "..\..\inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame navigationFrame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/projet_csharp;component/inscription.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\inscription.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.username = ((System.Windows.Documents.Run)(target));
            return;
            case 2:
            this.nom = ((System.Windows.Controls.TextBox)(target));
            
            #line 68 "..\..\inscription.xaml"
            this.nom.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.User_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.prenom = ((System.Windows.Controls.TextBox)(target));
            
            #line 82 "..\..\inscription.xaml"
            this.prenom.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.User_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.email = ((System.Windows.Controls.TextBox)(target));
            
            #line 96 "..\..\inscription.xaml"
            this.email.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.User_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mot_passe = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            
            #line 143 "..\..\inscription.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tologin);
            
            #line default
            #line hidden
            return;
            case 7:
            this.con_motpasse = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.date = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.tel = ((System.Windows.Controls.TextBox)(target));
            
            #line 266 "..\..\inscription.xaml"
            this.tel.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.User_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.radio_etudiant = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 11:
            this.btn_inscription = ((System.Windows.Controls.Button)(target));
            
            #line 292 "..\..\inscription.xaml"
            this.btn_inscription.Click += new System.Windows.RoutedEventHandler(this.btn_inscription_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.radio_professeur = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 13:
            this.navigationFrame = ((System.Windows.Controls.Frame)(target));
            
            #line 296 "..\..\inscription.xaml"
            this.navigationFrame.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.navigationFrame_Navigated);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

