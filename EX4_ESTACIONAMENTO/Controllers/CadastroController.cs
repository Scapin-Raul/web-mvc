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
    public class CadastroController: Controller
    {
        RegistroRepositorio registroRepositorio = new RegistroRepositorio();

        [HttpGet]
        public IActionResult Index(){
            return View();
        }
    
        [HttpPost]
        public IActionResult Registrar(IFormCollection form){
            System.Console.WriteLine(form["nome"]);
            System.Console.WriteLine(form["modelo"]);
            System.Console.WriteLine(form["marca"]);
            System.Console.WriteLine(form["placa"]);
            System.Console.WriteLine(form["dataDeEntrada"]);

            var registro = new RegistroModel();
            registro.Nome = form["nome"];
            registro.Modelo = form["modelo"];
            registro.Marca = form["marca"];
            registro.Placa = form["placa"];
            registro.DataDeEntrada = DateTime.Parse(form["dataDeEntrada"]);

            registroRepositorio.Inserir(registro);


            return RedirectToAction("Index","Cadastro");
        }

    
    }
}