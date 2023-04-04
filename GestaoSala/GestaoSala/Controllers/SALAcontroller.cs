using GestaoSala.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoSala.Controllers
{
    public class SALAcontroller : Controller
    {
        SALADAO tbSala = new SALADAO(); 
        public IActionResult Index()
        {
            ViewBag.listasalas = tbSala.getTodasAsSalas(); 
            return View();
        }
    }
}
