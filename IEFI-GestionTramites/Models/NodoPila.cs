using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_GestionTramites.Models
{
    public class NodoPila
    {
        public Tramite Dato { get; set; }
        public NodoPila Anterior { get; set; }

        public NodoPila(Tramite dato)
        {
            Dato = dato;
            Anterior = null;
        }
    }

}
