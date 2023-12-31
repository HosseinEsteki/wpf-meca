﻿#pragma checksum "..\..\..\..\..\Windows\UserDetailsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "579C002EC02CEC5959A9562609FA49F3DA6EFD15"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
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
using WPFMecaApp.Windows;


namespace WPFMecaApp.Windows {
    
    
    /// <summary>
    /// UserDetailsWindow
    /// </summary>
    public partial class UserDetailsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\..\Windows\UserDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelUserName;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\Windows\UserDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelPhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\Windows\UserDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelCarsNumber;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\..\Windows\UserDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView carsListView;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\Windows\UserDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu Name;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\Windows\UserDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu km;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\..\Windows\UserDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAddCar;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\..\Windows\UserDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonEditCar;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\..\Windows\UserDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonRemoveCar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFMecaApp;component/windows/userdetailswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\UserDetailsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.labelUserName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.labelPhoneNumber = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.labelCarsNumber = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.carsListView = ((System.Windows.Controls.ListView)(target));
            
            #line 50 "..\..\..\..\..\Windows\UserDetailsWindow.xaml"
            this.carsListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Name = ((System.Windows.Controls.ContextMenu)(target));
            
            #line 57 "..\..\..\..\..\Windows\UserDetailsWindow.xaml"
            this.Name.AddHandler(System.Windows.Controls.MenuItem.ClickEvent, new System.Windows.RoutedEventHandler(this.Name_Click));
            
            #line default
            #line hidden
            return;
            case 6:
            this.km = ((System.Windows.Controls.ContextMenu)(target));
            
            #line 68 "..\..\..\..\..\Windows\UserDetailsWindow.xaml"
            this.km.AddHandler(System.Windows.Controls.MenuItem.ClickEvent, new System.Windows.RoutedEventHandler(this.km_Click));
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonAddCar = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\..\Windows\UserDetailsWindow.xaml"
            this.buttonAddCar.Click += new System.Windows.RoutedEventHandler(this.buttonAddCar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonEditCar = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\..\..\Windows\UserDetailsWindow.xaml"
            this.buttonEditCar.Click += new System.Windows.RoutedEventHandler(this.buttonEditCar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonRemoveCar = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\..\..\Windows\UserDetailsWindow.xaml"
            this.buttonRemoveCar.Click += new System.Windows.RoutedEventHandler(this.buttonRemoveCar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

