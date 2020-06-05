using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroEstudiantes.Models;

namespace RegistroEstudiantes.Models.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Carrera> Carrera { get; set; }
    }
}
