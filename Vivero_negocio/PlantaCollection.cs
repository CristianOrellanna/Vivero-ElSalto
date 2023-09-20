using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivero_negocio
{
    public class PlantaCollection
    {
        public List<Planta> ReadAll()
        {
            var plantas = CommonBC.ModeloVivero.vwPlanta;
            return ObtenerPlantas(plantas.ToList());
        }

        private List<Planta> ObtenerPlantas(List<Vivero_DALC.vwPlanta> plantasDALC)
        {
            List<Planta> plantaList = new List<Planta>();
            foreach(Vivero_DALC.vwPlanta planta in plantasDALC)
            {
                Planta p = new Planta();
                p.Id = planta.Id;
                p.NombreComun = planta.NombreComun;
                p.NombreCientifico = planta.NombreCientifico;
                p.TipoPlanta = planta.TipoPlanta;
                p.Descripcion = planta.Descripcion;
                p.TiempoRiego = planta.TiempoRiego;
                p.CantidadAgua = planta.CantidadAgua;
                p.Epoca = planta.Epoca;
                p.EsVenenosa = (bool)planta.EsVenenosa;
                p.EsAutoctona = (bool)planta.EsAutoctona;

                plantaList.Add(p);
            }
            return plantaList;
        }
    }
}
