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
    /// Lógica de interacción para ListarPlantas.xaml
    /// </summary>
    public partial class ListarPlantas : Window
    {

        Vivero_negocio.PlantaCollection plantaCollection;
        public ListarPlantas()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            var filaSeleccionada = (Vivero_negocio.Planta)dgListadoPlantas.SelectedItem;
            ActualizarPlanta actualizarPlanta = new ActualizarPlanta(filaSeleccionada.Id);
            actualizarPlanta.ShowDialog();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            EliminarRegistroSeleccionado();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            plantaCollection = new Vivero_negocio.PlantaCollection();
            dgListadoPlantas.ItemsSource = plantaCollection.ReadAll();
        }

        private void EliminarRegistroSeleccionado()
        {
            var filaSeleccionada = (Vivero_negocio.Planta)dgListadoPlantas.SelectedItem;
            long id = filaSeleccionada.Id;
            string title = "Eliminar planta";
            string message = string.Format("Estás seguro de eliminar la planta {0} ?", id);

            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxResult result = MessageBox.Show(message, title, buttons);

            if (result == MessageBoxResult.Yes)
            {
                var res = filaSeleccionada.Delete((int)id) ?
                    MessageBox.Show(string.Format("Planta {0} eliminada", id)) :
                    MessageBox.Show("La planta no pudo ser eliminada");
            }
        }
    }
}
