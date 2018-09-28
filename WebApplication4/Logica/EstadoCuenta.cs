using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Logica {
    public class EstadoCuenta {
        private int idCuenta;
        private string fechaCorte;
        private decimal saldoInicial;
        private decimal saldoFinal;
        private int cantOpMaxManual;
        private int cantOpMaxATM;
        private decimal saldoMinimo;

        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string FechaCorte { get => fechaCorte; set => fechaCorte = value; }
        public decimal SaldoInicial { get => saldoInicial; set => saldoInicial = value; }
        public decimal SaldoFinal { get => saldoFinal; set => saldoFinal = value; }
        public int CantOpMaxManual { get => cantOpMaxManual; set => cantOpMaxManual = value; }
        public int CantOpMaxATM { get => cantOpMaxATM; set => cantOpMaxATM = value; }
        public decimal SaldoMinimo { get => saldoMinimo; set => saldoMinimo = value; }
    }
}
