using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication4.Logica;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace WebApplication4.Pages {
    public class ImpersonarClienteModel : PageModel {


        ClienteDataAccessLayer objCliente = new ClienteDataAccessLayer();

        //Objetos del SP de datos actuales
        public List<Object> listaCuentas { set; get; }
        public Cuenta cuenta { set; get; }
        public List<Movimiento> listaMovimientos { set; get; }

        [BindProperty]
        public Cliente cliente { get; set; }

        //Objetos del SP de estados de cuenta recientes
        public List<EstadoCuenta> listaEstadosCuenta { get; set; }

        public void OnGet() {
            cuenta = new Cuenta();
            listaMovimientos = new List<Movimiento>();

            listaEstadosCuenta = new List<EstadoCuenta>();

        }

        //Se usa el input con name identificacion para hacer el SP y cambiar datos
        public IActionResult OnPost(int identificacion) {
            //Si el id del cliente que se asigna es inválido, refresca la página sin nada nuevo
            if (!ModelState.IsValid) {
                return Page();
            }

            //Corre el SP de datos del cliente
            listaCuentas = objCliente.GetInfoCliente(identificacion);
            //Asigna los objetos
            cuenta = (Cuenta)listaCuentas[0];
            listaMovimientos = (List<Movimiento>)listaCuentas[1];

            //Corre el SP de estados de cuenta y los asigna
            listaEstadosCuenta = objCliente.GetEstadosCuentaRecientes(identificacion).ToList();

            return Page(); //si retorna 0 significa que todo corrió bien
        }
    }
}