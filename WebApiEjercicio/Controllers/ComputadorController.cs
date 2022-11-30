using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using BL;
using BL.Interfaces;
using Entities;

namespace WebApiEjercicio.Controllers
{
    public class ComputadorController : ApiController
    {
        private readonly IComputadorBL _computadorBL;
        
        public ComputadorController(IComputadorBL computadorBL)
        {
            _computadorBL = computadorBL;
        }
        // GET api/values
        [HttpGet]
        [Route("api/computador/get")]
        public async Task<IHttpActionResult> ObtenerTodosLosComputadores()
        {
            List<Computador> listaComputadores = new List<Computador>();
            try
            {
                listaComputadores = _computadorBL.ListarComputadores();
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
            return this.Ok<List<Computador>>(listaComputadores);
        }
        [HttpGet]
        [Route("api/computador/getcomputador")]
        public async Task<IHttpActionResult> ObtenerComputadorPorId([FromBody] Computador computador)
        {
            try
            {
                computador = _computadorBL.BuscarComputador(computador.ComputadorId);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }

            return this.Ok<Computador>(computador);
        }

        [HttpPost]
        [Route("api/computador/post")]
        public async Task<IHttpActionResult> InsertarComputador([FromBody] Computador computador)
        {
            try
            {
                _computadorBL.InsertarComputador(computador);
            }
            catch(Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
            return this.Ok();
        }
        [HttpPost]
        [Route("api/computador/update")]
        public async Task<IHttpActionResult> ActualizarComputador([FromBody] Computador computador)
        {
            try
            {
                _computadorBL.ActualizarComputador(computador);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
            return this.Ok();
        }

        [HttpPost]
        [Route("api/computador/delete")]
        public async Task<IHttpActionResult> EliminarComputador([FromBody] Computador computador)
        {
            try
            {
                _computadorBL.EliminarComputador(computador.ComputadorId);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
            return this.Ok();
        }

    }
}
