using RegistroEstudiantes.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroEstudiantes.Models.Repository
{
    public interface IEstudianteRepository : IBaseRepository<Estudiante>
    {

    }
    public class EstudianteRepository : BaseRepository<Estudiante>, IEstudianteRepository
    {
        public EstudianteRepository(ApplicationDbContext DbContext)
            : base(DbContext)
        {
            
        }
    }
}
