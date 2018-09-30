using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class Locomotiva
    {

        public Locomotiva()
        {
            LocomotivaId = new Guid();
        }

        public Guid LocomotivaId { get; set; }

        public string Codigo { get; set; }

        public Guid FerroviaProprietariaId { get; set; }
        public virtual Ferrovia FerroviaProprietaria { get; set; }

        public Guid SerieLocomotivaId { get; set; }
        public  SerieLocomotiva SerieLocomotiva { get; set; }

    }
}
