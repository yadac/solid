using System;
using System.Collections.Generic;

namespace Ch8ISP
{
    public interface ICru<T>
    {
        void Create(T entity);
        T ReadOne(Guid id);
        IEnumerable<T> ReadAll();
        void Update(T entity);
    }
}
