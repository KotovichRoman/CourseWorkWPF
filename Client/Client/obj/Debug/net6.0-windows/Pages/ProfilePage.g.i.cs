﻿#pragma checksum "..\..\..\..\Pages\ProfilePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70307F1925051170FD51D86F78416C896976FA35"
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
    /// ProfilePage
    /// </summary>
    public partial class ProfilePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\Pages\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image UserImage;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserLogin;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Pages\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserNickname;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SettingsButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Pages\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddAlbumButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Pages\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox AlbumsList;
        
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
            System.Uri resourceLocater = new System.Uri("/Client;V1.0.0.0;component/pages/profilepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\ProfilePage.xaml"
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
            this.UserImage = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.UserLogin = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.UserNickname = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.SettingsButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Pages\ProfilePage.xaml"
            this.SettingsButton.Click += new System.Windows.RoutedEventHandler(this.SettingsButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddAlbumButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Pages\ProfilePage.xaml"
            this.AddAlbumButton.Click += new System.Windows.RoutedEventHandler(this.AddAlbumButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AlbumsList = ((System.Windows.Controls.ListBox)(target));
            
            #line 32 "..\..\..\..\Pages\ProfilePage.xaml"
            this.AlbumsList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AlbumsList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

