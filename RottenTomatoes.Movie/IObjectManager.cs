using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RottenTomatoes.Movie
{
    public interface IObjectManager<T>
    {
        Task<T> GetAll(string param,int page);
        //Task<IEnumerable<T>> Search(Expression<Func<T, bool>> expression);
  


    }
}
