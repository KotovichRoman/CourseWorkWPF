﻿#pragma checksum "..\..\..\..\Pages\AddAlbumPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63BE1D07F8264DA9843A5DF2A4FEA68C04AC0510"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Client.Pages;
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


namespace Client.Pages {
    
    
    /// <summary>
    /// AddAlbumPage
    /// </summary>
    public partial class AddAlbumPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Pages\AddAlbumPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddTrackButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Pages\AddAlbumPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeTrackButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\AddAlbumPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteTrackButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\AddAlbumPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AlbumName;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Pages\AddAlbumPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AlbumImage;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Pages\AddAlbumPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TracksList;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\Pages\AddAlbumPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddAlbumButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Client;component/pages/addalbumpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\AddAlbumPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AddTrackButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Pages\AddAlbumPage.xaml"
            this.AddTrackButton.Click += new System.Windows.RoutedEventHandler(this.AddTrackButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ChangeTrackButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Pages\AddAlbumPage.xaml"
            this.ChangeTrackButton.Click += new System.Windows.RoutedEventHandler(this.ChangeTrackButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeleteTrackButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Pages\AddAlbumPage.xaml"
            this.DeleteTrackButton.Click += new System.Windows.RoutedEventHandler(this.DeleteTrackButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AlbumName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AlbumImage = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\Pages\AddAlbumPage.xaml"
            this.AlbumImage.Click += new System.Windows.RoutedEventHandler(this.AlbumImage_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TracksList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.AddAlbumButton = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\Pages\AddAlbumPage.xaml"
            this.AddAlbumButton.Click += new System.Windows.RoutedEventHandler(this.AddAlbumButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

