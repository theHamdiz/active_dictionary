﻿#pragma checksum "..\..\..\Pages\translator.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BF411DB36BA3EF43C1E482C76A3104FC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.32559
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
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


namespace Active_Dictionary.Pages {
    
    
    internal partial class Translator : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\Pages\translator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Active_Dictionary.Pages.Translator TranslateUnit;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\translator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.ComboBox ComboTo;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\translator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.ComboBox ComboFrom;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\translator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.TextBox TxtSource;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\translator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.TextBox TxtTarget;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Pages\translator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.TextBox EditReverseTranslation;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Pages\translator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FirstFloor.ModernUI.Windows.Controls.ModernButton btnSpeak;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Pages\translator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar ProgressWait;
        
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
            System.Uri resourceLocater = new System.Uri("/Active Dictionary;component/pages/translator.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\translator.xaml"
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
            this.TranslateUnit = ((Active_Dictionary.Pages.Translator)(target));
            return;
            case 2:
            this.ComboTo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.ComboFrom = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            
            #line 24 "..\..\..\Pages\translator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnTranslate_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TxtSource = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TxtTarget = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.EditReverseTranslation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnSpeak = ((FirstFloor.ModernUI.Windows.Controls.ModernButton)(target));
            
            #line 66 "..\..\..\Pages\translator.xaml"
            this.btnSpeak.Click += new System.Windows.RoutedEventHandler(this.BtnSpeak_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ProgressWait = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
