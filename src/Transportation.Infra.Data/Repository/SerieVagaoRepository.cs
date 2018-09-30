using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;
using Transportation.Domain.Repository;
using Transportation.Infra.Data.Context;

namespace Transportation.Infra.Data.Repository
{
    public class SerieVagaoRepository : Repository<SerieVagao>, ISerieVagaoRepository
    {
        public SerieVagaoRepository(TransportationContext context) : base(context)
        {

        }

        public SerieVagao ObterPorCodigo(string codigo)
        {
            return Buscar(f => f.Codigo == codigo).FirstOrDefault();
        }
    }
}
