﻿#pragma checksum "..\..\..\..\..\OsTrader\Panels\PanelsGui\PairRsiTradeUi.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95D8EDBCA49B5B7D79DF70DFB1A7E18ABE0E68CE"
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


namespace OsEngine.OsTrader.Panels.PanelsGui {
    
    
    /// <summary>
    /// PairRsiTradeUi
    /// </summary>
    public partial class PairRsiTradeUi : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\..\..\OsTrader\Panels\PanelsGui\PairRsiTradeUi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelVolume1;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\..\..\OsTrader\Panels\PanelsGui\PairRsiTradeUi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxVolumeOne;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\..\..\OsTrader\Panels\PanelsGui\PairRsiTradeUi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelRsiDifference;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\..\OsTrader\Panels\PanelsGui\PairRsiTradeUi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Spread;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\OsTrader\Panels\PanelsGui\PairRsiTradeUi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAccept;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\OsTrader\Panels\PanelsGui\PairRsiTradeUi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxVolumeTwo;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\OsTrader\Panels\PanelsGui\PairRsiTradeUi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelVolume2;
        
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
            System.Uri resourceLocater = new System.Uri("/OsEngine;component/ostrader/panels/panelsgui/pairrsitradeui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\OsTrader\Panels\PanelsGui\PairRsiTradeUi.xaml"
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
            this.LabelVolume1 = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.TextBoxVolumeOne = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.LabelRsiDifference = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Spread = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ButtonAccept = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\..\OsTrader\Panels\PanelsGui\PairRsiTradeUi.xaml"
            this.ButtonAccept.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TextBoxVolumeTwo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.LabelVolume2 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
