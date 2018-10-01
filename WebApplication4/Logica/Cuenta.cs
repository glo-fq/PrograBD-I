using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Logica {
    public class Cuenta {
        private int idCuenta;
        private int idCliente;
        private decimal saldo;
        private decimal interesesAcumulados;
        //private int diaCorte;
        private DateTime fechaCreacion;
        private int idTipoCuenta;

        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int IdTipoCuenta { get => idTipoCuenta; set => idTipoCuenta = value; }
        //public int DiaCorte { get => diaCorte; set => diaCorte = value; }
        public decimal InteresesAcumulados { get => interesesAcumulados; set => interesesAcumulados = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }

        public Cuenta() {
            IdCuenta = 0;
            IdCliente = 0;
            Saldo = 0;
            InteresesAcumulados = 0;
            FechaCreacion = new DateTime(1970, 1, 1); //Se pone un valor por defecto
            idTipoCuenta = 0;
        }

        public Cuenta(int pIdCuenta, int pIdCliente, decimal pSaldo, decimal pIntAcum, DateTime pFechaCreacion, int pIdTipoCuenta) {
            IdCuenta = pIdCuenta;
            IdCliente = pIdCliente;
            Saldo = pSaldo;
            InteresesAcumulados = pIntAcum;
            FechaCreacion = pFechaCreacion;
            IdTipoCuenta = pIdTipoCuenta;
        }


        


    }
}
