using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivero_negocio
{
    public class Planta : IPersistente
    {
        public int Id { get; set; }
        public string NombreComun { get; set; }
        public string NombreCientifico { get; set; }
        public string TipoPlanta { get; set; }
        public string Descripcion { get; set; }
        public int TiempoRiego { get; set; }
        public int CantidadAgua { get; set; }
        public string Epoca { get;set; }
        public bool EsVenenosa { get; set; }
        public bool EsAutoctona { get; set; }

        public bool Create()
        {
            try
            {
                CommonBC.ModeloVivero.spReportePlantaSave(
                    this.Id,
                    this.NombreComun,
                    this.NombreCientifico,
                    this.TipoPlanta,
                    this.Descripcion,
                    this.TiempoRiego,
                    this.CantidadAgua,
                    this.Epoca,
                    this.EsVenenosa,
                    this.EsAutoctona
                    );

                CommonBC.ModeloVivero.SaveChanges();

                return true;
            }
            catch(Exception ex )
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                CommonBC.ModeloVivero.spPlantaDeleteById(id);
                CommonBC.ModeloVivero.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool Read(int id)
        {
            try
            {
                Vivero_DALC.vwPlanta planta = CommonBC.ModeloVivero.vwPlanta.First(p => p.Id == id);

                this.Id = planta.Id;
                this.NombreComun = planta.NombreComun;
                this.NombreCientifico = planta.NombreCientifico;
                this.TipoPlanta = planta.TipoPlanta;
                this.Descripcion = planta.Descripcion;
                this.TiempoRiego = planta.TiempoRiego;
                this.CantidadAgua = planta.CantidadAgua;
                this.Epoca = planta.Epoca;
                this.EsVenenosa = (bool)planta.EsVenenosa;
                this.EsAutoctona = (bool)planta.EsAutoctona;

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                CommonBC.ModeloVivero.spPlantaUpdateById(
                    this.NombreComun,
                    this.NombreCientifico,
                    this.TipoPlanta,
                    this.Descripcion,
                    this.TiempoRiego,
                    this.CantidadAgua,
                    this.Epoca,
                    this.EsVenenosa,
                    this.EsAutoctona
                    );

                CommonBC.ModeloVivero.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
