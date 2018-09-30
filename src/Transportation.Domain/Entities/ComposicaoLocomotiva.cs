using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class ComposicaoLocomotiva
    {

        public ComposicaoLocomotiva()
        {
            ComposicaoLocomotivaId = new Guid(); 
        }

        public Guid ComposicaoLocomotivaId { get; set; }

        public virtual Composicao Composicao { get; set; }
        public Guid ComposicaoId { get; set; }

        public virtual Locomotiva Locomotiva { get; set; }
        public Guid LocomotivaId { get; set; }


    }
}
