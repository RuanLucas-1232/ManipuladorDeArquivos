using System;
using System.IO;

namespace ManipuladorDeArquivos.Classes
{
    public class PJ : Pessoa
    {
        public string RazaoSocial { get; set; }

        public int Cnpj { get; set; }

        public void RegistrarPJ(string RazaoSocial, int Cnpj, string localizacao)
        {
            string caminho = @$"C:\Users\Usuário\Desktop\PROJETOS C#\ProjetosEmExcecao\ManipuladorDeArquivos\UsuariosPJ\{RazaoSocial}.csv";

            if (!File.Exists(caminho))
            {
                StreamWriter registrador = File.CreateText(caminho);

                registrador.WriteLine($"Razão Social: {RazaoSocial}");
                registrador.WriteLine($"Cnpj: {Cnpj}");
                registrador.WriteLine(localizacao);
                
                registrador.Close();
            }
            Console.WriteLine("Dados Salvos com Sucesso!");
        }
    }
}