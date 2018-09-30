using Transportation.Domain.Entities;

namespace Transportation.Domain.Repository
{
    public interface ISerieVagaoRepository : IRepository<SerieVagao>
    {
        SerieVagao ObterPorCodigo(string codigo);
    }
}
