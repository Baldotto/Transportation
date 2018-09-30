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
    public class TremRepository : Repository<Trem>, ITremRepository
    {


        public TremRepository(TransportationContext context) : base(context)
        {
        }

        public Trem ObterPorOS(string OS)
        {
            return Buscar(f => f.OS == OS).FirstOrDefault();
        }
    }
}
