﻿#pragma checksum "..\..\UC_Contestar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "09D9D3EE39BC2D57EEC6F026D63B54F2456BAFAED540D54D76A4E40B4874A0C6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LIT;
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


namespace LIT {
    
    
    /// <summary>
    /// UC_Contestar
    /// </summary>
    public partial class UC_Contestar : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 59 "..\..\UC_Contestar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBX_Pregunta;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\UC_Contestar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNDisminuirLetra;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\UC_Contestar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNAumentarLetra;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\UC_Contestar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBX_Answer;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\UC_Contestar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNDisminuirLetraAnswer;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\UC_Contestar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNAumentarLetraAnswer;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\UC_Contestar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_SearchDB;
        
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
            System.Uri resourceLocater = new System.Uri("/LIT;component/uc_contestar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UC_Contestar.xaml"
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
            this.TBX_Pregunta = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.BTNDisminuirLetra = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\UC_Contestar.xaml"
            this.BTNDisminuirLetra.Click += new System.Windows.RoutedEventHandler(this.DisminuirLetraQuestion);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BTNAumentarLetra = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\UC_Contestar.xaml"
            this.BTNAumentarLetra.Click += new System.Windows.RoutedEventHandler(this.AumentarLetraQuestion);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TBX_Answer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BTNDisminuirLetraAnswer = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\UC_Contestar.xaml"
            this.BTNDisminuirLetraAnswer.Click += new System.Windows.RoutedEventHandler(this.DisminuirLetraAnswer);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BTNAumentarLetraAnswer = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\UC_Contestar.xaml"
            this.BTNAumentarLetraAnswer.Click += new System.Windows.RoutedEventHandler(this.AumentarLetraAnswer);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BTN_SearchDB = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\UC_Contestar.xaml"
            this.BTN_SearchDB.Click += new System.Windows.RoutedEventHandler(this.BTN_SearchDB_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

