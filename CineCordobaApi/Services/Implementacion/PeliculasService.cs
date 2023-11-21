using CineCordobaApi.Services.Interfaz;
using CineCordobaBack.Entidades;
using CineCordobaBack.Fachada.Concretas;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Reflection.Emit;
using CineCordobaBack.Fachada.Interfaces;

namespace CineCordobaApi.Services.Implementacion
{
    public class PeliculasService : IPeliculaService
    {
        private readonly IDaoPeliculas _daoPeliculas;

        public PeliculasService(IDaoPeliculas peliculasRepository)
        {
            _daoPeliculas = peliculasRepository;
        }

        public List<Peliculas> ObtenerPeliculas()
        {
            return _daoPeliculas.ObtenerPeliculas();
        }
    }
}