using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Movimiento
    {
        public int Id_Movimiento { get; set; }
        public int Id_Tipo { get; set; }
        public int Persona { get; set; }
        public int Interno { get; set; }
        public int Furgon { get; set; }
        public int Cliente { get; set; }
        public DateTime fecha { get; set; }
        public string Destino { get; set; }
    }
}
