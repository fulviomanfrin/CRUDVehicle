using ApplicationCore.Interfaces;
using ApplicationCore.Models.Base;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories.Generic
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly CrudVehicleDataContext _dbContext;
        protected DbSet<T> dataset;

        public Repository(CrudVehicleDataContext dbContext)
        {
            _dbContext = dbContext;
            dataset = _dbContext.Set<T>();
        }

        public T FindById(int id)
        {
            return dataset.SingleOrDefault(p => p.Id.Equals(id));
        }

        public List<T> FindAll()
        {
            return dataset.ToList();
        }
        
        public T Create(T item)
        {
            
            try
            {
                dataset.Add(item);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return item;
        }

        public T Update(T entity)
        {
            
            var model = dataset.SingleOrDefault(x => x.Id == entity.Id);
            
            _dbContext.Entry(model).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
