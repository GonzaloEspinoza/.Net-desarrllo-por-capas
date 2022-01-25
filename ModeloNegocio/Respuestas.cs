using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModeloNegocio
{
    public class Respuestas
    {
        public static List<Datos.Respuestas> Get()
        {
            using (Datos.dbPreguntasFrecuentesEntities db = new Datos.dbPreguntasFrecuentesEntities()) {

                IEnumerable<Datos.Respuestas> lista =(IEnumerable<Datos.Respuestas>) 
                    (from resuestas in db.Respuestas where resuestas.respuestasID > 1 select resuestas);
                return lista.ToList();
            
            }

        }

    }
}
