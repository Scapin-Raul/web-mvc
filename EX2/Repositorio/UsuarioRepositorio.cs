using System;
using System.Collections.Generic;
using System.IO;
using EX2.Models;

namespace EX2.Repositorio
{
    public class UsuarioRepositorio
    {
        public UsuarioModel Cadastrar(UsuarioModel usuario){
            if (File.Exists("usuario.csv")){
                usuario.Id = File.ReadAllLines("usuario.csv").Length + 1;
            }else{
                usuario.Id = 1;
            }

            StreamWriter sw = new StreamWriter("usuario.csv",true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento}\n");
            sw.Close();

            return usuario;
        }

        public List<UsuarioModel> Listar(){
            List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
            string[] linhas = File.ReadAllLines("usuario.csv");
            UsuarioModel usuario;

            foreach (var item in linhas){
                if (item != null)
                {
                    string[] linha = item.Split(";");
                    usuario = new UsuarioModel(int.Parse(linha[0]),linha[1],linha[2],linha[3],DateTime.Parse(linha[4]));
                   
                    listaDeUsuarios.Add(usuario);
                }

            }

            return listaDeUsuarios;
        }

        public UsuarioModel Editar(UsuarioModel usuario){

            string[] linhas = File.ReadAllLines("usuario.csv");
                
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");

                if (usuario.Id.ToString() == linha[0]){
                    linhas[i] = $"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento}";
                    break;
                }
            }
            File.WriteAllLines("usuario.csv",linhas);
            return usuario;

        }

        public UsuarioModel BuscarPorId(int id){
            string[] linhas = File.ReadAllLines("usuario.csv");
            foreach (var item in linhas){
                string[] linha = item.Split(";");

                if (id.ToString().Equals(linhas[0])){
                    UsuarioModel usuario = new UsuarioModel(
                        int.Parse(linha[0]),
                        linha[1],
                        linha[2],
                        linha[3],
                        DateTime.Parse(linha[3])
                    );
                    return usuario;
                }

            }
            return null;           
        }
    }
}