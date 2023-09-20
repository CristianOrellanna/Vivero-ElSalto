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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vivero_GUI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Vivero_negocio.PlantaCollection plantaCollection;
        Vivero_negocio.PlantaReporte plantaReportes;
        public MainWindow()
        {
            InitializeComponent();
            plantaCollection = new Vivero_negocio.PlantaCollection();
            CargarGrilla();
        }

        private void optAgregarNuevaPlanta_Click(object sender, RoutedEventArgs e)
        {
            Vistas.AgregarPlanta agregarPlanta = new Vistas.AgregarPlanta();
            agregarPlanta.ShowDialog();
        }

        private void optListarPlantas_Click(object sender, RoutedEventArgs e)
        {
            Vistas.ListarPlantas listarPlantas = new Vistas.ListarPlantas();
            listarPlantas.ShowDialog();
        }

        private void optReporte_Click(object sender, RoutedEventArgs e)
        {
            plantaReportes = new Vivero_negocio.PlantaReporte();
            int plantasDisponibles = plantaReportes.ReportePlantasDisponibles();
            int plantasNoDisponibles = plantaReportes.ReportePlantasNoDisponibles();
            string message = string.Format(
                "Plantas disponibles: {0} \n " +
                "Plantas no disponibles: {1}",
                plantasDisponibles,
                plantasNoDisponibles
            );
            MessageBox.Show(message);
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgListadoPlantas.ItemsSource = plantaCollection.ReadAll();
        }
    }
}
