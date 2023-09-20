using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Vivero_GUI.Vistas
{
    /// <summary>
    /// Lógica de interacción para ActualizarPlanta.xaml
    /// </summary>
    public partial class ActualizarPlanta : Window
    {
        Vivero_negocio.Planta planta;
        public ActualizarPlanta(int id)
        {
            InitializeComponent();
            this.Title = string.Format("Actualizar Planta {0}", id);

            planta = new Vivero_negocio.Planta();

            CargarFormulario(id);
        }

        //se pede actulizar cualquier dato menos el Id de la planta
        private void btnActualizarPlanta_Click(object sender, RoutedEventArgs e)
        {
            planta.NombreComun = txtNombreComun.Text;
            planta.NombreCientifico = txtNombreCientifico.Text;
            planta.TipoPlanta = txtTipoPlanta.Text;
            planta.Descripcion = txtDescripcion.Text;
            planta.TiempoRiego = (int)Convert.ToInt64(txtTiempoRiego.Text);
            planta.CantidadAgua = (int)Convert.ToInt64(txtCantidadAgua.Text);
            planta.Epoca = txtEpoca.Text;
            planta.EsVenenosa = (chkEsVenenosa.IsChecked.Value) ? true : false;
            planta.EsAutoctona = (chkEsAutoctona.IsChecked.Value) ? true : false;

            bool response = planta.Update();


            if (response)
            {
                MessageBox.Show(string.Format("Planta {0} ha sido actualizada exitósamente!", planta.Id));
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Format("No fue posible actualizar la planta {0}", planta.Id));
                this.Close();
            }
        }

        private void CargarFormulario(int id)
        {
            bool response = planta.Read(id);
            if (response)
            {
                txtId.Text = planta.Id.ToString();
                txtNombreComun.Text = planta.NombreComun;
                txtNombreCientifico.Text = planta.NombreCientifico;
                txtTipoPlanta.Text = planta.TipoPlanta;
                txtDescripcion.Text = planta.Descripcion;
                txtTiempoRiego.Text = planta.TiempoRiego.ToString();
                txtCantidadAgua.Text = planta.CantidadAgua.ToString();
                txtEpoca.Text = planta.Descripcion;
                chkEsVenenosa.IsChecked = (planta.EsVenenosa) ? true : false;
                chkEsAutoctona.IsChecked = (planta.EsAutoctona) ? true : false;
            }
            else
            {
                MessageBox.Show(string.Format("La planta {0} no fue no fue encontrada.", id));
            }
        }
    }
}
