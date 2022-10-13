using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8ISP
{
    public class DeleteConfirmation<T> 
        : IUserInteraction, IDelete<T>
    {
        private ICrud<T> _crud;

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

        public void Delete(T entity)
        {
            if (Confirmation("are you sure you want to delete [y/n] ?"))
            {
                _crud.Delete(entity);
            }
        }
    }
}
