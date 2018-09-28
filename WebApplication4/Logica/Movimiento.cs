using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Logica {
    public class Movimiento {
        private int idCuenta;
        private string tipoMovimiento;
        private int idEstadoCuenta;
        private string fecha;
        private decimal monto;
        private string descripcion;

        public Movimiento() {
            idCuenta = 0;
            tipoMovimiento = "";
            idEstadoCuenta = 0;
            fecha = "";
            monto = 0;
            descripcion = "";
        }

        public Movimiento(int pIdCuenta, string pTipoMovimiento, int pIdEstadoCuenta, string pFecha, decimal pMonto, string pDescripcion) {
            idCuenta = pIdCuenta;
            tipoMovimiento = pTipoMovimiento;
            idEstadoCuenta = pIdEstadoCuenta;
            fecha = pFecha;
            monto = pMonto;
            descripcion = pDescripcion;
        }

        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string TipoMovimiento { get => tipoMovimiento; set => tipoMovimiento = value; }
        public int IdEstadoCuenta { get => idEstadoCuenta; set => idEstadoCuenta = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }


    }
}
