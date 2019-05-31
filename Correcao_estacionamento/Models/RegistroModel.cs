using System;

namespace Correcao_estacionamento.Models
{
    public class RegistroModel
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public MarcaModel Marca {get;set;}
        public ModeloModel Modelo {get;set;}
        public string Placa {get;set;}
        public DateTime DataDeEntrada {get;set;}
    }
}