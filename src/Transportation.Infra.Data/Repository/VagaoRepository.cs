using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;
using Transportation.Domain.Repository;
using Transportation.Infra.Data.Context;

namespace Transportation.Infra.Data.Repository
{
    public  class VagaoRepository : Repository<Vagao>, IVagaoRepository
    {
        public VagaoRepository(TransportationContext context) : base(context)
        {
        } 

        public Vagao ObterPorCodigo(string codigo)
        {
            return Buscar(f => f.Codigo == codigo).FirstOrDefault();
        }

       
    }
}
