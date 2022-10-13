using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8ISP
{
    public interface ICrud<T>
    {
        void Create(T entity);
        T ReadOne(Guid id);
        IEnumerable<T> ReadAll();
        void Update(T entity);
        void Delete(T entity);
    }

    public interface ICru<T>
    {
        void Create(T entity);
        T ReadOne(Guid id);
        IEnumerable<T> ReadAll();
        void Update(T entity);
    }

    public interface IDelete<T>
    {
        void Delete(T entity);
    }
}
