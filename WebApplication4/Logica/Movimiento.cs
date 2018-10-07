using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Logica {
    public class Movimiento {
        private int idCuenta;
        private int idTipoMovimiento;
        private int idEstadoCuenta;
        private DateTime fecha;
        private decimal monto;
        private string descripcion;

        public Movimiento() {
            idCuenta = 0;
            idTipoMovimiento = 0;
            idEstadoCuenta = 0;
            fecha = new DateTime(1970, 1, 1); //Se pone un valor por defecto
            monto = 0;
            descripcion = "";
        }

        public Movimiento(int pIdCuenta, int pIdTipoMovimiento, int pIdEstadoCuenta, DateTime pFecha, decimal pMonto, string pDescripcion) {
            idCuenta = pIdCuenta;
            idTipoMovimiento = pIdTipoMovimiento;
            idEstadoCuenta = pIdEstadoCuenta;
            fecha = pFecha;
            monto = pMonto;
            descripcion = pDescripcion;
        }

        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public int IdTipoMovimiento { get => idTipoMovimiento; set => idTipoMovimiento = value; }
        public int IdEstadoCuenta { get => idEstadoCuenta; set => idEstadoCuenta = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }


    }
}
