using System;
using System.Collections.Generic;
using System.Linq.Expressions; //LAMDA expressions
using System.Text;
using System.Threading.Tasks;

namespace PakHos.Data.Abstract
{
    internal interface IRepository<T> where T:class //<T> TÜM CLASSLAR ÇALIŞABİLMESİ İÇİN GENERİC YAPIYORUZ
    {
        
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);
        T Get(Expression<Func<T, bool>> expression);
        T Find(int id);
        void add(T entity);
        void remove(T entity);
        void clear();
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();
        //Asenkron Metotlar
       
        Task<T> FindAsync(int id);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAllAsync();
       Task <List<T>>GetAllAsync(Expression<Func<T, bool>> expression);
        Task<int> SaveAsync();
        Task<T> ADD(T entity);


    }
}
