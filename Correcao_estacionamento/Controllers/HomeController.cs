using System;
using Correcao_estacionamento.Models;
using Correcao_estacionamento.Repositorios;
using Correcao_estacionamento.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Correcao_estacionamento.Controllers
{
    public class HomeController: Controller
    {
        MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
        ModeloRepositorio modeloRepositorio = new ModeloRepositorio();
        [HttpGet]
        public IActionResult Index(){
            var homeViewModel = new HomeViewModel();
            homeViewModel.Marcas = marcaRepositorio.Listar();
            homeViewModel.Modelos = modeloRepositorio.Listar();

            return View(homeViewModel);
        }

        [HttpPost]
        public IActionResult RegistrarEntrada(IFormCollection form){
            RegistroModel registro = new RegistroModel();
            registro.Nome = form["nome"];
            registro.Modelo = new ModeloModel(form["modelo"]);
            registro.Marca = new MarcaModel(form["marca"]);
            registro.Placa = form["placa"];

            RegistroRepositorio registroRepositorio = new RegistroRepositorio();
            registroRepositorio.Inserir(registro);

            return RedirectToAction("Index","Home");
        }
    }
}