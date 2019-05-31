using System;
using System.Collections.Generic;
using System.IO;
using EX4_ESTACIONAMENTO.Models;

namespace EX4_ESTACIONAMENTO.Repositorio
{
    public class RegistroRepositorio
    {
        private string Path = "DataBase/registros.csv";
        private List<RegistroModel> Registros = new List<RegistroModel>();
        public void Inserir(RegistroModel pedido){
            try{

                if(!File.Exists(Path)){
                    File.Create(Path).Close();
                }

                var linha = $"{pedido.Nome};{pedido.Modelo.Nome};{pedido.Marca.Nome};{pedido.Placa};{pedido.DataDeEntrada}";

                File.AppendAllText(Path, linha + "\n");

            }catch(Exception e) {
                System.Console.WriteLine("Entrou no catch:");
                System.Console.WriteLine(e.StackTrace);
            }
        }

        public List<RegistroModel> Listar(){
            var listaDeRegistros = new List<RegistroModel>();

            string[] linhas = File.ReadAllLines(Path);
            RegistroModel registro;

            foreach (var item in linhas){
                if (item != null)
                {
                    string[] linha = item.Split(";");
                    registro = new RegistroModel();
                    registro.Nome=linha[0];
                    registro.Placa=linha[3];
                    registro.DataDeEntrada=DateTime.Parse(linha[4]);

                    MarcaModel marca = new MarcaModel();
                    marca.Nome = linha[1];
                    
                    ModeloModel modelo = new ModeloModel();
                    modelo.Nome = linha[2];
                    
                    registro.Marca = marca;
                    registro.Modelo = modelo;
                   
                    listaDeRegistros.Add(registro);
                }

            }
            return listaDeRegistros; 
        }

        
    }
}