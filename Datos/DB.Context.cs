//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbPreguntasFrecuentesEntities : DbContext
    {
        public dbPreguntasFrecuentesEntities()
            : base("name=dbPreguntasFrecuentesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<categoriaPreguntasFrecuentes> categoriaPreguntasFrecuentes { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<preguntasFrecuentes> preguntasFrecuentes { get; set; }
        public virtual DbSet<Respuestas> Respuestas { get; set; }
    }
}
