﻿#pragma checksum "..\..\..\..\vue\ModifierProduit.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B71653163BDEAE0CFF52D190FA65034C780194FA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using GestionCrudMvvm.Controllers;
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


namespace GestionCrudMvvm.Controllers {
    
    
    /// <summary>
    /// ModifierProduit
    /// </summary>
    public partial class ModifierProduit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 67 "..\..\..\..\vue\ModifierProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtId;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\vue\ModifierProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNom;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\vue\ModifierProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrix;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\..\vue\ModifierProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCout;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\..\vue\ModifierProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQuantite;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\..\vue\ModifierProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVille;
        
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
            System.Uri resourceLocater = new System.Uri("/GestionCrudMvvm;component/vue/modifierproduit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\vue\ModifierProduit.xaml"
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
            this.txtId = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txtNom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtPrix = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtCout = ((System.Windows.Controls.TextBox)(target));
            
            #line 150 "..\..\..\..\vue\ModifierProduit.xaml"
            this.txtCout.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtCout_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtQuantite = ((System.Windows.Controls.TextBox)(target));
            
            #line 175 "..\..\..\..\vue\ModifierProduit.xaml"
            this.txtQuantite.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtQuantite_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtVille = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 209 "..\..\..\..\vue\ModifierProduit.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Modifier);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

