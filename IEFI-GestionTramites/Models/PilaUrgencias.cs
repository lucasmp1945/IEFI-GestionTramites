using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_GestionTramites.Models
{
    public class PilaUrgencias
    {
        private NodoPila cima;

        public PilaUrgencias()
        {
            cima = null;
        }

        public void Apilar(Tramite tramite)
        {
            NodoPila nuevo = new NodoPila(tramite);
            nuevo.Anterior = cima;
            cima = nuevo;
        }

        public Tramite Desapilar()
        {
            if (cima == null) return null;

            Tramite dato = cima.Dato;
            cima = cima.Anterior;
            return dato;
        }

        public List<Tramite> ObtenerTodos()
        {
            List<Tramite> lista = new List<Tramite>();
            NodoPila actual = cima;
            while (actual != null)
            {
                lista.Add(actual.Dato);
                actual = actual.Anterior;
            }
            return lista;
        }

        public bool EstaVacia() => cima == null;
    }

}
