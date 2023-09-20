using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivero_negocio
{

    //cree reporte de plantas disponibles o no disponibles ya que el proyecto trata 
    //sobre un vivero, el cual cuenta con disponibilad de plantas
    public class PlantaReporte
    {
        public int ReportePlantasDisponibles()
        {
            return Convert.ToInt32(CommonBC.ModeloVivero.spReportePlantasDisponibles().First().Value);
        }

        public int ReportePlantasNoDisponibles()
        {
            return Convert.ToInt32(CommonBC.ModeloVivero.spReportePlantasNoDisponibles().First().Value);
        }
    }
}
