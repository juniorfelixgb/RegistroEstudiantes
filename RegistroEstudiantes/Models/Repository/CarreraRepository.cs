using RegistroEstudiantes.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroEstudiantes.Models.Repository
{
    public interface ICarreraRepository : IBaseRepository<Carrera>
    {
    }
    public class CarreraRepository: BaseRepository<Carrera>, ICarreraRepository
    {
        public CarreraRepository(ApplicationDbContext DbContext)
            : base(DbContext)
        {
            
        }
    }
}
