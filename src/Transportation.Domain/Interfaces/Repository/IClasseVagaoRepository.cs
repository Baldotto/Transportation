using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;

namespace Transportation.Domain.Repository
{
    public interface IClasseVagaoRepository : IRepository<ClasseVagao>
    {
        ClasseVagao ObterPorCodigo(string codigo);
    }
}
