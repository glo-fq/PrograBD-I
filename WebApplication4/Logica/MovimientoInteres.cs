using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Logica {
    public class MovimientoInteres {
        private int idCuenta;
        private TipoMovimientoInteres tipoMovimiento;
        private string fecha;
        private decimal saldo;
        private decimal interesDiario;

        public MovimientoInteres() {
            IdCuenta = 0;
            TipoMovimiento = new TipoMovimientoInteres();
            Fecha = "";
            Saldo = 0;
            InteresDiario = 0;
        }

        public MovimientoInteres(int pIdCuenta, TipoMovimientoInteres pTipoMovimiento, string pFecha, decimal pSaldo, decimal pInteresDiario) {
            idCuenta = pIdCuenta;
            TipoMovimiento = pTipoMovimiento;
            fecha = pFecha;
            saldo = pSaldo;
            interesDiario = pInteresDiario;
        }

        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public TipoMovimientoInteres TipoMovimiento { get => tipoMovimiento; set => tipoMovimiento = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
        public decimal InteresDiario { get => interesDiario; set => interesDiario = value; }
        
    }
}
