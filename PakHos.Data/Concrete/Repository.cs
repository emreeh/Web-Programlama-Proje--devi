using Microsoft.EntityFrameworkCore;
using PakHos.Data.Abstract;
using PakHos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PakHos.Data.Concrete
{
    public class Repository<T> : IRepository<T> where T : class, IEntity, new()// GENERİC  <T> TÜM CLASSLARI İFADE EDİYOR
    {
        internal DatabaseContext DbContext;
        internal DbSet<T> DbSet; /// TÜM DB SETLER
        public Repository(DatabaseContext dbContext)
        {
            DbContext = dbContext;
            DbSet =dbContext.Set<T>();
           



        }



        public void add(T entity)
        {
           DbSet.Add(entity);
        }

        public async Task AddAsync(T entity)
        {
           await DbSet.AddAsync(entity);
        }


        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public T Find(int id)
        {
            return DbSet.Find(id);

        }

        public async Task<T> FindAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return DbSet.FirstOrDefault(Get(expression));
        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return DbSet.Where(expression).ToList();
        }

        public async Task<List<T>> GetAllAsync()
        {
           return await DbSet.ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
            return await DbSet.Where(expression).ToListAsync();
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return DbSet.FirstOrDefaultAsync(expression);
        }

        public void remove(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            return DbContext.SaveChangesAsync();
        }

        public async void SaveChanges()
        {
           await DbContext.SaveChangesAsync();
        }

        public void Update(T entity)
        {
           DbContext.Update(entity);
        }

        void IRepository<T>.add(T entity)
        {
            throw new NotImplementedException();
        }

        Task<T> IRepository<T>.ADD(T entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.clear()
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.Delete(T entity)
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.Find(int id)
        {
            throw new NotImplementedException();
        }

        Task<T> IRepository<T>.FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.Get(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        List<T> IRepository<T>.GetAll()
        {
            throw new NotImplementedException();
        }

        List<T> IRepository<T>.GetAll(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        Task<List<T>> IRepository<T>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<List<T>> IRepository<T>.GetAllAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        Task<T> IRepository<T>.GetAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.remove(T entity)
        {
            throw new NotImplementedException();
        }

        Task<int> IRepository<T>.SaveAsync()
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.SaveChanges()
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
