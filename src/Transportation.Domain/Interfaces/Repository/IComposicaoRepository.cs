using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;
using Transportation.Domain.Repository;

namespace Transportation.Domain.Interfaces.Repository
{
    public interface IComposicaoRepository : IRepository<Composicao>
    {
        Composicao ObterPorTremId(Guid tremId);


    }
}
