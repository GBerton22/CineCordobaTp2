using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineCordobaBack.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CineCordobaBack.Datos.Context;
using CineCordobaBack.Fachada.Interfaces;

namespace CineCordobaBack.Fachada.Concretas
{
    public class FuncionesDao : IFuncionesDao
    {
        private readonly DbContexto db;

        public FuncionesDao(DbContexto dbContext)
        {
            db = dbContext;
        }

        public List<Funciones> GetAll()
        {
            return db.Funciones.ToList();
        }

        public Funciones GetById(int id)
        {
            return db.Funciones.Find(id);
        }

        public void Add(Funciones entity)
        {
            db.Funciones.Add(entity);
            db.SaveChanges();
        }

        public void Update(Funciones entity)
        {
            try
            {
                db.Funciones.Update(entity);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar la función: {ex.Message}", ex);
            }
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                db.Funciones.Remove(entity);
                db.SaveChanges();
            }
        }

        public List<int> ObtenerIdsFunciones()
        {
            try
            {
                var idsFunciones = db.Funciones.Select(f => f.id_funcion).ToList();

                return idsFunciones;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener IDs de funciones desde la base de datos: {ex.Message}", ex);
            }
        }

        public List<Funciones> ObtenerFuncionesPorPelicula(DateTime fechaDesde, DateTime fechaHasta, int idPelicula)
        {
            try
            {
                var funciones = db.Funciones
                    .Include(f => f.Pelicula)
                    .Include(f => f.Horario)
                    .Include(f => f.Sala)
                    .Where(f => f.id_pelicula == idPelicula && f.Fecha >= fechaDesde && f.Fecha <= fechaHasta)
                    .ToList();

                return funciones;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener funciones por película: {ex.Message}");
                return new List<Funciones>();
            }
        }

        public Funciones ObtenerDetallesFuncion(int idFuncion)
        {
            try
            {
                var detallesFuncion = db.Funciones
                    .Include(f => f.Pelicula)
                    .Include(f => f.Horario)
                    .Include(f => f.Sala)
                    .Where(f => f.id_funcion == idFuncion)
                    .FirstOrDefault();

                return detallesFuncion;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener detalles de la función: {ex.Message}");
                return null;
            }
        }
        public void ActualizarFuncion(Funciones funcion)
        {
            try
            {
                db.Funciones.Update(funcion);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar la función: {ex.Message}", ex);
            }
        }
        public bool EliminarFuncion(int idFuncion)
        {
            try
            {
                var funcion = db.Funciones.Find(idFuncion);

                if (funcion != null)
                {
                    db.Funciones.Remove(funcion);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar la función: {ex.Message}", ex);
            }

        }

    }
}
