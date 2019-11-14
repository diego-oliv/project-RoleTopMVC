using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoleTop.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try{
                return View("Sucesso");
            } catch(Exception e){
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
        }
    }
}