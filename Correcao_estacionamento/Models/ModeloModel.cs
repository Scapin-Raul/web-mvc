using Microsoft.Extensions.Primitives;

namespace Correcao_estacionamento.Models
{
    public class ModeloModel
    {
        public ModeloModel(string nome)
        {
            this.Nome = nome;
        }

        public ModeloModel()
        {
        }

        public int Id {get;set;}
        public string Nome {get;set;}
    }
}