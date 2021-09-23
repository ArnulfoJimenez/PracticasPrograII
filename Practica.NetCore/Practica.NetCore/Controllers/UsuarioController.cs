using Microsoft.AspNetCore.Mvc;
using Practica.NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica.NetCore.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Welcome()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Welcome(Usuarios usuario)
        {
            if (ModelState.IsValid)
            {
                return View("Registro");
            }
            else
            {
                return View("Welcome", usuario);
            }

        }
        public IActionResult Registro() 
        {
            return View();
        }
    }
}
