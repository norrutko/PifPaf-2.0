﻿#pragma checksum "..\..\AddScoreClass.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BF36F9B045100ED2942E4013701FC9C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Strzelnica;
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


namespace Strzelnica {
    
    
    /// <summary>
    /// AddScore
    /// </summary>
    public partial class AddScore : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\AddScoreClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NickTextBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AddScoreClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Month;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\AddScoreClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ChickenPointsBox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\AddScoreClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BoarPointsBox;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\AddScoreClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TurkeyPointsBox;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\AddScoreClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MouflonPointsBox;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\AddScoreClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddScoreButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Strzelnica;component/addscoreclass.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddScoreClass.xaml"
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
            this.NickTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Month = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.ChickenPointsBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.BoarPointsBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.TurkeyPointsBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.MouflonPointsBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.AddScoreButton = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\AddScoreClass.xaml"
            this.AddScoreButton.Click += new System.Windows.RoutedEventHandler(this.AddScoreButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

