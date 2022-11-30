using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BL
{
    public class PersonajeAnimeBL
    {
        public List<PersonajeAnime> GenerarListaPersonajesAnime()
        {
            List<PersonajeAnime> ListaPersonajes = new List<PersonajeAnime>();
            PersonajeAnimeDAL dal = new PersonajeAnimeDAL();
            ListaPersonajes = dal.RellenarNombresPersonajes(ListaPersonajes);
            ListaPersonajes = dal.RellenarNombresAnimes(ListaPersonajes);
            ListaPersonajes = dal.RellenarNumeroAtaqueYDefensa(ListaPersonajes);
            return ListaPersonajes;
        }
    }
}
