using LibraryRepo.ModelsCar;
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
        DbSet<T> cars;

        public RepoBase()
        {
            context = new CarRentalContext();
            cars = context.Set<T>();
        }

        public List<T> getAll()
        {
            return cars.ToList();
        }
        public bool Create(T entity)
        {
            try
            {
                cars.Add(entity);
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
                cars.Remove(entity);
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
