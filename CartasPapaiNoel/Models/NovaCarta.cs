using CartasPapaiNoel.Validations;
using System.ComponentModel.DataAnnotations;

namespace CartasPapaiNoel.Models
{
    public class NovaCarta
    {
        [Required(ErrorMessage = "Obrigatório")]
        [MinLength(3, ErrorMessage = "Minimo de 3 caracteres")]
        [MaxLength(255, ErrorMessage = "Maximo 255 caracteres")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Obrigatório")]
        public string Rua { get; set; }


        [Required(ErrorMessage = "Obrigatório")]
        public int Numero { get; set; }


        [Required(ErrorMessage = "Obrigatório")]
        public string Bairro { get; set; }


        [Required(ErrorMessage = "Obrigatório")]
        public string Cidade { get; set; }


        [Required(ErrorMessage = "Obrigatório")]
        public string Estado { get; set; }


        [Required(ErrorMessage = "Obrigatório")]
        [Idade(ErrorMessage = "Erro de idade, criança tem que ter menos de 15 anos")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [MaxLength(500, ErrorMessage = "Maximo 500 caracteres")]
        public string TextoCarta { get; set; }
    }
}
