using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Logica {
    public class Administrador {
        private int id;
        private string nombre;
        private string clave;
        private bool isSesionIniciada;

        public Administrador() {
            Id = 0;
            Nombre = "";
            Clave = "";
            IsSesionIniciada = false;
        }

        public Administrador(int pId, string pNombre, string pClave, bool pIsSesionIniciada) {
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            IsSesionIniciada = pIsSesionIniciada;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }
        public bool IsSesionIniciada { get => isSesionIniciada; set => isSesionIniciada = value; }
    }
}