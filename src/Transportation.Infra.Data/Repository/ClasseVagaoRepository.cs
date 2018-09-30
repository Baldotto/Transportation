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
    public class ClasseVagaoRepository : Repository<ClasseVagao>, IClasseVagaoRepository
    {
        public ClasseVagaoRepository(TransportationContext context) : base(context)
        {
        }

        public ClasseVagao ObterPorCodigo(string codigo)
        {
            return Buscar(f => f.Codigo == codigo).FirstOrDefault();
        }
    }
}
