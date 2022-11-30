using Dapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ComputadorDAL
    {
        protected SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Database=ComputadoresDB;Integrated Security=True");

        public List<Computador> ListarComputadores()
        {
            string sql = "SELECT  * FROM Computadores";
            var computadores = connection.Query<Computador>(sql).ToList();
            return computadores;
        }
        public void InsertarComputador(Computador computador)
        {
            var sql = "INSERT INTO Computadores " +
                "VALUES MarcaComputador = @MarcaComputador, ModeloComputador = @ModeloComputador, FechaLanzamientoComputador = @FechaLanzamientoComputador, " +
                "Color = @Color, CapacidadDefectoRAMGB = @CapacidadDefectoRAMGB, CapacidadMaximaRAMGB = @CapacidadMaximaRAMGB, " +
                "ProcesadorComputador = @ProcesadorComputador, TipoDiscoDuro = @TipoDiscoDuro, CapacidadDiscoDuroComputador = @CapacidadDiscoDuroComputador, " +
                "TipoComputador = @TipoComputador";
            var parameters = new
            {
                MarcaComputador = computador.MarcaComputador,
                ModeloComputador = computador.ModeloComputador,
                FechaLanzamientoComputador = computador.FechaLanzamientoComputador,
                Color = computador.Color,
                CapacidadDefectoRAMGB = computador.CapacidadDefectoRAMGB,
                CapacidadMaximaRAMGB = computador.CapacidadMaximaRAMGB,
                ProcesadorComputador = computador.ProcesadorComputador,
                TipoDiscoDuro = (int)computador.TipoDiscoDuroComputador,
                CapacidadDiscoDuroComputador = computador.CapacidadDiscoDuroComputador,
                TipoComputador = (int)computador.TipoComputador
            };
            using (connection)
            {
                connection.Execute(sql, parameters);
            }
        }
        public void ActualizarComputador(Computador computador)
        {
            var sql = "UPDATE Computadores " +
                "SET MarcaComputador = @MarcaComputador, ModeloComputador = @ModeloComputador, FechaLanzamientoComputador = @FechaLanzamientoComputador, " +
                "Color = @Color, CapacidadDefectoRAMGB = @CapacidadDefectoRAMGB, CapacidadMaximaRAMGB = @CapacidadMaximaRAMGB, " +
                "ProcesadorComputador = @ProcesadorComputador, TipoDiscoDuro = @TipoDiscoDuro, CapacidadDiscoDuroComputador = @CapacidadDiscoDuroComputador, " +
                "TipoComputador = @TipoComputador" + 
                "WHERE computadorId = @computadorId";
            var parameters = new
            {
                computadorId = computador.ComputadorId,
                MarcaComputador = computador.MarcaComputador,
                ModeloComputador = computador.ModeloComputador,
                FechaLanzamientoComputador = computador.FechaLanzamientoComputador,
                Color = computador.Color,
                CapacidadDefectoRAMGB = computador.CapacidadDefectoRAMGB,
                CapacidadMaximaRAMGB = computador.CapacidadMaximaRAMGB,
                ProcesadorComputador = computador.ProcesadorComputador,
                TipoDiscoDuro = (int)computador.TipoDiscoDuroComputador,
                CapacidadDiscoDuroComputador = computador.CapacidadDiscoDuroComputador,
                TipoComputador = (int)computador.TipoComputador
            };
            using (connection)
            {
                connection.Execute(sql, parameters);
            }
        }
        public void EliminarComputador(int computadorId)
        {
            var sql = "DELETE FROM Computadores WHERE computadorId = @computadorId";
            var parameters = new
            {
                computadorId = computadorId
            };
            using (connection)
            {
                connection.Execute(sql, parameters);
            }
        }

    }
}
