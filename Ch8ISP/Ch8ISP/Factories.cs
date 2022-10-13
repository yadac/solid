using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8ISP
{
    public class Factories
    {
        public static OrderController CreateOrderController()
        {
            var reader = new OrderReader<Order>();
            var saver = new OrderSaver<Order>();
            var deleter = new OrderDeleter<Order>();
            return new OrderController(reader, saver, deleter);
        }

        public static GenericController<T> CreateGenericController<T>()
        {
            var reader = new GenericReader<T>();
            var saver = new GenericSaver<T>();
            var deleter = new GenericDeleter<T>();
            return new GenericController<T>(reader, saver, deleter);
        }

    }

    internal class GenericDeleter<T> : IDelete<T>
    {
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }

    internal class GenericSaver<T> : ISave<T>
    {
        public void Save(T entity)
        {
            throw new NotImplementedException();
        }
    }

    internal class GenericReader<T> : IRead<T>
    {
        public IEnumerable<T> ReadAll()
        {
            throw new NotImplementedException();
        }

        public T ReadOne(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
