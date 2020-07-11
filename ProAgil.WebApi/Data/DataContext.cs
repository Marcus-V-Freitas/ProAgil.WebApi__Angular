﻿using Microsoft.EntityFrameworkCore;
using ProAgil.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAgil.WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> context) : base(context)
        {
        }

        public DbSet<Evento> Eventos { get; set; }
    }
}
