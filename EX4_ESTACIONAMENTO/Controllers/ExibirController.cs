using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EX4_ESTACIONAMENTO.Models;
using EX4_ESTACIONAMENTO.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EX4_ESTACIONAMENTO.Controllers
{
    public class ExibirController: Controller
    {

        [HttpGet]
        public IActionResult Index(){
            RegistroRepositorio registroRepositorio = new RegistroRepositorio();
            ViewData["registros"] = registroRepositorio.Listar();
            return View();
        }
        
    }
}