using CineCordobaApi.Services.Implementacion;
using CineCordobaBack.Fachada.Concretas;
using CineCordobaBack.Datos.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using CineCordobaFront.Presentacion;

namespace CineCordobaFront
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var dbContextOptions = new DbContextOptionsBuilder<DbContexto>()
                .UseSqlServer("Data Source=DESKTOP-KI5LVF5\\SQLEXPRESS;Initial Catalog=Cordoba_Cine_GRUPO_N9;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;")
                .Options;

            var dbContext = new DbContexto(dbContextOptions);
            var funcionesDao = new FuncionesDao(dbContext);


            Application.Run(new frmMenu());
        }
    }
}

