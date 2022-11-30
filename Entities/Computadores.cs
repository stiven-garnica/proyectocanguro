using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Computador
    {
        public int ComputadorId { get; set; }
        public string MarcaComputador { get; set; }
        public string ModeloComputador { get; set; }
        public int FechaLanzamientoComputador { get; set; }
        public string Color { get; set; }
        public int CapacidadDefectoRAMGB { get; set; }
        public int CapacidadMaximaRAMGB { get; set; }
        public string ProcesadorComputador { get; set; }
        public TipoDiscoDuro TipoDiscoDuroComputador { get; set; }
        public int CapacidadDiscoDuroComputador { get; set; }
        public TipoComputador TipoComputador { get; set; }
    }
}
