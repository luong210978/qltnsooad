﻿#pragma checksum "..\..\..\View\PhieuThuTienUC.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3B44F41036CA2A6A351D244F95C773B4741BC3A0E4F429BD7A66180C9BD59DD6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BookStoreClone.View;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using System.Windows.Interactivity;
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


namespace BookStoreClone.View {
    
    
    /// <summary>
    /// PhieuThuTienUC
    /// </summary>
    public partial class PhieuThuTienUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\View\PhieuThuTienUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Card pnlthutien;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\View\PhieuThuTienUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel pnlThongTinKhachHang;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\View\PhieuThuTienUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataHD_KH;
        
        #line default
        #line hidden
        
        
        #line 259 "..\..\..\View\PhieuThuTienUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnThanhToan;
        
        #line default
        #line hidden
        
        
        #line 401 "..\..\..\View\PhieuThuTienUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datahd;
        
        #line default
        #line hidden
        
        
        #line 485 "..\..\..\View\PhieuThuTienUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel pnlQuanLyKhachHang;
        
        #line default
        #line hidden
        
        
        #line 519 "..\..\..\View\PhieuThuTienUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataKhachHang;
        
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
            System.Uri resourceLocater = new System.Uri("/BookStoreClone;component/view/phieuthutienuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\PhieuThuTienUC.xaml"
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
            this.pnlthutien = ((MaterialDesignThemes.Wpf.Card)(target));
            return;
            case 2:
            this.pnlThongTinKhachHang = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 3:
            this.dataHD_KH = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.btnThanhToan = ((System.Windows.Controls.Button)(target));
            
            #line 259 "..\..\..\View\PhieuThuTienUC.xaml"
            this.btnThanhToan.Click += new System.Windows.RoutedEventHandler(this.btnThanhToan_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.datahd = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.pnlQuanLyKhachHang = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 7:
            this.dataKhachHang = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

