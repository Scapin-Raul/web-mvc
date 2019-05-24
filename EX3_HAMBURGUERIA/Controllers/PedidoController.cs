using System;
using EX3_HAMBURGUERIA.Models;
using EX3_HAMBURGUERIA.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EX3_HAMBURGUERIA.Controllers
{
    public class PedidoController : Controller
    {
        PedidoRepositorio pedidoRepositorio = new PedidoRepositorio();

        [HttpGet]
        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarPedido(IFormCollection form){
            System.Console.WriteLine(form["nome"]);
            System.Console.WriteLine(form["endereco"]);
            System.Console.WriteLine(form["telefone"]);
            System.Console.WriteLine(form["email"]);
            System.Console.WriteLine(form["hamburguer"]);
            System.Console.WriteLine(form["shake"]);

            Pedido pedido = new Pedido();
            
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            Hamburguer hamburguer = new Hamburguer(
                nome: form["hamburguer"]
            );

            Shake shake = new Shake(
                nome: form["shake"]
            );

            pedido.Cliente = cliente;
            pedido.Hamburguer = hamburguer;
            pedido.Shake = shake;
            pedido.DataPedido = DateTime.Now;

            pedidoRepositorio.Inserir(pedido);

            ViewData["Controller"] = "Pedido";

            return View("Sucesso");
        }

    }
}