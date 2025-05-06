using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Tractor
    {
        public int Interno { get; set; }
        public string Empresa { get; set; } //convertir a int para buscar cod en db
        public string Satelital_Ubicacion { get; set; }  //convertir a int para buscar cod en db
        public string Satelital_Combustible {  get; set; }  //convertir a int para buscar cod en db
        public string Chofer {  get; set; }
        public int Dni_Chofer { get; set; }
        public string Dominio { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Observaciones {  get; set; }
        public bool Activo { get; set; }
        public bool OK_Taller { get; set; }
        public bool OK_Adm {  get; set; }
        public bool OK_Satelital { get; set; }
        public bool OK_Trafico {  get; set; }

    }
}
