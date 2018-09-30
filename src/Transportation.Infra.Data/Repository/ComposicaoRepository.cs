using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;
using Transportation.Domain.Interfaces.Repository;
using Transportation.Domain.Repository;
using Transportation.Infra.Data.Context;

namespace Transportation.Infra.Data.Repository
{
    public class ComposicaoRepository : Repository<Composicao>, IComposicaoRepository
    {
        public ComposicaoRepository(TransportationContext context) : base(context)
        {
        }

        public Composicao ObterPorTremId(Guid tremId)
        {
            return Buscar(f => f.TremId == tremId).FirstOrDefault();
        }
    }
}
