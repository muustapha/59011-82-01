﻿#pragma checksum "..\..\..\..\Vue\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5C5D880CF4E3726529038600EFF5698D97CE6FDF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using gereCrudMvc;


namespace gereCrudMvc {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\..\Vue\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Click_supprimer;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Vue\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Click_Modifier;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Vue\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Click_remplirGrid;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Vue\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Click_ajouter;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\Vue\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Click_sauvegarder;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\Vue\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgProduit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GereCrudMvc;component/vue/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Vue\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Button_Click_supprimer = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\Vue\MainWindow.xaml"
            this.Button_Click_supprimer.Click += new System.Windows.RoutedEventHandler(this.Button_Click_supprimer);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Button_Click_Modifier = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\Vue\MainWindow.xaml"
            this.Button_Click_Modifier.Click += new System.Windows.RoutedEventHandler(this.Button_Click_Modifier);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Button_Click_remplirGrid = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\Vue\MainWindow.xaml"
            this.Button_Click_remplirGrid.Click += new System.Windows.RoutedEventHandler(this.Button_Click_rempliDatagrid);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Button_Click_ajouter = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\..\Vue\MainWindow.xaml"
            this.Button_Click_ajouter.Click += new System.Windows.RoutedEventHandler(this.Button_Click_Ajouter);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Button_Click_sauvegarder = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\..\Vue\MainWindow.xaml"
            this.Button_Click_sauvegarder.Click += new System.Windows.RoutedEventHandler(this.Button_Click_sauvegarder);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dtgProduit = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

