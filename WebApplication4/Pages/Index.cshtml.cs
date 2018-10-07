using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication4.Logica;
using WebApplication4.Controllers;
using Microsoft.AspNetCore.Server;

namespace WebApplication4.Pages {
    public class IndexModel : PageModel {

        AdministradorDataAccessLayer objAdmin = new AdministradorDataAccessLayer();
        AccountController controlador = new AccountController();

        [BindProperty]
        public Usuario usuario { set; get; }

        public void OnGet() {
            usuario = new Usuario();
            controlador.Logout();

        }

        public IActionResult OnPostAdmin(string username, string pass) {
            if (!ModelState.IsValid) {
                return Page();
            }
            return new EmptyResult();
        }

        public IActionResult OnPostCliente(string username, string pass) {
            if (!ModelState.IsValid) {
                return Page();
            }

            bool resultLogin = objAdmin.VerificarCredencialesAdmin(username, pass);

            return new EmptyResult();
        }

        //public void GetIp(out string ip) {
        //    ip = Request.ServerVariables["REMOTE_ADDR"];
        //}
    }
}
