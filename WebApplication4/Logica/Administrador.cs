using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Logica {
    public class Administrador : Usuario {
        //private int id;
        //private string nombre;
        ////private string clave;
        //private bool isSesionIniciada;

        public Administrador() {
            Id = 0;
            Nombre = "";
            Clave = "";
            //IsSesionIniciada = false;
        }

        public Administrador(int pId, string pNombre, string pClave) { //Se quita el parámetro de isSesionIniciada
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            //IsSesionIniciada = pIsSesionIniciada;
        }

        //public bool IsSesionIniciada { get => isSesionIniciada; set => isSesionIniciada = value; }
    }
}