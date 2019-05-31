using System.Collections.Generic;
using System.IO;
using EX4_ESTACIONAMENTO.Models;

namespace EX4_ESTACIONAMENTO.Repositorio
{
    public class ModeloRepositorio
    {
        public const string Path = "DataBase/Modelos.csv";
        private static List<ModeloModel> Modelos = new List<ModeloModel>();

        public static List<ModeloModel> Listar(){

            string[] linhas = File.ReadAllLines(Path);

            foreach (var item in linhas){

                ModeloModel modelo = new ModeloModel();

                modelo.Nome= item;
                
                Modelos.Add(modelo);
                

            }
            return Modelos; 

        }
    }
}