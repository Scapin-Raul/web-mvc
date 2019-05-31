using System;
using System.Collections.Generic;
using System.IO;
using EX4_ESTACIONAMENTO.Models;

namespace EX4_ESTACIONAMENTO.Repositorio
{
    public class MarcaRepositorio
    {   
        public const string Path = "DataBase/Marcas.csv";
        private static List<MarcaModel> Marcas = new List<MarcaModel>();

        public static List<MarcaModel> Listar(){

            string[] linhas = File.ReadAllLines(Path);


            foreach (var item in linhas){

                MarcaModel marca = new MarcaModel();

                marca.Nome= item;
                
                Marcas.Add(marca);
                

            }
            return Marcas; 

        }

    }
}