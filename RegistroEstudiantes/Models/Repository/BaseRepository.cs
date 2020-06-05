using Microsoft.EntityFrameworkCore;
using RegistroEstudiantes.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroEstudiantes.Models.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext dbContext;
        protected DbSet<T> dbSet;

        public BaseRepository(ApplicationDbContext DbContext)
        {
            dbContext = DbContext;
            dbSet = dbContext.Set<T>();

        }
        public void Add(T Entity)
        {
            dbSet.Add(Entity);
        }

        public void Delete(int Id)
        {
            var Entity = GetById(Id);
            dbSet.Remove(Entity);
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(int Id)
        {
            return dbSet.Find(Id);
        }

        public void Update(T Entity)
        {
            dbContext.Entry(Entity).State = EntityState.Modified;
        }

        public bool Save()
        {
            try
            {
                return dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
