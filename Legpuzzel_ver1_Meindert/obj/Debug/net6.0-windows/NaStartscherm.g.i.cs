﻿#pragma checksum "..\..\..\NaStartscherm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F5A3056EFAE98362EC3AC0E04A17F41442CDBC50"
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
    /// NaStartscherm
    /// </summary>
    public partial class NaStartscherm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\NaStartscherm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image LOGO;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\NaStartscherm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MuziekKnop;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\NaStartscherm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPlayerName1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\NaStartscherm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPlayerName2;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\NaStartscherm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartButton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\NaStartscherm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackArrow;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\NaStartscherm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Legpuzzel_ver1_Meindert;V1.0.0.0;component/nastartscherm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\NaStartscherm.xaml"
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
            this.LOGO = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.MuziekKnop = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\NaStartscherm.xaml"
            this.MuziekKnop.Click += new System.Windows.RoutedEventHandler(this.MuziekKnop_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtPlayerName1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtPlayerName2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.StartButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\NaStartscherm.xaml"
            this.StartButton.Click += new System.Windows.RoutedEventHandler(this.StartButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BackArrow = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\NaStartscherm.xaml"
            this.BackArrow.Click += new System.Windows.RoutedEventHandler(this.BackArrow_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\NaStartscherm.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

