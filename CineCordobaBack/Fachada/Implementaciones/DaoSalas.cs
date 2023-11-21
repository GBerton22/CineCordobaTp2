using CineCordobaBack.Datos.Context;
using CineCordobaBack.Entidades;
using CineCordobaBack.Fachada.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Fachada.Concretas
{
    public class DaoSalas : IDaoSala
    {
        private readonly DbContexto db;

        public DaoSalas(DbContexto dbContext)
        {
            db = dbContext;
        }

        public void Add(Salas entity)
        {
            db.Salas.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                db.Salas.Remove(entity);
                db.SaveChanges();
            }
        }

        public List<Salas> GetAll()
        {
            return db.Salas.ToList();
        }

        public Salas GetById(int id)
        {
            return db.Salas.Find(id);
        }


        public void Update(Salas entity)
        {
            db.Salas.Update(entity);
            db.SaveChanges();
        }
        public List<Salas> ObtenerSalas()
        {
            try
            {
                var salas = db.Salas.ToList();
                return salas;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las salas: {ex.Message}");
                return new List<Salas>();
            }
        }
    }
}
