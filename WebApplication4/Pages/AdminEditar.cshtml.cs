using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication4.Logica;

namespace WebApplication4.Pages {
    public class AdminEditarModel : PageModel {

        //Clientes
        ClienteDataAccessLayer objCliente = new ClienteDataAccessLayer();
        public List<Cliente> cliente { get; set; }

        //Tipos de cuenta
        TipoCuentaDataAccessLayer objTipoCuenta = new TipoCuentaDataAccessLayer();
        public List<TipoCuenta> tipoCuenta { get; set; }

        //Cuentas
        CuentaDataAccessLayer objCuenta = new CuentaDataAccessLayer();
        public List<Cuenta> cuenta { get; set; }

        //Modelo tipo de cuenta agreegado para enviar a agregar
        [BindProperty]
        public TipoCuenta tipoCuentaAgregado { get; set; }

        public void OnGet() {

            cliente = objCliente.GetAllClientes().ToList();

            tipoCuenta = objTipoCuenta.GetAllTiposCuenta().ToList();

            cuenta = objCuenta.GetAllCuentas().ToList();

        }

        public ActionResult OnPostAddTipoCuenta() {
            if (!ModelState.IsValid) {
                return Page();
            }
            objTipoCuenta.AddTipoCuenta(tipoCuentaAgregado);
            //Revisar este return
            return new EmptyResult();
        }
    }
}