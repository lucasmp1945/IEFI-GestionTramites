using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_GestionTramites.Models
{
    public class NodoLista
    {
        public Tramite Dato { get; set; }
        public NodoLista Siguiente { get; set; }

        public NodoLista(Tramite dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
