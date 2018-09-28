using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Logica {
    public class Cuenta {
        private decimal saldo;
        private decimal interesesAcumulados;
        private int diaCorte;
        private string fechaCreacion;
        private string tipoCuenta;

        public string FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public string TipoCuenta { get => tipoCuenta; set => tipoCuenta = value; }
        public int DiaCorte { get => diaCorte; set => diaCorte = value; }
        public decimal InteresesAcumulados { get => interesesAcumulados; set => interesesAcumulados = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }

        Cuenta() {
            Saldo = 0;
            InteresesAcumulados = 0;
            DiaCorte = 0;
            FechaCreacion = "";
            TipoCuenta = "";
        }

        Cuenta(decimal pSaldo, decimal pIntAcum, int pDiaCorte, string pFechaCreacion) {
            Saldo = pSaldo;
            InteresesAcumulados = pIntAcum;
            DiaCorte = pDiaCorte;
            FechaCreacion = pFechaCreacion;
        }


        


    }
}
