using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_GestionTramites.Models
{
    public class Tramite
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string TipoTramite { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; } // solo se usa en urgencias

        public Tramite(string dni, string nombre, string tipo, DateTime fecha, string motivo = "")
        {
            DNI = dni;
            Nombre = nombre;
            TipoTramite = tipo;
            Fecha = fecha;
            Motivo = motivo;
        }

        public override string ToString()
        {
            return $"{Fecha:HH:mm} - {Nombre} ({DNI}) - {TipoTramite} - {Motivo}";
        }
    }

}
