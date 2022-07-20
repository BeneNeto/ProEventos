using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back.src.Proeventos.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Proeventos.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Evento> Eventos { get; set; }
    }
}