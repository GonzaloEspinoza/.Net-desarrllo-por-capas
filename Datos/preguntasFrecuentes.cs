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
    using System.Collections.Generic;
    
    public partial class preguntasFrecuentes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public preguntasFrecuentes()
        {
            this.Respuestas = new HashSet<Respuestas>();
        }
    
        public int preguntasFID { get; set; }
        public string presguntaFrecuente { get; set; }
        public Nullable<int> categoriaPreguntaFreID { get; set; }
    
        public virtual categoriaPreguntasFrecuentes categoriaPreguntasFrecuentes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Respuestas> Respuestas { get; set; }
    }
}
