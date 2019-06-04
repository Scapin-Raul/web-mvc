using System;
using Hamburgueria_Manha.Models;
using Hamburgueria_Manha.Repositorios;
using Hamburgueria_Manha.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgueria_Manha.Controllers
{
    public class PedidoController : Controller
    {
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";
        PedidoRepositorio pedidoRepositorio = new PedidoRepositorio();
        HamburguerRepositorio hamburguerRepositorio = new HamburguerRepositorio();
        ShakeRepositorio shakeRepositorio = new ShakeRepositorio();
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["User"] = HttpContext.Session.GetString(SESSION_CLIENTE);
            PedidoViewModel pedido = new PedidoViewModel();
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString(SESSION_CLIENTE))){
                var cliente = clienteRepositorio.ObterPor(HttpContext.Session.GetString(SESSION_EMAIL));
                pedido.Cliente = cliente;
            }else
            {
                pedido.Cliente = new Cliente();
            }

            var hamburgueres = hamburguerRepositorio.Listar();
            var shakes = shakeRepositorio.Listar();

            pedido.Hamburgueres = hamburgueres;
            pedido.Shakes = shakes;
            
            return View(pedido);
        }

        [HttpPost]
        public IActionResult RegistrarPedido(IFormCollection form)
        {
            System.Console.WriteLine(form["nome"]);
            System.Console.WriteLine(form["endereco"]);
            System.Console.WriteLine(form["telefone"]);
            System.Console.WriteLine(form["email"]);
            System.Console.WriteLine(form["hamburguer"]);
            System.Console.WriteLine(form["shake"]);

            Pedido pedido = new Pedido();

            // Instanciação de objeto - Forma 1 
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            pedido.Cliente = cliente;

            // Instanciação de objeto - Forma 2 (pede geração de construtor) 
            Hamburguer hamburguer = new Hamburguer(
                Nome: form["hamburguer"]
                
            );

            pedido.Hamburguer = hamburguer;

            // Instanciação de objeto - Forma 3 (resumo da Forma 1)
            Shake shake = new Shake() {
                Nome = form["shake"]
            };

            pedido.Shake = shake;

            pedido.DataPedido = DateTime.Now;

            pedidoRepositorio.Inserir(pedido);

            ViewData["Controller"] = "Pedido";
            
            return View("Sucesso");
        }
    }
}