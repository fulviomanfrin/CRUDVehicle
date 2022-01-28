using ApplicationCore.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
