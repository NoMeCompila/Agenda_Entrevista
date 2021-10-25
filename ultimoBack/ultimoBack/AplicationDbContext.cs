﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ultimoBack.Models;
namespace ultimoBack
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<Empleo> Empleo { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
    }
}
