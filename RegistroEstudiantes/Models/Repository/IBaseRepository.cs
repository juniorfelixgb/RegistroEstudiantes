using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroEstudiantes.Models.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int Id);
        void Add(T Entity);
        void Update(T Entity);
        void Delete(int Id);
        bool Save();
    }
}
