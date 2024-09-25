
using CartasPapaiNoel.Models;

namespace CartasPapaiNoel.Services
{
    public class CartaRepository : ICartaRepository
    {
        private static List<DadosCarta> dadosCartaList = new List<DadosCarta>();
        
        public void Inserir(DadosCarta novaCarta)
        {
            dadosCartaList.Add(novaCarta);
        }
        public List<DadosCarta> ObterTodasCartas()
        {
            return dadosCartaList;
        }
    }
}
