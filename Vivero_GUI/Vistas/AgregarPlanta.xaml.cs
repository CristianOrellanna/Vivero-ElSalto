using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace Vivero_GUI.Vistas
{
    /// <summary>
    /// Lógica de interacción para AgregarPlanta.xaml
    /// </summary>
    public partial class AgregarPlanta : Window
    {
        private static Regex s_regex = new Regex("[^0-9]+");

        Vivero_negocio.Planta planta;
        public AgregarPlanta()
        {
            InitializeComponent();
            planta = new Vivero_negocio.Planta();
            this.DataContext = planta;
        }
        private void btnAgregarPlanta_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                /*Vivero_negocio.Planta planta = new Vivero_negocio.Planta();
                planta.Id = (int)Convert.ToInt64(txtId.Text);
                planta.NombreComun = txtNombreComun.Text;
                planta.NombreCientifico = txtNombreCientifico.Text;
                planta.TipoPlanta = txtTipoPlanta.Text;
                planta.Descripcion = txtDescripcion.Text;
                planta.TiempoRiego = (int)Convert.ToInt64(txtTiempoRiego.Text);
                planta.CantidadAgua = (int)Convert.ToInt64(txtCantidadAgua.Text);
                planta.Epoca = txtEpoca.Text;
                planta.EsVenenosa = (chkEsVenenosa.IsChecked.Value) ? true : false;
                planta.EsAutoctona = (chkEsAutoctona.IsChecked.Value) ? true : false;*/
                


                bool response = planta.Create();

                if (response)
                {
                    MessageBox.Show("La planta fue agregada correctamente");
                    AgregarOtraPlanta();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error. Intentelo más tarde");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }


        private void AgregarOtraPlanta()
        {
            string title = "Agregar una nnueva planta";
            string message = "¿Desea agregar una nueva planta?";
            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxResult result = MessageBox.Show(message, title, buttons);

            if (result == MessageBoxResult.No)
            {
                this.Close();
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = string.Empty;
            txtNombreComun.Text = string.Empty;
            txtNombreCientifico.Text = string.Empty;
            txtTipoPlanta.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtTiempoRiego.Text = string.Empty;
            txtCantidadAgua.Text = string.Empty;
            txtEpoca.Text = string.Empty;
            chkEsVenenosa.IsChecked = false;
            chkEsAutoctona.IsChecked = false;
        }
    }
}
