﻿#pragma checksum "..\..\..\..\..\UI\Registros\rTiposProducto.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0A1593B46289C61BC46622B59A2DFADE84D6C0EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Proyecto_Final_Repuesto.UI.Registros;
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


namespace Proyecto_Final_Repuesto.UI.Registros {
    
    
    /// <summary>
    /// rTiposProducto
    /// </summary>
    public partial class rTiposProducto : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\UI\Registros\rTiposProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TipoProductoIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\UI\Registros\rTiposProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BuscarButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\UI\Registros\rTiposProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescripcionTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\UI\Registros\rTiposProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NuevoButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\UI\Registros\rTiposProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GuardarButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\UI\Registros\rTiposProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EliminarButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Proyecto_Final_Repuesto;V1.0.0.0;component/ui/registros/rtiposproducto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Registros\rTiposProducto.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TipoProductoIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.BuscarButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\..\UI\Registros\rTiposProducto.xaml"
            this.BuscarButton.Click += new System.Windows.RoutedEventHandler(this.BuscarButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DescripcionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.NuevoButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\..\UI\Registros\rTiposProducto.xaml"
            this.NuevoButton.Click += new System.Windows.RoutedEventHandler(this.NuevoButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GuardarButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\..\UI\Registros\rTiposProducto.xaml"
            this.GuardarButton.Click += new System.Windows.RoutedEventHandler(this.GuardarButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EliminarButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\..\UI\Registros\rTiposProducto.xaml"
            this.EliminarButton.Click += new System.Windows.RoutedEventHandler(this.EliminarButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

