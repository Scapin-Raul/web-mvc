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

    }
}