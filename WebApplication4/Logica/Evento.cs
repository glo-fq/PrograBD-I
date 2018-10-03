using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Logica {
    public class Evento {
        private int id;
        private int idAdmin;
        private int idTipoEvento;
        private string direccionIP;
        private DateTime timeStamp;
        private string valorAntes;
        private string valorDespues;
        private int idEntidad;

        public Evento() {
            Id = 0;
            IdAdmin = 0;
            IdTipoEvento = 0;
            DireccionIP = "";
            TimeStamp = new DateTime(1970, 1, 1); //Se pone un valor por defecto
            ValorAntes = "";
            ValorDespues = "";
            IdEntidad = 0;
        }

        public Evento(int pId, int pIdAdmin, int pIdTipoEvento, string pDireccionIP, DateTime pTimeStamp, string pValorAntes, string pValorDespues, int pIdEntidad) {
            Id = pId;
            IdAdmin = pIdAdmin;
            IdTipoEvento = pIdTipoEvento;
            DireccionIP = pDireccionIP;
            TimeStamp = pTimeStamp;
            ValorAntes = pValorAntes;
            ValorDespues = pValorDespues;
            IdEntidad = pIdEntidad;
        }

        public int Id { get => id; set => id = value; }
        public int IdAdmin { get => idAdmin; set => idAdmin = value; }
        public int IdTipoEvento { get => idTipoEvento; set => idTipoEvento = value; }
        public string DireccionIP { get => direccionIP; set => direccionIP = value; }
        public DateTime TimeStamp { get => timeStamp; set => timeStamp = value; }
        public string ValorAntes { get => valorAntes; set => valorAntes = value; }
        public string ValorDespues { get => valorDespues; set => valorDespues = value; }
        public int IdEntidad { get => idEntidad; set => idEntidad = value; }
    }
}