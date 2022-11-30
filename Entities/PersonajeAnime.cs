using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PersonajeAnime
    {
        public Guid PersonajeId;
        public string NombrePersonaje { get; set; }
        public string NombreAnime { get; set; }
        public int AtaquePersonaje { get; set; }
        public int DefensaPersonaje { get; set; }

        public PersonajeAnime()
        {
            PersonajeId = Guid.NewGuid();
        }
    }
}
