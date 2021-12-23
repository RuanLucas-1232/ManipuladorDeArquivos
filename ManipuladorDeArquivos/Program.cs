using System;
using ManipuladorDeArquivos.Classes;

namespace ManipuladorDeArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Objetos Usuários
            PF usuarioPF = new PF();
            PJ usuarioPJ = new PJ();
            
            //Objetos Servidores
            PF servidorPF = new PF();
            PJ servidorPJ = new PJ();

            Console.WriteLine(@"
         _______________________________________   
        |    BEMVINDO À NOSSA PLATAFORMA        |
        |      QUAL SERVIÇO VOCÊ QUER           |
        |                                       |
        | CADASTRO DE PESSOA FÍSICA: DIGITE 1   |
        | CADASTRO DE PESSOA JURÍDICA: DIGITE 2 |
        -----------------------------------------
            ");

            string resposta = Console.ReadLine();

            switch (resposta)
            {
                case "1":
                    Console.WriteLine($"DIGITE SEU NOME");

                    usuarioPF.Nome = Console.ReadLine();

                    Console.WriteLine($"DIGITE SEU CPF");

                    usuarioPF.Cpf = int.Parse(Console.ReadLine());

                    Console.WriteLine($"DIGITE SEU PAÍS");

                    usuarioPF.Pais = Console.ReadLine();

                    Console.WriteLine($"DIGITE SEU ESTADO");

                    usuarioPF.Estado = Console.ReadLine();

                    Console.WriteLine($"DIGITE SEU MUNICÍPIO");

                    usuarioPF.Cidade = Console.ReadLine();

                    Console.WriteLine($"DIGITE SEU BAIRRO");

                    usuarioPF.Bairro = Console.ReadLine();

                    Console.WriteLine($"DIGITE SEU ENDEREÇO");

                    usuarioPF.Endereco = Console.ReadLine();
                    
                    string localizacaoPF = $"Pais: {usuarioPF.Pais}, Estado: {usuarioPF.Estado}, Cidade: {usuarioPF.Cidade}, Bairro: {usuarioPF.Bairro}, Endereço: {usuarioPF.Endereco}";
                    
                    servidorPF.RegistrarPF(usuarioPF.Nome, usuarioPF.Cpf, localizacaoPF);

                    break;

                case "2":

                    Console.WriteLine($"DIGITE SUA RAZÃO SOCIAL");
                    
                    usuarioPJ.RazaoSocial = Console.ReadLine();
                    
                    Console.WriteLine($"DIGITE SEU CNPJ");
                    
                    usuarioPJ.Cnpj = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine($"DIGITE SEU PAÍS");

                    usuarioPJ.Pais = Console.ReadLine();

                    Console.WriteLine($"DIGITE SEU ESTADO");

                    usuarioPJ.Estado = Console.ReadLine();

                    Console.WriteLine($"DIGITE SEU MUNICÍPIO");

                    usuarioPJ.Cidade = Console.ReadLine();

                    Console.WriteLine($"DIGITE SEU BAIRRO");

                    usuarioPJ.Bairro = Console.ReadLine();

                    Console.WriteLine($"DIGITE SEU ENDEREÇO");

                    usuarioPJ.Endereco = Console.ReadLine();
                    
                    string localizacaoPJ = $"Pais: {usuarioPJ.Pais}, Estado: {usuarioPJ.Estado}, Cidade: {usuarioPJ.Cidade}, Bairro: {usuarioPJ.Bairro}, Endereço: {usuarioPJ.Endereco}";
                    
                    servidorPJ.RegistrarPJ(usuarioPJ.RazaoSocial, usuarioPJ.Cnpj, localizacaoPJ);

                    break;
                default:
                    break;
            }
        }
    }
}
