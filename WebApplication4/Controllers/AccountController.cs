using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers {
    public class AccountController : Controller {

        public string DireccionIP = "127.0.0.1";
        public bool IsSesionIniciada { get; set; }
        public int IdUsuarioSesion { get; set; }


        public void Logout() {
            IsSesionIniciada = false;
            IdUsuarioSesion = 0;
        }

        public void Login(int pId) {
            IsSesionIniciada = true;
            IdUsuarioSesion = pId;
        }


        //[HttpPost]
        //public async Task<IActionResult> Logout() {
        //    //await _signManager.SignOutAsync();
        //    return RedirectToPage("~/Pages/Index.cshtml");
        //}

        // GET: Account
        public ActionResult Index(){
            return View();
        }

        // GET: Account/Details/5
        public ActionResult Details(int id){
            return View();
        }

        // GET: Account/Create
        public ActionResult Create(){
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection){
            try {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: Account/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: Account/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: Account/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: Account/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }
    }
}