using System;

namespace EX4_ESTACIONAMENTO.Models
{
    public class RegistroModel
    {
        public string Nome{get;set;}
        public ModeloModel Modelo{get;set;}
        public MarcaModel Marca {get;set;}
        public string Placa{get;set;}
        public DateTime DataDeEntrada {get;set;}
    }
}