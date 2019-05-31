using Microsoft.Extensions.Primitives;

namespace Correcao_estacionamento.Models
{
    public class MarcaModel
    {
        public MarcaModel(string nome)
        {
            this.Nome = nome;
        }

        public MarcaModel()
        {
        }

        public int Id {get;set;}
        public string Nome {get;set;}
    }
}