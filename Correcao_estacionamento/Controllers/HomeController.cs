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
        RegistroRepositorio registroRepositorio = new RegistroRepositorio();
        HomeViewModel homeViewModel = new HomeViewModel();


        [HttpGet]
        public IActionResult Index(){
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

        public IActionResult ListarRegistros(){
            homeViewModel.Modelos = modeloRepositorio.Listar();
            homeViewModel.Registros = registroRepositorio.Listar();

            return View(homeViewModel);
        }

        public IActionResult FiltrarRegistros(IFormCollection form){
            homeViewModel.Registros = registroRepositorio.Listar();
            homeViewModel.Modelos = modeloRepositorio.Listar();

            var dataFormulario = form["data"];
            
                
            string modelo = form["modelo"];
            
            if (!string.IsNullOrEmpty(modelo) && !string.IsNullOrEmpty(dataFormulario)){
                DateTime data = DateTime.Parse(dataFormulario);
                homeViewModel.Registros = registroRepositorio.Filtrar(modelo,data);
            }else if (!string.IsNullOrEmpty(modelo) && string.IsNullOrEmpty(dataFormulario))
            {
                homeViewModel.Registros = registroRepositorio.Filtrar(modelo);                
            }else if (string.IsNullOrEmpty(modelo) && !string.IsNullOrEmpty(dataFormulario))
            {
                DateTime data = DateTime.Parse(dataFormulario);
                homeViewModel.Registros = registroRepositorio.Filtrar(data);                
            }else
            {
                return RedirectToAction("ListarRegistros","Home");
            }
            
            

            return View(homeViewModel);
        }
    }
}