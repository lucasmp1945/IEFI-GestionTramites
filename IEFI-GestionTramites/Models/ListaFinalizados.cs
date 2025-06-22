using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_GestionTramites.Models
{
    public class ListaFinalizados
    {
        private NodoLista primero;

        public void AgregarOrdenado(Tramite tramite)
        {
            NodoLista nuevo = new NodoLista(tramite);

            if (primero == null || tramite.Fecha < primero.Dato.Fecha)
            {
                nuevo.Siguiente = primero;
                primero = nuevo;
                return;
            }

            NodoLista actual = primero;
            while (actual.Siguiente != null && actual.Siguiente.Dato.Fecha <= tramite.Fecha)
            {
                actual = actual.Siguiente;
            }

            nuevo.Siguiente = actual.Siguiente;
            actual.Siguiente = nuevo;
        }

        public List<Tramite> ObtenerTodos()
        {
            List<Tramite> lista = new List<Tramite>();
            NodoLista actual = primero;
            while (actual != null)
            {
                lista.Add(actual.Dato);
                actual = actual.Siguiente;
            }
            return lista;
        }

        public List<Tramite> Filtrar(string tipo, DateTime desde, DateTime hasta)
        {
            return ObtenerTodos().Where(t =>
                (tipo == "Todos" || t.TipoTramite == tipo) &&
                t.Fecha >= desde &&
                t.Fecha <= hasta
            ).ToList();
        }
    }

}
