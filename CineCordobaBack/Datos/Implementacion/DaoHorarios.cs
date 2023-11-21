using CineCordobaBack.Datos.Context;
using CineCordobaBack.Datos.Interfaces;
using CineCordobaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Datos.Concretas
{
    public class DaoHorarios : IDaoHorario
    {
        private readonly DbContexto db;

        public DaoHorarios(DbContexto dbContext)
        {
            db = dbContext;
        }

        public void Add(Horarios entity)
        {
            db.Horarios.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                db.Horarios.Remove(entity);
                db.SaveChanges();
            }
        }

        public List<Horarios> GetAll()
        {
            return db.Horarios.ToList();
        }

        public Horarios GetById(int id)
        {
            return db.Horarios.Find(id);
        }


        public void Update(Horarios entity)
        {
            db.Horarios.Update(entity);
            db.SaveChanges();
        }
        public List<Horarios> ObtenerHorarios()
        {
            try
            {
                var horarios = db.Horarios.ToList();
                return horarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los horarios: {ex.Message}");
                return new List<Horarios>();
            }
        }
    }
}
