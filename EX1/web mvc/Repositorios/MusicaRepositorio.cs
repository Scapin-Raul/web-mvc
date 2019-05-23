using System.Collections.Generic;
using web_mvc.Models;

namespace web_mvc.Repositorios
{
    public class MusicaRepositorio
    {
        public static List<Musica> musicas = new List<Musica>() {
            new Musica("No Cume","Brega","Falcao"),
            new Musica("Juntos e Shallow Now","Meme","Paula Fernandes"),
            new Musica("Baba Baby","null","Kelly Key"),
            new Musica("Me libera","Forró","Banda Djavu"),

        };
    }

}