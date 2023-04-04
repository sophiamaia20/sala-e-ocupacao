using GestaoSala.DAL;
using GestaoSala.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoSala.Controllers
{
    public class OCUPACAOcontroller : Controller
    {
        
        public IActionResult Index()
        {
            OCUPACAODAO tbOcupacao = new OCUPACAODAO();
            ViewBag.listaOcupacao = tbOcupacao.getTodasAsOcupacoes();
            return View();
        }
    }
}
