using System;
using System.Collections.Generic;
using System.IO;
using EX3_HAMBURGUERIA.Models;

namespace EX3_HAMBURGUERIA.Repositorios
{
    public class PedidoRepositorio
    {
        private string Path = "DataBase/Pedido.csv";
        private List<Pedido> Pedidos = new List<Pedido>();
        public bool Inserir(Pedido pedido){
            try{

                if(!File.Exists(Path)){
                    File.Create(Path).Close();
                }

                var linha = $"{pedido.Id};{pedido.Cliente.Nome};{pedido.Cliente.Endereco};{pedido.Cliente.Telefone};{pedido.Cliente.Email};{pedido.Hamburguer.Nome};{pedido.Shake.Nome};{pedido.DataPedido}";

                File.AppendAllText(Path, linha + "\n");

            }catch(Exception e) {
                System.Console.WriteLine("Entrou no catch:");
                System.Console.WriteLine(e.StackTrace);
            }
            
            return true;
        }
    }
}