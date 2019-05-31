using System.Collections.Generic;
using System.IO;
using Correcao_estacionamento.Models;

namespace Correcao_estacionamento.Repositorios
{
    public class ModeloRepositorio
    {
        private const string PATH = "DataBase/Modelos.csv";
        private List<ModeloModel> listaDeMarcas = new List<ModeloModel>();

        public List<ModeloModel> Listar(){
            string[] modelos = File.ReadAllLines(PATH);

            foreach (var item in modelos)
            {
                if (item != null){
                    string[] dados = item.Split(";");

                    var modelo = new ModeloModel();
                    modelo.Id = int.Parse(dados[0]);
                    modelo.Nome = dados[1];

                    listaDeMarcas.Add(modelo); 
                }    
            }


            return listaDeMarcas;
        }
    
    
    }
}