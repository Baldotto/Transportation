using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;
using Transportation.Domain.Interfaces.Repository;
using Transportation.Infra.Data.Context;

namespace Transportation.Infra.Data.Repository
{
    public class ComposicaoVagaoRepository : Repository<ComposicaoVagao>, IComposicaoVagaoRepository
    {
        public ComposicaoVagaoRepository(TransportationContext context) : base(context)
        {
        }

        public ComposicaoVagao ObterPorComposicaoId(Guid ComposicaoId)
        {
            return Buscar(f => f.ComposicaoId == ComposicaoId).FirstOrDefault();
        }

    }
}
