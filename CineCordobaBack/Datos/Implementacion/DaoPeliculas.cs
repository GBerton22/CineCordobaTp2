using CineCordobaBack.Datos.Context;
using CineCordobaBack.Datos.Interfaces;
using CineCordobaBack.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Datos.Concretas
{
    public class DaoPeliculas : IDaoPeliculas
    {
        private readonly DbContexto db;

        public DaoPeliculas(DbContexto dbContext)
        {
            db = dbContext;
        }

        public List<Peliculas> GetAll()
        {
            return db.Peliculas.ToList();
        }

        public Peliculas GetById(int id)
        {
            return db.Peliculas.Find(id);
        }

        public void Add(Peliculas entity)
        {
            db.Peliculas.Add(entity);
            db.SaveChanges();
        }

        public void Update(Peliculas entity)
        {
            db.Peliculas.Update(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                db.Peliculas.Remove(entity);
                db.SaveChanges();
            }
        }

        public List<Peliculas> ObtenerPeliculas()
        {
            try
            {
                var peliculas = db.Peliculas.ToList();
                return peliculas;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener películas: {ex.Message}");
                return new List<Peliculas>();
            }
        }

        
    }
}
