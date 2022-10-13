using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8ISP
{
    public class DeleteConfirmation<T> 
        : ICrud<T>, IUserInteraction, IRead<T>
    {
        private ICrud<T> _crud;
        private T _cachedEntity;
        private IEnumerable<T> _cachedEntities;

        public DeleteConfirmation(ICrud<T> crud)
        {
            _crud = crud;
        }

        public bool Confirmation(string message)
        {
            Console.WriteLine(message);
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                return true;
            }
            return false;
        }

        public void Create(T entity)
        {
            _crud.Update(entity);
        }

        public void Delete(T entity)
        {
            if (Confirmation("are you sure you want to delete [y/n] ?"))
            {
                _crud.Delete(entity);
            }
        }

        public IEnumerable<T> ReadAll()
        {
            if (_cachedEntities == null)
            {
                _cachedEntities = _crud.ReadAll();
            }
            return _crud.ReadAll();
        }

        public T ReadOne(Guid id)
        {
            if (_cachedEntities == null)
            {
                _cachedEntity = _crud.ReadOne(id);
            }
            return _cachedEntity;
        }

        public void Update(T entity)
        {
            _crud.Update(entity);
        }
    }
}
