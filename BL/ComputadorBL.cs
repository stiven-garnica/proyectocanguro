using BL.Interfaces;
using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ComputadorBL:IComputadorBL
    {
        ComputadorDAL computadorDAL = new ComputadorDAL();
        public void InsertarComputador(Computador computador)
        {
            computadorDAL.InsertarComputador(computador);
        }
        public List<Computador> ListarComputadores()
        {
            var listaComputadores = computadorDAL.ListarComputadores();
            return listaComputadores;
        }
        public Computador BuscarComputador(int computadorId)
        {
            var listaComputadores = computadorDAL.ListarComputadores();
            var computador = listaComputadores.SingleOrDefault(x => x.ComputadorId == computadorId);
            return computador;
        }
        public void ActualizarComputador(Computador computador)
        {
            computadorDAL.ActualizarComputador(computador);
        }
        public void EliminarComputador(int computadorId)
        {
            computadorDAL.EliminarComputador(computadorId);
        }
    }
}
