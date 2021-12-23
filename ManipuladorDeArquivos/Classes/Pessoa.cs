namespace ManipuladorDeArquivos.Classes
{
    public abstract class Pessoa
    {
        public string Pais { get; set; }
        public string Estado { get; set; }
        
        public string Cidade { get; set; }
        
        public string Bairro { get; set; }
        
        public string Endereco { get; set; }
    }
}