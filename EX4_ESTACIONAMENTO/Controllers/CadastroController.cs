using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EX4_ESTACIONAMENTO.Models;
using EX4_ESTACIONAMENTO.Repositorio;
using EX4_ESTACIONAMENTO.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EX4_ESTACIONAMENTO.Controllers
{
    public class CadastroController: Controller
    {
        RegistroRepositorio registroRepositorio = new RegistroRepositorio();

        [HttpGet]
        public IActionResult Index(){
            var Modelos = ModeloRepositorio.Listar();
            var Marcas = MarcaRepositorio.Listar();

            CadastroViewModel cadastro = new CadastroViewModel();
            cadastro.Marcas = Marcas;
            cadastro.Modelos = Modelos;


            return View(cadastro);
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
            registro.Placa = form["placa"];
            registro.DataDeEntrada = DateTime.Parse(form["dataDeEntrada"]);

            MarcaModel marca = new MarcaModel();
            marca.Nome = form["marca"];
            
            ModeloModel modelo = new ModeloModel();
            modelo.Nome = form["modelo"];
            
            registro.Marca = marca;
            registro.Modelo = modelo;

            // registro.Modelo.Nome = form["modelo"];
            // registro.Marca.Nome = form["marca"];

            registroRepositorio.Inserir(registro);


            
            return RedirectToAction("Index","Cadastro");
        }

    
    }
}