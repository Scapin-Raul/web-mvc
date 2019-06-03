using System.Collections.Generic;
using Correcao_estacionamento.Models;

namespace Correcao_estacionamento.ViewModels
{
    public class HomeViewModel
    {
        public List<MarcaModel> Marcas {get;set;}
        public List<ModeloModel> Modelos {get;set;}
        public List<RegistroModel> Registros {get;set;}
    
    }
}