﻿#pragma checksum "..\..\..\Pages\CatalogMaterialPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "95F3B051C8B3FA887634D0AE4F49BADE0F6C21EB63F36BC0630C766037046224"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp1.Pages;


namespace WpfApp1.Pages {
    
    
    /// <summary>
    /// CatalogMaterialPage
    /// </summary>
    public partial class CatalogMaterialPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\CatalogMaterialPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTb;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\CatalogMaterialPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MaterialSortCb;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\CatalogMaterialPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MaterialFilterCb;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\CatalogMaterialPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox MaterialLb;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/pages/catalogmaterialpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\CatalogMaterialPage.xaml"
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
            
            #line 9 "..\..\..\Pages\CatalogMaterialPage.xaml"
            ((WpfApp1.Pages.CatalogMaterialPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\Pages\CatalogMaterialPage.xaml"
            this.SearchTb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTb_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MaterialSortCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\..\Pages\CatalogMaterialPage.xaml"
            this.MaterialSortCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MaterialSortCb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MaterialFilterCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\..\Pages\CatalogMaterialPage.xaml"
            this.MaterialFilterCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MaterialFilterCb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MaterialLb = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

