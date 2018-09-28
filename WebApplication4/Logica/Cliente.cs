using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Logica {
    public class Cliente {
        private int id;
        private string nombre;
        private string clave;

        public Cliente() {
            Nombre = "";
            Clave = "";
            Id = 0;
        }

        public Cliente(int pId, string pNombre, string pClave) {
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }
        public int Id { get => id; set => id = value; }
    }
}
