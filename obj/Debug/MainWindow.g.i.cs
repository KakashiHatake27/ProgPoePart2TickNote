// Updated by XamlIntelliSenseFileGenerator 2022/11/02 14:15:10
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9CED1B5ABA363F0E13CB49A3389207DA9AC2F1FBA4FFAFDCA21C9CDEBBD1D70F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProgPoeTickNotePart2;
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


namespace ProgPoeTickNotePart2
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush _img_bg;

#line default
#line hidden


#line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgLogo;

#line default
#line hidden


#line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgClose;

#line default
#line hidden


#line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRefreshModules;

#line default
#line hidden


#line 106 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddModule;

#line default
#line hidden


#line 146 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgSession;

#line default
#line hidden


#line 180 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddSession;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProgPoeTickNotePart2;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 11 "..\..\MainWindow.xaml"
                    ((ProgPoeTickNotePart2.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);

#line default
#line hidden
                    return;
                case 2:
                    this._img_bg = ((System.Windows.Media.ImageBrush)(target));
                    return;
                case 3:
                    this.imgLogo = ((System.Windows.Controls.Image)(target));
                    return;
                case 4:
                    this.imgClose = ((System.Windows.Controls.Image)(target));

#line 31 "..\..\MainWindow.xaml"
                    this.imgClose.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgClose_MouseDown);

#line default
#line hidden
                    return;
                case 5:
                    this.btnRefreshModules = ((System.Windows.Controls.Button)(target));

#line 38 "..\..\MainWindow.xaml"
                    this.btnRefreshModules.Click += new System.Windows.RoutedEventHandler(this.btnRefreshModules_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.dgModule = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 7:
                    this.btnAddModule = ((System.Windows.Controls.Button)(target));

#line 107 "..\..\MainWindow.xaml"
                    this.btnAddModule.Click += new System.Windows.RoutedEventHandler(this.btnAddModule_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.dgSession = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 9:
                    this.btnAddSession = ((System.Windows.Controls.Button)(target));

#line 189 "..\..\MainWindow.xaml"
                    this.btnAddSession.Click += new System.Windows.RoutedEventHandler(this.btnAddSession_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.DataGrid dgModules;
    }
}

