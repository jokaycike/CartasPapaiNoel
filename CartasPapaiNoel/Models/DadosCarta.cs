using System.Globalization;

namespace CartasPapaiNoel.Models
{
    public class DadosCarta
    {
        public string Nome { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado {  get; set;}
        public int Idade {  get; set; }
        public string TextoCarta { get; set; }  
    }
}
