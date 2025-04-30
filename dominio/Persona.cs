using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Persona
    {
        public int Dni { get; set; }
        public string Tipo_Empleado { get; set; }
        public string Empresa { get; set; }
        public int Interno { get; set; }
        public string Apellido { get; set; }
        public string Nombres { get; set; }
        public int Viajes {  get; set; }
        public float Promedio { get; set; }
        public string Observaciones { get; set; }
        public bool Activo { get; set; }
        public bool OK_Adm {  get; set; }
        public bool OK_Trafico { get; set; }
        public DateTime Ingreso { get; set; }

    }
}
