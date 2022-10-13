using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8ISP
{
    public class DeleteConfirmation<T> : ICrud<T>
    {
        private ICrud<T> _crud;
        public DeleteConfirmation(ICrud<T> crud)
        {
            _crud = crud;
        }

        public void Create(T entity)
        {
            _crud.Update(entity);
        }

        public void Delete(T entity)
        {
            _crud.Delete(entity);
        }

        public IEnumerable<T> ReadAll()
        {
            return _crud.ReadAll();
        }

        public T ReadOne(Guid id)
        {
            return _crud.ReadOne(id);
        }

        public void Update(T entity)
        {
            Console.WriteLine("are you sure you want to delete the entity [y/n]?");
            var keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Y)
            {
                _crud.Delete(entity);
            }
        }
    }
}
