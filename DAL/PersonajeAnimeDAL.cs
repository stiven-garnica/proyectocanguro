using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class PersonajeAnimeDAL
    {
        Random random = new Random();
        public List<PersonajeAnime> RellenarNombresPersonajes(List<PersonajeAnime> ListaPersonajes)
        {
            string[] nombres = { "Hina", "Azusa", "Kyouka", "Yuni", "Rice", "Mihono" };
            for (int i = 0; i < nombres.Length; i++)
            {
                ListaPersonajes.Add(new PersonajeAnime { NombrePersonaje = nombres[i]});
            }
            return ListaPersonajes;
        }
        public List<PersonajeAnime> RellenarNombresAnimes(List<PersonajeAnime> ListaPersonajes)
        {
            string[] nombres = { "Blue Archive", "Princess Connect", "Uma Musume" };
            foreach(var personaje in ListaPersonajes)
            {
                personaje.NombreAnime = nombres[random.Next(0, 3)];
            }
            return ListaPersonajes;
        }
        public List<PersonajeAnime> RellenarNumeroAtaqueYDefensa(List<PersonajeAnime> ListaPersonajes)
        {
            foreach(var personaje in ListaPersonajes)
            {
                personaje.AtaquePersonaje = random.Next(500, 1000);
                personaje.DefensaPersonaje = random.Next(100, 500);
            }
            return ListaPersonajes;
        }
    }
}
