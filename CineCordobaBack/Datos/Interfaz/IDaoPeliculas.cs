﻿using CineCordobaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Datos.Interfaces
{
    public interface IDaoPeliculas : IDaoRepository<Peliculas>
    {
        List<Peliculas> ObtenerPeliculas();
    }
}
