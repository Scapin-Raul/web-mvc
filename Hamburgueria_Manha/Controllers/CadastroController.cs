using System;
using Hamburgueria_Manha.Models;
using Hamburgueria_Manha.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgueria_Manha.Controllers
{
    public class CadastroController: Controller
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Home";
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form){
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Senha = form["senha"];
            cliente.Email = form["email"];
            cliente.DataNascimento = DateTime.Parse(form["data-nascimento"]);

            clienteRepository.Inserir(cliente);
            ViewData["Action"] = "Cadastro";
            
            return View("Sucesso");
        }
    }
}