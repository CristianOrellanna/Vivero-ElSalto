using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vivero_negocio
{
    public class Planta : ObservableObject, IPersistente, IDataErrorInfo
    {
        public Dictionary<string, string> ErrorCollection { get; set; } = new Dictionary<string, string>();

        public int Id { get; set; }

        private string _nombreComun;
        private string _nombreCientifico;
        private string _tipoPlanta;
        private string _descripcion;
        private int _tiempoRiego;
        private int _cantidadAgua;
        public string _epoca;
        public bool _esVenenosa;
        public bool _esAutoctona;

        public string NombreComun
        {
            get { return _nombreComun; }
            set
            {
                OnPropertyChanged(ref _nombreComun, value);
            }
        }

        public string NombreCientifico
        {
            get { return _nombreCientifico; }
            set
            {
                OnPropertyChanged(ref _nombreCientifico, value);
            }
        }
        public string TipoPlanta
        {
            get { return _tipoPlanta; }
            set
            {
                OnPropertyChanged(ref _tipoPlanta, value);
            }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set
            {
                OnPropertyChanged(ref _descripcion, value);
            }
        }
        public int TiempoRiego
        {
            get { return _tiempoRiego; }
            set
            {
                OnPropertyChanged(ref _tiempoRiego, value);
            }
        }
        public int CantidadAgua
        {
            get { return _cantidadAgua; }
            set
            {
                OnPropertyChanged(ref _cantidadAgua, value);
            }
        }
        public string Epoca
        {
            get { return _epoca; }
            set
            {
                OnPropertyChanged(ref _epoca, value);
            }
        }
        public bool EsVenenosa
        {
            get { return _esVenenosa; }
            set
            {
                OnPropertyChanged(ref _esVenenosa, value);
            }
        }
        public bool EsAutoctona
        {
            get { return _esAutoctona; }
            set
            {
                OnPropertyChanged(ref _esAutoctona, value);
            }
        }

        public string Error { get { return null; } }
        public string this[string name]
        {
            get
            {
                string res = null;
                switch (name)
                {
                    case "NombreComun":
                        if (string.IsNullOrEmpty(NombreComun))
                            res = "El nombre comun no puede estar vacio";
                        else if (NombreComun.Length < 3 || NombreComun.Length > 100)
                            res = "El nombre comun necesita minimo 3 caracteres y maximo 100";
                        break;
                    case "NombreCientifico":
                        if (string.IsNullOrEmpty(NombreCientifico))
                            res = "El nombre cientifico no puede estar vacio";
                        else if (NombreCientifico.Length < 10 || NombreCientifico.Length > 150)
                            res = "El nombre cientifico necesita minimo 10 caracteres y maximo 150";
                        break;
                    case "TipoPlanta":
                        if (string.IsNullOrEmpty(TipoPlanta))
                            res = "El tipo de planta no puede estar vacio";
                        else if (TipoPlanta != "Herbacea" && TipoPlanta != "Matorral" && TipoPlanta != "Arbusto" && TipoPlanta != "Arbol")
                            res = "Tipo planta solo puede tener los valores Herbacea, Matorral, Arbusto, Arbol";
                        break;
                    case "TiempoRiego":
                        if (string.IsNullOrEmpty(TiempoRiego.ToString()))
                            res = "Tiempo riego no puede estar vacio ni aceptar valores que no sean de tipo entero";
                        break;
                    case "Descripcion":
                        if (string.IsNullOrEmpty(Descripcion))
                            res = "Sin informacion";
                        break;
                    case "CantidadAgua":
                        if (string.IsNullOrEmpty(CantidadAgua.ToString()))
                            res = "Cantidad agua no puede estar vacio ni aceptar valores que no sean de tipo entero";
                        break;
                    case "Epoca":
                        if (string.IsNullOrEmpty(Epoca))
                            res = "Epoca no puede estar vacio";
                        else if (Epoca != "Verano" && Epoca != "Invierno" && Epoca != "Otoño" && Epoca != "Primavera")
                            res = "Tipo planta solo puede tener los valores Verano, Invierno, Otoño, Primavera";
                        break;
                }

                if (ErrorCollection.ContainsKey(name))
                {
                    ErrorCollection[name] = res;
                }
                else if (res != null)
                {
                    ErrorCollection.Add(name, res);
                }

                OnPropertyChanged("ErrorCollection");

                return res;
            }
        }

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
            catch(Exception)
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
            catch(Exception)
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
