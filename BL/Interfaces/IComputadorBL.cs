using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IComputadorBL
    {
        void InsertarComputador(Computador computador);
        List<Computador> ListarComputadores();
        Computador BuscarComputador(int computadorId);
        void ActualizarComputador(Computador computador);
        void EliminarComputador(int computadorId);
    }
}
