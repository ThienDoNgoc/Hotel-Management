﻿#pragma checksum "..\..\..\BookingReservationWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A4E80F8F0259E80C762C650A8A86B30E621F1570"
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
    /// BookingReservationWindow
    /// </summary>
    public partial class BookingReservationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 14 "..\..\..\BookingReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BookingReservationIdtxt;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\BookingReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BookingDatetxt;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\BookingReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TotalPricetxt;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\BookingReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomerEmailAddresstxt;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\BookingReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Deletebtn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\BookingReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Insertbtn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\BookingReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvBookingReservation;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\BookingReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvBookingDetails;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\BookingReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Closebtn;
        
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
            System.Uri resourceLocater = new System.Uri("/DoNgocThienWPF;component/bookingreservationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BookingReservationWindow.xaml"
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
            this.BookingReservationIdtxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.BookingDatetxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TotalPricetxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CustomerEmailAddresstxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Deletebtn = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\BookingReservationWindow.xaml"
            this.Deletebtn.Click += new System.Windows.RoutedEventHandler(this.Deletebtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Insertbtn = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\BookingReservationWindow.xaml"
            this.Insertbtn.Click += new System.Windows.RoutedEventHandler(this.Insertbtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lvBookingReservation = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            this.lvBookingDetails = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            this.Closebtn = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\BookingReservationWindow.xaml"
            this.Closebtn.Click += new System.Windows.RoutedEventHandler(this.Closebtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 8:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonDownEvent;
            
            #line 34 "..\..\..\BookingReservationWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.ListViewItem_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

