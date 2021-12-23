using System;
using System.IO;

namespace ManipuladorDeArquivos.Classes
{
    public class PF : Pessoa
    {
        public string Nome { get; set; }

        public int Cpf { get; set; }

        public void RegistrarPF(string Nome, int Cpf, string localizacao)
        {
            string caminho = @$"C:\Users\Usuário\Desktop\PROJETOS C#\ProjetosEmExcecao\ManipuladorDeArquivos\UsuariosPF\{Nome}.csv";

            if (!File.Exists(caminho))
            {
                StreamWriter registrador = File.CreateText(caminho);

                registrador.WriteLine($"Nome: {Nome}");
                registrador.WriteLine($"Cpf: {Cpf}");
                registrador.WriteLine(localizacao);

                registrador.Close();
            }
            Console.WriteLine("Dados Salvos com Sucesso!");
        }
    }
}