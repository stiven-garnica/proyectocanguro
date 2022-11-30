using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using Entities;

namespace WebApiEjercicio.Controllers
{
    public class PersonajeAnimeController : ApiController
    {
        // GET api/values
        [HttpGet]
        [Route("api/personajesanime")]
        public List<PersonajeAnime> Get()
        {
            PersonajeAnimeBL PersonajeAnimeBL = new PersonajeAnimeBL();
            return PersonajeAnimeBL.GenerarListaPersonajesAnime();
        }
    }
}
