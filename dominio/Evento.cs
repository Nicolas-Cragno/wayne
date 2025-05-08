using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Evento
    {
        public int Id_Evento { get; set; }
        public int Dni {  get; set; }
        public string Persona { get; set; }
        public int Interno { get; set; }
        public string Tipo { get; set; }
        public string Detalle { get; set; }
        public DateTime Fecha { get; set; }
    }
}
