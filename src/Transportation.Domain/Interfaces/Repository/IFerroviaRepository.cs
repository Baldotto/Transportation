using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;

namespace Transportation.Domain.Repository
{
    public interface IFerroviaRepository : IRepository<Ferrovia>
    {
        Ferrovia ObterPorCodigo(string codigo);
    }
}
