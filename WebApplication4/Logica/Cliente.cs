using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Logica {
    public class Cliente:Usuario {
        private int id;
        private string nombre;
        private string clave;
        private bool isSesionIniciada;

        public Cliente() {
            Nombre = "";
            Clave = "";
            Id = 0;
            IsSesionIniciada = false;
        }

        public Cliente(int pId, string pNombre, string pClave, bool pIsSesionIniciada) {
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            isSesionIniciada = pIsSesionIniciada;
        }

        public Cliente(string pNombre, string pClave) {
            nombre = pNombre;
            clave = pClave;
            id = 0;
            isSesionIniciada = false;
        }

        public void IniciarSesion() {
            isSesionIniciada = true;
        }

        public void CerrarSesion() {
            isSesionIniciada = false;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }
        public int Id { get => id; set => id = value; }
        public bool IsSesionIniciada { get => isSesionIniciada; set => isSesionIniciada = value; }
    }
}
