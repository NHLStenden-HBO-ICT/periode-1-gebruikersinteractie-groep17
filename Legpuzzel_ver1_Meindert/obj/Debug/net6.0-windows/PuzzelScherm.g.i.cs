﻿#pragma checksum "..\..\..\PuzzelScherm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "387BB026114C551C4FA7EC4EF1A407CDFA2D6918"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Legpuzzel_ver1_Meindert;
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


namespace Legpuzzel_ver1_Meindert {
    
    
    /// <summary>
    /// PuzzelScherm
    /// </summary>
    public partial class PuzzelScherm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\PuzzelScherm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\PuzzelScherm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RestartButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\PuzzelScherm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas PuzzleCanvas;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Legpuzzel_ver1_Meindert;component/puzzelscherm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PuzzelScherm.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\PuzzelScherm.xaml"
            ((Legpuzzel_ver1_Meindert.PuzzelScherm)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\PuzzelScherm.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RestartButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\PuzzelScherm.xaml"
            this.RestartButton.Click += new System.Windows.RoutedEventHandler(this.RestartButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PuzzleCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

