using PracticaPresencial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaPresencial2.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult Index(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                return View("Registro");
            }
            else
            {
                return View("Index", usuario);
                ////return View("Error", usuario);
            }

        }
        

        public ActionResult Registro()
        {
            return View();
        }
        //public ActionResult Error()
        //{
        //    return View();
        //}
    }
}