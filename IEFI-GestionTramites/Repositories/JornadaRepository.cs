using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEFI_GestionTramites.Models;

namespace IEFI_GestionTramites.Repositories
{
    public static class JornadaRepository
    {
        private static string carpeta = AppDomain.CurrentDomain.BaseDirectory;


        public static void GuardarCola(ColaTramites cola)
        {
            using (StreamWriter writer = new StreamWriter(Path.Combine(carpeta, "cola_tramites.txt")))
            {
                foreach (var tramite in cola.ObtenerTodos())
                {
                    writer.WriteLine($"{tramite.DNI}|{tramite.Nombre}|{tramite.TipoTramite}|{tramite.Fecha:O}");
                }
            }
        }

        public static void GuardarPila(PilaUrgencias pila)
        {
            using (StreamWriter writer = new StreamWriter(Path.Combine(carpeta, "pila_urgencias.txt")))
            {
                foreach (var tramite in pila.ObtenerTodos())
                {
                    writer.WriteLine($"{tramite.DNI}|{tramite.Nombre}|{tramite.TipoTramite}|{tramite.Fecha:O}|{tramite.Motivo}");
                }
            }
        }

        public static void GuardarHistorial(ListaFinalizados lista)
        {
            using (StreamWriter writer = new StreamWriter(Path.Combine(carpeta, "historial_finalizados.txt")))
            {
                foreach (var tramite in lista.ObtenerTodos())
                {
                    writer.WriteLine($"{tramite.DNI}|{tramite.Nombre}|{tramite.TipoTramite}|{tramite.Fecha:O}|{tramite.Motivo}");
                }
            }
        }


        public static ColaTramites CargarCola()
        {
            ColaTramites cola = new ColaTramites();
            string path = Path.Combine(carpeta, "cola_tramites.txt");

            if (File.Exists(path))
            {
                foreach (var linea in File.ReadAllLines(path))
                {
                    var partes = linea.Split('|');
                    cola.Encolar(new Tramite(partes[0], partes[1], partes[2], DateTime.Parse(partes[3])));
                }
            }

            return cola;
        }

        public static PilaUrgencias CargarPila()
        {
            PilaUrgencias pila = new PilaUrgencias();
            string path = Path.Combine(carpeta, "pila_urgencias.txt");

            if (File.Exists(path))
            {
                foreach (var linea in File.ReadAllLines(path))
                {
                    var partes = linea.Split('|');
                    pila.Apilar(new Tramite(partes[0], partes[1], partes[2], DateTime.Parse(partes[3]), partes[4]));
                }
            }

            return pila;
        }

        public static ListaFinalizados CargarHistorial()
        {
            ListaFinalizados lista = new ListaFinalizados();
            string path = Path.Combine(carpeta, "historial_finalizados.txt");

            if (File.Exists(path))
            {
                foreach (var linea in File.ReadAllLines(path))
                {
                    var partes = linea.Split('|');
                    lista.AgregarOrdenado(new Tramite(partes[0], partes[1], partes[2], DateTime.Parse(partes[3]), partes.Length > 4 ? partes[4] : ""));
                }
            }

            return lista;
        }
    }
}
