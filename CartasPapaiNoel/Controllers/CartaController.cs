using CartasPapaiNoel.Models;
using CartasPapaiNoel.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace CartasPapaiNoel.Controllers
{
    [ApiController]
    [Route("api/carta")]
    public class CartaController : Controller
    {
        private readonly ICartaRepository _cartaRepository;
        public CartaController(ICartaRepository cartaRepository)
        {
            _cartaRepository = cartaRepository;
        }

        [HttpPost]
        [Route("Inserir")]

        public IActionResult Inserir(NovaCarta dadosCarta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var novaCarta = new DadosCarta
            {
                Nome = dadosCarta.Nome,
                Rua = dadosCarta.Rua,
                Numero = dadosCarta.Numero,
                Bairro = dadosCarta.Bairro,
                Cidade = dadosCarta.Cidade,
                Estado = dadosCarta.Estado,
                Idade = dadosCarta.Idade,
                TextoCarta = dadosCarta.TextoCarta
            };

            _cartaRepository.Inserir(novaCarta);
            return Ok($"Carta da criança {dadosCarta.Nome} inserida com sucesso");
        }

        [HttpGet("obterTodas")]
        public IActionResult ObterTodas()
        {
            return Ok(_cartaRepository.ObterTodasCartas());
        }
    }
}
