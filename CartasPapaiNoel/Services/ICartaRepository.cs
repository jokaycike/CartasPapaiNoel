using CartasPapaiNoel.Models;

namespace CartasPapaiNoel.Services
{
    public interface ICartaRepository
    {
        public void Inserir(DadosCarta novaCarta);
    
        public List<DadosCarta> ObterTodasCartas();
    }
}
