using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface ICarRepository
    {
        Car GetById(int id);
        IEnumerable<Car> List();
        IEnumerable<Car> List(Expression<Func<Car, bool>> predicate);
        void Create(Car entity);
        void Delete(Car entity);
        void Update(Car entity);
    }
}
