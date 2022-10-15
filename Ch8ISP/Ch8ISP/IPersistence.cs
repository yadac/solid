using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;

namespace Ch8ISP
{
    public interface IPersistence
    {
        IEnumerable<Item> GetAll();
        Item GetById(int id);
        IEnumerable<Item> FindByCriteria(string criteria);
        void Save(Item item);
        void Delete(Item item);
    }

    public class Item { }

    public class Persistence : IPersistence
    {
        private readonly ICrud<Item> _crud;
        public Persistence(ICrud<Item> crud)
        {
            _crud = crud;
        }

        public void Delete(Item item)
        {
            _crud.Delete(item);
        }

        public IEnumerable<Item> FindByCriteria(string criteria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAll()
        {
            throw new NotImplementedException();
        }

        public Item GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Item item)
        {
            _crud.Create(item);
        }
    }
}
