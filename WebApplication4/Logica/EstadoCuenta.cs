using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Logica {
    public class EstadoCuenta {
        private int idCuenta;
        private DateTime fechaCorte;
        private decimal saldoInicial;
        private decimal saldoFinal;
        private int cantOpMaxManual;
        private int cantOpMaxATM;
        private decimal saldoMinimo;

        public EstadoCuenta(int pIdCuenta, DateTime pFechaCorte, decimal pSaldoInicial, decimal pSaldoFinal, int pCantMaxOpManual, int pCantMaxOpATM, decimal pSaldoMinimo) {
            idCuenta = pIdCuenta;
            fechaCorte = pFechaCorte;
            saldoInicial = pSaldoInicial;
            saldoFinal = pSaldoFinal;
            cantOpMaxManual = pCantMaxOpManual;
            cantOpMaxATM = pCantMaxOpATM;
            saldoMinimo = pSaldoMinimo;
        }

        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public decimal SaldoInicial { get => saldoInicial; set => saldoInicial = value; }
        public decimal SaldoFinal { get => saldoFinal; set => saldoFinal = value; }
        public int CantOpMaxManual { get => cantOpMaxManual; set => cantOpMaxManual = value; }
        public int CantOpMaxATM { get => cantOpMaxATM; set => cantOpMaxATM = value; }
        public decimal SaldoMinimo { get => saldoMinimo; set => saldoMinimo = value; }
        public DateTime FechaCorte { get => fechaCorte; set => fechaCorte = value; }
    }
}
