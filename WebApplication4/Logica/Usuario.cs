using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Logica {
    public class Usuario {
        private int id;
        private string nombre;
        private string clave;

        public Usuario() {
            Id = 0;
            Nombre = "";
            Clave = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }
    }
}
