// Updated by XamlIntelliSenseFileGenerator 14-09-2023 17:17:02
#pragma checksum "..\..\..\Vistas\ActualizarPlanta.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0575208CC485DA6B62FE86720C24D44B7265A455F8DD393546EF3FC4E27B926D"
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
using Vivero_GUI.Vistas;


namespace Vivero_GUI.Vistas
{


    /// <summary>
    /// ActualizarPlanta
    /// </summary>
    public partial class ActualizarPlanta : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

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
            System.Uri resourceLocater = new System.Uri("/Vivero_GUI;component/vistas/actualizarplanta.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Vistas\ActualizarPlanta.xaml"
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
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox txtId;
        internal System.Windows.Controls.TextBox txtNombreComun;
        internal System.Windows.Controls.TextBox txtNombreCientifico;
        internal System.Windows.Controls.TextBox txtTipoPlanta;
        internal System.Windows.Controls.TextBox txtDescripcion;
        internal System.Windows.Controls.TextBox txtTiempoRiego;
        internal System.Windows.Controls.TextBox txtCantidadAgua;
        internal System.Windows.Controls.TextBox txtEpoca;
        internal System.Windows.Controls.CheckBox chkEsVenenosa;
        internal System.Windows.Controls.CheckBox chkEsAutoctona;
        internal System.Windows.Controls.Button btnActualizarPlanta;
    }
}
