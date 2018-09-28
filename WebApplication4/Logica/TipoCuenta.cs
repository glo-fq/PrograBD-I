using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Logica {
    public class TipoCuenta {
        private int id;
        private string nombre;
        private decimal tasaInteresAnual;
        private decimal saldoMinimo;
        private decimal multaSaldoMinimo;
        private decimal multaSaldoNegativo;
        private decimal cargoPorServicioMensual;
        private int cantMaxOpManual;
        private int cantMaxOpATM;
        private decimal multaOpManual;
        private decimal multaOpATM;

        //Constructor vacío
        public TipoCuenta() {
            Id = 0;
            Nombre = "";
            TasaInteresAnual = 0;
            SaldoMinimo = 0;
            MultaSaldoMinimo = 0;
            MultaSaldoNegativo = 0;
            CargoPorServicioMensual = 0;
            CantMaxOpManual = 0;
            CantMaxOpATM = 0;
            MultaOpManual = 0;
            MultaOpATM = 0;
        }

        public TipoCuenta(int pId, string pNombre, decimal pTasaInteresAnual, decimal pSaldoMinimo, decimal pMultaSaldoMinimo, decimal pMultaSaldoNegativo, decimal pCargoPorServicioMensual, int pCantMaxOpManual, int pCantMaxOpATM, decimal pMultaOpManual, decimal pMultaOpATM) {
            Id = pId;
            Nombre = pNombre;
            TasaInteresAnual = pTasaInteresAnual;
            SaldoMinimo = pSaldoMinimo;
            MultaSaldoMinimo = pMultaSaldoMinimo;
            MultaSaldoNegativo = pMultaSaldoNegativo;
            CargoPorServicioMensual = pCargoPorServicioMensual;
            CantMaxOpManual = pCantMaxOpManual;
            CantMaxOpATM = pCantMaxOpATM;
            MultaOpManual = pMultaOpManual;
            MultaOpATM = pMultaOpATM;
        }

        [Required]
        public int Id { get => id; set => id = value; }
        [Required]
        public string Nombre { get => nombre; set => nombre = value; }
        [Required]
        public decimal TasaInteresAnual { get => tasaInteresAnual; set => tasaInteresAnual = value; }
        [Required]
        public decimal SaldoMinimo { get => saldoMinimo; set => saldoMinimo = value; }
        [Required]
        public decimal MultaSaldoMinimo { get => multaSaldoMinimo; set => multaSaldoMinimo = value; }
        [Required]
        public decimal MultaSaldoNegativo { get => multaSaldoNegativo; set => multaSaldoNegativo = value; }
        [Required]
        public decimal CargoPorServicioMensual { get => cargoPorServicioMensual; set => cargoPorServicioMensual = value; }
        [Required]
        public int CantMaxOpManual { get => cantMaxOpManual; set => cantMaxOpManual = value; }
        [Required]
        public int CantMaxOpATM { get => cantMaxOpATM; set => cantMaxOpATM = value; }
        [Required]
        public decimal MultaOpManual { get => multaOpManual; set => multaOpManual = value; }
        [Required]
        public decimal MultaOpATM { get => multaOpATM; set => multaOpATM = value; }
        

    }
}
