using System;
using System.Collections.Generic;
using System.IO;
using Correcao_estacionamento.Models;

namespace Correcao_estacionamento.Repositorios
{
    public class RegistroRepositorio
    {
        private const string PATH = "DataBase/Registro.csv";
        private List<RegistroModel> listaDeRegistros = new List<RegistroModel>();

        public void Inserir(RegistroModel registro){

            if (!File.Exists(PATH))
            {
                registro.Id = 1;
            }else{
                registro.Id = File.ReadAllLines(PATH).Length + 1;
            }

            registro.DataDeEntrada = DateTime.Now;
            StreamWriter sw = new StreamWriter(PATH, true);
            sw.WriteLine($"{registro.Id};{registro.Nome};{registro.Marca.Nome};{registro.Modelo.Nome};{registro.Placa};{registro.DataDeEntrada}");
            sw.Close();
        }

        public List<RegistroModel> Listar()
        {
            List<RegistroModel> listaDeRegistros = new List<RegistroModel>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas){
                if (item != null){
                    string[] dados = item.Split(";");

                    var registro = new RegistroModel();
                    registro.Id = int.Parse(dados[0]);
                    registro.Nome = dados[1];
                    registro.Marca = new MarcaModel(dados[2]);
                    registro.Modelo = new ModeloModel(dados[3]);
                    registro.Placa = dados[4];
                    registro.DataDeEntrada = DateTime.Parse(dados[5]);

                    listaDeRegistros.Add(registro);
                }
            }

            return listaDeRegistros; 
        }

        public List<RegistroModel> Filtrar(DateTime data){
            var listaDeRegistros = Listar();
            var listaFiltrada = new List<RegistroModel>();
            System.Console.WriteLine($"Data convertida: {data}\nData dos registros:");
            foreach (var item in listaDeRegistros){
                System.Console.WriteLine(item.DataDeEntrada.ToShortDateString());
                if (item.DataDeEntrada.ToShortDateString() == data.ToShortDateString()){
                    listaFiltrada.Add(item);
                }
            }

            return listaFiltrada;
        }

        public List<RegistroModel> Filtrar(string modelo){
            var listaDeRegistros = Listar();
            var listaFiltrada = new List<RegistroModel>();
            System.Console.WriteLine($"Modelo procurado: {modelo}\nModelo dos registros:");
            foreach (var item in listaDeRegistros){
                System.Console.WriteLine(item.Modelo);
                if (item.Modelo.Nome.Equals(modelo)){
                    listaFiltrada.Add(item);
                }
            }

            return listaFiltrada;
        }

        public List<RegistroModel> Filtrar(string modelo, DateTime data){
            var listaDeRegistros = Listar();
            var listaFiltrada = new List<RegistroModel>();

            foreach (var item in listaDeRegistros){
                if (item.Modelo.Nome.Equals(modelo) && item.DataDeEntrada.ToShortDateString() == data.ToShortDateString()){
                    listaFiltrada.Add(item);
                }
            }

            return listaFiltrada;
        }

    }
}