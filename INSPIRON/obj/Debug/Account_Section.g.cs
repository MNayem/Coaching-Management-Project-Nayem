﻿#pragma checksum "..\..\Account_Section.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D5E0A6DACC8A6EB81B2CA3D155A87E4B"
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


namespace INSPIRON {
    
    
    /// <summary>
    /// Account_Section
    /// </summary>
    public partial class Account_Section : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\Account_Section.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_income;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\Account_Section.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cost;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Account_Section.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_profit;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Account_Section.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_sms;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Account_Section.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_fee;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Account_Section.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/INSPIRON;component/account_section.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Account_Section.xaml"
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
            this.btn_income = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\Account_Section.xaml"
            this.btn_income.Click += new System.Windows.RoutedEventHandler(this.btn_income_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_cost = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\Account_Section.xaml"
            this.btn_cost.Click += new System.Windows.RoutedEventHandler(this.btn_cost_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_profit = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\Account_Section.xaml"
            this.btn_profit.Click += new System.Windows.RoutedEventHandler(this.btn_profit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_sms = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Account_Section.xaml"
            this.btn_sms.Click += new System.Windows.RoutedEventHandler(this.btn_sms_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_fee = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Account_Section.xaml"
            this.btn_fee.Click += new System.Windows.RoutedEventHandler(this.btn_fee_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_cancel = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Account_Section.xaml"
            this.btn_cancel.Click += new System.Windows.RoutedEventHandler(this.btn_cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
