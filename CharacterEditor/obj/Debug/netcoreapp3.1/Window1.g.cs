﻿#pragma checksum "..\..\..\Window1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D0B2C115B6C7C6AB50997CF294F23586BF93BF50"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CharacterEditor;
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


namespace CharacterEditor {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridSelectWarrior;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image classWarrior;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borderWarrior;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblStr;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDex;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInt;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCon;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas bttAddReduce;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bttReduce;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bttAdd;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CharacterEditor;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Window1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\Window1.xaml"
            ((CharacterEditor.Window1)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridSelectWarrior = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.classWarrior = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.borderWarrior = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.lblStr = ((System.Windows.Controls.Label)(target));
            
            #line 34 "..\..\..\Window1.xaml"
            this.lblStr.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lblStr_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblDex = ((System.Windows.Controls.Label)(target));
            
            #line 41 "..\..\..\Window1.xaml"
            this.lblDex.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lblDex_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblInt = ((System.Windows.Controls.Label)(target));
            
            #line 48 "..\..\..\Window1.xaml"
            this.lblInt.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lblInt_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblCon = ((System.Windows.Controls.Label)(target));
            
            #line 55 "..\..\..\Window1.xaml"
            this.lblCon.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lblCon_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.bttAddReduce = ((System.Windows.Controls.Canvas)(target));
            return;
            case 10:
            this.bttReduce = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Window1.xaml"
            this.bttReduce.Click += new System.Windows.RoutedEventHandler(this.bttReduce_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.bttAdd = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\Window1.xaml"
            this.bttAdd.Click += new System.Windows.RoutedEventHandler(this.bttAdd_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 84 "..\..\..\Window1.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lblStr_MouseDown);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 89 "..\..\..\Window1.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lblStr_MouseDown);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 94 "..\..\..\Window1.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lblStr_MouseDown);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 99 "..\..\..\Window1.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lblStr_MouseDown);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 104 "..\..\..\Window1.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lblStr_MouseDown);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 109 "..\..\..\Window1.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lblStr_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

