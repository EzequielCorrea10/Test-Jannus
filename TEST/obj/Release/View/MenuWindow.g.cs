﻿#pragma checksum "..\..\..\View\MenuWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AF7978048832337DFAFDFCEA5C83021DA106E0EC64F813ACC6B1BE11727AEBCA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using TEST;


namespace TEST {
    
    
    /// <summary>
    /// MenuWindow
    /// </summary>
    public partial class MenuWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\View\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas StockReport;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stockRe;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas AddProduct;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\View\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\View\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas EditProduct;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\View\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button edit;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas DeleteProduct;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Exit;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Stock;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\View\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stock;
        
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
            System.Uri resourceLocater = new System.Uri("/TEST;component/view/menuwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\MenuWindow.xaml"
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
            this.StockReport = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.stockRe = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\View\MenuWindow.xaml"
            this.stockRe.Click += new System.Windows.RoutedEventHandler(this.StockRep_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddProduct = ((System.Windows.Controls.Canvas)(target));
            return;
            case 4:
            this.add = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\View\MenuWindow.xaml"
            this.add.Click += new System.Windows.RoutedEventHandler(this.AddProduct_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EditProduct = ((System.Windows.Controls.Canvas)(target));
            return;
            case 6:
            this.edit = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\View\MenuWindow.xaml"
            this.edit.Click += new System.Windows.RoutedEventHandler(this.Edit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DeleteProduct = ((System.Windows.Controls.Canvas)(target));
            return;
            case 8:
            
            #line 26 "..\..\..\View\MenuWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Exit = ((System.Windows.Controls.Canvas)(target));
            return;
            case 10:
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\View\MenuWindow.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Stock = ((System.Windows.Controls.Canvas)(target));
            return;
            case 12:
            this.stock = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\View\MenuWindow.xaml"
            this.stock.Click += new System.Windows.RoutedEventHandler(this.Stock_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

