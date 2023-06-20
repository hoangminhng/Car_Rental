using LibraryRepo.Cars;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepo.Repo
{
    public class RepoBase<T> where T : class
    {
        CarRentalContext context;
        DbSet<T> _dbSet;

        public RepoBase()
        {
            context = new CarRentalContext();
            _dbSet = context.Set<T>();
        }

        public List<T> getAll()
        {
            return _dbSet.ToList();
        }
        public bool Create(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public void Update(T entity)
        {
            var tracker = context.Attach(entity);
            tracker.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
