using CineCordobaBack.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Reflection.Emit;

namespace CineCordobaBack.Datos.Context
{

    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options)
        {

        }
        
        public DbSet<Funciones> Funciones { get; set; }
        public DbSet<Peliculas> Peliculas { get; set; }
        public DbSet<Salas> Salas { get; set; }
        public DbSet<Horarios> Horarios { get; set; }
        public DbSet<Generos> Generos { get; set; }
        public DbSet<Clasificacion> Clasificaciones { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<TipoSalas> TiposSalas { get; set; }
        public string DbPath { get; private set; }

        private string CONN = "Data Source=DESKTOP-KI5LVF5\\SQLEXPRESS;Initial Catalog=Cordoba_Cine_GRUPO_N9;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public DbContexto()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "Cordoba_Cine_GRUPO_N9");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
               => options.UseSqlServer(CONN);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funciones>()
                .HasOne(f => f.Horario)
                .WithMany(h => h.Funciones)
                .HasForeignKey(f => f.id_horario);

            modelBuilder.Entity<Peliculas>()
           .ToTable("peliculas")
           .HasKey(p => p.id_pelicula);

            modelBuilder.Entity<Peliculas>()
                .HasOne(p => p.Genero)
                .WithMany()
                .HasForeignKey(p => p.id_genero);

            modelBuilder.Entity<Peliculas>()
                .HasOne(p => p.Clasificacion)
                .WithMany()
                .HasForeignKey(p => p.id_clasificacion);

            modelBuilder.Entity<Peliculas>()
                .HasOne(p => p.Idioma)
                .WithMany()
                .HasForeignKey(p => p.id_idioma);

            base.OnModelCreating(modelBuilder);
        }
    }
}