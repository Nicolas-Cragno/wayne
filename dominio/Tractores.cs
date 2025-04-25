using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Tractores
    {
        public int Interno { get; set; }
        public int Empresa { get; set; }
        public int Satelital_Ubicacion { get; set; }
        public int Satelital_Combustible {  get; set; }
        public int Chofer {  get; set; }
        public string Dominio { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public bool Activo { get; set; }
        public string Observaciones {  get; set; }
        public bool OK_Taller { get; set; }
        public bool OK_Adm {  get; set; }
        public bool OK_Satelital { get; set; }
        public bool OK_Trafico {  get; set; }

    }
}
