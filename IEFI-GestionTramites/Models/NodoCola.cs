using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_GestionTramites.Models
{
    public class NodoCola
    {
        public Tramite Dato { get; set; }
        public NodoCola Siguiente { get; set; }

        public NodoCola(Tramite dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

}
