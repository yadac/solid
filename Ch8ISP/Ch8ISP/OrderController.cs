using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8ISP
{
    public class OrderController
    {
        private readonly IRead<Order> _reader;
        private readonly ISave<Order> _saver;
        private readonly IDelete<Order> _deleter;
        public OrderController(
            IRead<Order> orderReader,
            ISave<Order> orderSaver,
            IDelete<Order> orderDeleter)
        {
            _reader = orderReader;
            _saver = orderSaver;
            _deleter = orderDeleter;
        }

        public void CreateOrder(Order order)
        {
            _saver.Save(order);
        }
        public Order GetSingleOrder(Guid id)
        {
            return _reader.ReadOne(id);
        }
        public void UpdateOrder(Order order)
        {
            _saver.Save(order);
        }
        public void DeleteOrder(Order order)
        {
            _deleter.Delete(order);
        }
    }

    public class Order
    {
    }
    public class OrderReader<Order> : IRead<Order>
    {
        public IEnumerable<Order> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Order ReadOne(Guid id)
        {
            throw new NotImplementedException();
        }
    }
    public class OrderSaver<Order> : ISave<Order>
    {
        public void Save(Order entity)
        {
            throw new NotImplementedException();
        }
    }
    public class OrderDeleter<Order> : IDelete<Order>
    {
        public void Delete(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
