using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_GestionTramites.Models
{
    public class ColaTramites
    {
        private NodoCola primero;
        private NodoCola ultimo;

        public ColaTramites()
        {
            primero = null;
            ultimo = null;
        }

        public void Encolar(Tramite tramite)
        {
            NodoCola nuevo = new NodoCola(tramite);
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
        }

        public Tramite Desencolar()
        {
            if (primero == null) return null;
            Tramite dato = primero.Dato;
            primero = primero.Siguiente;
            if (primero == null) ultimo = null;
            return dato;
        }

        public List<Tramite> ObtenerTodos()
        {
            List<Tramite> lista = new List<Tramite>();
            NodoCola actual = primero;
            while (actual != null)
            {
                lista.Add(actual.Dato);
                actual = actual.Siguiente;
            }
            return lista;
        }

        public bool EstaVacia() => primero == null;
    }

}
