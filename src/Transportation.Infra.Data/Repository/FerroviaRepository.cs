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
    public class FerroviaRepository : Repository<Ferrovia>, IFerroviaRepository
    {


        public FerroviaRepository(TransportationContext context)
            : base(context)
        {

        }

        public Ferrovia ObterPorCodigo(string codigo)
        {
            return Buscar(f => f.Codigo == codigo).FirstOrDefault();
        }

    }
}
