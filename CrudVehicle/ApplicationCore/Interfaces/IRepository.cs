using ApplicationCore.Models.Base;
using System.Collections.Generic;

namespace ApplicationCore.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T FindById(int id);
        List<T> FindAll();
        T Create(T entity);
        void Delete(T entity);
        T Update(T entity);
    }

    
}
