﻿#pragma checksum "..\..\..\..\Windows\AddEditJobsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5116744EC73D65D6E6929A65CBA06C73AE2E8A4D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using WPFMecaApp.Windows;


namespace WPFMecaApp.Windows {
    
    
    /// <summary>
    /// AddEditJobsWindow
    /// </summary>
    public partial class AddEditJobsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Windows\AddEditJobsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UserSelect;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Windows\AddEditJobsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CarSelect;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Windows\AddEditJobsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox SegmentSelect;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Windows\AddEditJobsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Submit;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Windows\AddEditJobsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFMecaApp;component/windows/addeditjobswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\AddEditJobsWindow.xaml"
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
            
            #line 12 "..\..\..\..\Windows\AddEditJobsWindow.xaml"
            ((WPFMecaApp.Windows.AddEditJobsWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UserSelect = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\..\Windows\AddEditJobsWindow.xaml"
            this.UserSelect.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.User_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CarSelect = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\..\Windows\AddEditJobsWindow.xaml"
            this.CarSelect.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CarSelect_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SegmentSelect = ((System.Windows.Controls.ListBox)(target));
            
            #line 28 "..\..\..\..\Windows\AddEditJobsWindow.xaml"
            this.SegmentSelect.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SegmentSelect_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Submit = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Windows\AddEditJobsWindow.xaml"
            this.Submit.Click += new System.Windows.RoutedEventHandler(this.Submit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Windows\AddEditJobsWindow.xaml"
            this.Cancel.Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

