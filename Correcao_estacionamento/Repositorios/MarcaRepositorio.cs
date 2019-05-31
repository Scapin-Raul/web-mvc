using System.Collections.Generic;
using System.IO;
using Correcao_estacionamento.Models;

namespace Correcao_estacionamento.Repositorios
{
    public class MarcaRepositorio
    {
        private const string PATH = "DataBase/Marcas.csv";

        private List<MarcaModel> listaDeMarcas = new List<MarcaModel>();

        public List<MarcaModel> Listar(){
            string[] marcas = File.ReadAllLines(PATH);

            foreach (var item in marcas)
            {
                if (item != null){
                    string[] dados = item.Split(";");

                    MarcaModel marca = new MarcaModel();
                    marca.Id = int.Parse(dados[0]);
                    marca.Nome = dados[1];

                    listaDeMarcas.Add(marca); 
                }    
            }


            return listaDeMarcas;
        }
    }
}