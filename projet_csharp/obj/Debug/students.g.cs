﻿#pragma checksum "..\..\students.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6FDDA9C8655E4C05AD03CB672E171915618B35EDAC8624ED07D1DBB2D244613B"
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
    /// students
    /// </summary>
    public partial class students : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 87 "..\..\students.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nom_btn;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\students.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton acceuil_prof;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\students.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton statistique;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\students.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton gestion_etudiant;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\students.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton filiere_btn;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\students.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton gestion_absence;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\students.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search;
        
        #line default
        #line hidden
        
        
        #line 248 "..\..\students.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid g1;
        
        #line default
        #line hidden
        
        
        #line 290 "..\..\students.xaml"
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
            System.Uri resourceLocater = new System.Uri("/projet_csharp;component/students.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\students.xaml"
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
            this.nom_btn = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\students.xaml"
            this.nom_btn.Initialized += new System.EventHandler(this.nom_btn_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.acceuil_prof = ((System.Windows.Controls.RadioButton)(target));
            
            #line 132 "..\..\students.xaml"
            this.acceuil_prof.Checked += new System.Windows.RoutedEventHandler(this.acceuil_prof_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.statistique = ((System.Windows.Controls.RadioButton)(target));
            
            #line 134 "..\..\students.xaml"
            this.statistique.Checked += new System.Windows.RoutedEventHandler(this.statistique_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gestion_etudiant = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.filiere_btn = ((System.Windows.Controls.RadioButton)(target));
            
            #line 138 "..\..\students.xaml"
            this.filiere_btn.Checked += new System.Windows.RoutedEventHandler(this.filiere_btn_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.gestion_absence = ((System.Windows.Controls.RadioButton)(target));
            
            #line 140 "..\..\students.xaml"
            this.gestion_absence.Checked += new System.Windows.RoutedEventHandler(this.gestion_absence_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.search = ((System.Windows.Controls.TextBox)(target));
            
            #line 186 "..\..\students.xaml"
            this.search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 192 "..\..\students.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_student);
            
            #line default
            #line hidden
            return;
            case 9:
            this.g1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 12:
            this.navigationFrame = ((System.Windows.Controls.Frame)(target));
            
            #line 290 "..\..\students.xaml"
            this.navigationFrame.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.navigationFrame_Navigated);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 10:
            
            #line 258 "..\..\students.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.delete_btn_Click);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 269 "..\..\students.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

