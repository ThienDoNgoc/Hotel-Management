﻿#pragma checksum "..\..\..\UpdateCustomerWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "072F4DA403D12D1D0F91FF40CBEF5E7D89647B9B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FUMiniHotelSystem;
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


namespace FUMiniHotelSystem {
    
    
    /// <summary>
    /// UpdateCustomerWindow
    /// </summary>
    public partial class UpdateCustomerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\UpdateCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomerFullNametxt;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\UpdateCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Telephonetxt;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\UpdateCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailAddresstxt;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\UpdateCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker CustomerBirthdaytxt;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\UpdateCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Passwordtxt;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\UpdateCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateCustomerbtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DoNgocThienWPF;component/updatecustomerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UpdateCustomerWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CustomerFullNametxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Telephonetxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.EmailAddresstxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CustomerBirthdaytxt = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.Passwordtxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.UpdateCustomerbtn = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\UpdateCustomerWindow.xaml"
            this.UpdateCustomerbtn.Click += new System.Windows.RoutedEventHandler(this.UpdateCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 41 "..\..\..\UpdateCustomerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

