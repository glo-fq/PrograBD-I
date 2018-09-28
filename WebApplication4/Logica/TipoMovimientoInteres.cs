using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Logica {
    public class TipoMovimientoInteres {
        private string nombre;
        private string descripcion;

        public TipoMovimientoInteres() {
            Nombre = "";
            Descripcion = "";
        }

        public TipoMovimientoInteres(string pNombre, string pDescripcion) {
            Nombre = pNombre;
            Descripcion = pDescripcion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
