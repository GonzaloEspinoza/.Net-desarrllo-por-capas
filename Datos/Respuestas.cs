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
    
    public partial class Respuestas
    {
        public int respuestasID { get; set; }
        public Nullable<int> preguntasFID { get; set; }
        public string respuestas1 { get; set; }
    
        public virtual preguntasFrecuentes preguntasFrecuentes { get; set; }
    }
}
