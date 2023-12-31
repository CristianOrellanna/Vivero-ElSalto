﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vivero_DALC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class El_SaltoEntities : DbContext
    {
        public El_SaltoEntities()
            : base("name=El_SaltoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<vwPlanta> vwPlanta { get; set; }
    
        public virtual int spPlantaDeleteById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spPlantaDeleteById", idParameter);
        }
    
        public virtual int spPlantaUpdateById(string nombreComun, string nombreCientifico, string tipoPlanta, string descripcion, Nullable<int> tiempoRiego, Nullable<int> cantidadAgua, string epoca, Nullable<bool> esVenenosa, Nullable<bool> esAutoctona)
        {
            var nombreComunParameter = nombreComun != null ?
                new ObjectParameter("nombreComun", nombreComun) :
                new ObjectParameter("nombreComun", typeof(string));
    
            var nombreCientificoParameter = nombreCientifico != null ?
                new ObjectParameter("nombreCientifico", nombreCientifico) :
                new ObjectParameter("nombreCientifico", typeof(string));
    
            var tipoPlantaParameter = tipoPlanta != null ?
                new ObjectParameter("tipoPlanta", tipoPlanta) :
                new ObjectParameter("tipoPlanta", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var tiempoRiegoParameter = tiempoRiego.HasValue ?
                new ObjectParameter("tiempoRiego", tiempoRiego) :
                new ObjectParameter("tiempoRiego", typeof(int));
    
            var cantidadAguaParameter = cantidadAgua.HasValue ?
                new ObjectParameter("cantidadAgua", cantidadAgua) :
                new ObjectParameter("cantidadAgua", typeof(int));
    
            var epocaParameter = epoca != null ?
                new ObjectParameter("epoca", epoca) :
                new ObjectParameter("epoca", typeof(string));
    
            var esVenenosaParameter = esVenenosa.HasValue ?
                new ObjectParameter("esVenenosa", esVenenosa) :
                new ObjectParameter("esVenenosa", typeof(bool));
    
            var esAutoctonaParameter = esAutoctona.HasValue ?
                new ObjectParameter("esAutoctona", esAutoctona) :
                new ObjectParameter("esAutoctona", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spPlantaUpdateById", nombreComunParameter, nombreCientificoParameter, tipoPlantaParameter, descripcionParameter, tiempoRiegoParameter, cantidadAguaParameter, epocaParameter, esVenenosaParameter, esAutoctonaParameter);
        }
    
        public virtual int spReportePlantaSave(Nullable<int> id, string nombreComun, string nombreCientifico, string tipoPlanta, string descripcion, Nullable<int> tiempoRiego, Nullable<int> cantidadAgua, string epoca, Nullable<bool> esVenenosa, Nullable<bool> esAutoctona)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nombreComunParameter = nombreComun != null ?
                new ObjectParameter("nombreComun", nombreComun) :
                new ObjectParameter("nombreComun", typeof(string));
    
            var nombreCientificoParameter = nombreCientifico != null ?
                new ObjectParameter("nombreCientifico", nombreCientifico) :
                new ObjectParameter("nombreCientifico", typeof(string));
    
            var tipoPlantaParameter = tipoPlanta != null ?
                new ObjectParameter("tipoPlanta", tipoPlanta) :
                new ObjectParameter("tipoPlanta", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var tiempoRiegoParameter = tiempoRiego.HasValue ?
                new ObjectParameter("tiempoRiego", tiempoRiego) :
                new ObjectParameter("tiempoRiego", typeof(int));
    
            var cantidadAguaParameter = cantidadAgua.HasValue ?
                new ObjectParameter("cantidadAgua", cantidadAgua) :
                new ObjectParameter("cantidadAgua", typeof(int));
    
            var epocaParameter = epoca != null ?
                new ObjectParameter("epoca", epoca) :
                new ObjectParameter("epoca", typeof(string));
    
            var esVenenosaParameter = esVenenosa.HasValue ?
                new ObjectParameter("esVenenosa", esVenenosa) :
                new ObjectParameter("esVenenosa", typeof(bool));
    
            var esAutoctonaParameter = esAutoctona.HasValue ?
                new ObjectParameter("esAutoctona", esAutoctona) :
                new ObjectParameter("esAutoctona", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spReportePlantaSave", idParameter, nombreComunParameter, nombreCientificoParameter, tipoPlantaParameter, descripcionParameter, tiempoRiegoParameter, cantidadAguaParameter, epocaParameter, esVenenosaParameter, esAutoctonaParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> spReportePlantasDisponibles()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spReportePlantasDisponibles");
        }
    
        public virtual ObjectResult<Nullable<int>> spReportePlantasNoDisponibles()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spReportePlantasNoDisponibles");
        }
    }
}
