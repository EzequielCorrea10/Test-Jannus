﻿#pragma checksum "..\..\..\View\ProductType.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "549F47D8EAB600249F4935652797081EE853E93CAA8C09361651DCCBA782FDC0"
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
using System.Windows.Forms.Integration;
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


namespace TEST {
    
    
    /// <summary>
    /// ProductTypeView
    /// </summary>
    public partial class ProductTypeView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\View\ProductType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas AddProduct;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\ProductType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewDescription;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\View\ProductType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ProductType;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\View\ProductType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn TypeId;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\View\ProductType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn Description;
        
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
            System.Uri resourceLocater = new System.Uri("/TEST;component/view/producttype.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ProductType.xaml"
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
            
            #line 8 "..\..\..\View\ProductType.xaml"
            ((TEST.ProductTypeView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded_1);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 13 "..\..\..\View\ProductType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddProduct = ((System.Windows.Controls.Canvas)(target));
            return;
            case 4:
            this.NewDescription = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\View\ProductType.xaml"
            this.NewDescription.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 17 "..\..\..\View\ProductType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddProductType_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ProductType = ((System.Windows.Controls.ListView)(target));
            
            #line 20 "..\..\..\View\ProductType.xaml"
            this.ProductType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TypeId = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 8:
            this.Description = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
