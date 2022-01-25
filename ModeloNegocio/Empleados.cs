using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocio
{
    public class Empleados
    {
        public static List<Datos.Empleados> Get() 
        {
            using (Datos.dbPreguntasFrecuentesEntities db = new Datos.dbPreguntasFrecuentesEntities()) { 
                return db.Empleados.ToList();
            }
        }
    }
}
