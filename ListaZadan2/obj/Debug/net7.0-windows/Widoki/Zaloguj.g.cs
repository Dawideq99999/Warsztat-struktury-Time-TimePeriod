﻿#pragma checksum "..\..\..\..\Widoki\Zaloguj.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DB3E1D85592149F2F6194583B4B8A43F4EB3557F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ListaZadan.Widoki;
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


namespace ListaZadan.Widoki {
    
    
    /// <summary>
    /// Zaloguj
    /// </summary>
    public partial class Zaloguj : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Widoki\Zaloguj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LoginTekst;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Widoki\Zaloguj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HasloTekst;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Widoki\Zaloguj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginPole;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Widoki\Zaloguj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HasloPole;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Widoki\Zaloguj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ZalogujPrzycisk;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Widoki\Zaloguj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ZalozKontoTekst;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ListaZadan;component/widoki/zaloguj.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Widoki\Zaloguj.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LoginTekst = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.HasloTekst = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.LoginPole = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.HasloPole = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ZalogujPrzycisk = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\Widoki\Zaloguj.xaml"
            this.ZalogujPrzycisk.Click += new System.Windows.RoutedEventHandler(this.Zaloguj_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ZalozKontoTekst = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 16 "..\..\..\..\Widoki\Zaloguj.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.ZalozKonto_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

