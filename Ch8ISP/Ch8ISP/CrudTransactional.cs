using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Ch8ISP
{
    /// <summary>
    /// 横断的関心トランザクション
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CrudTransactional<T> : ICru<T>, IDelete<T>
    {
        private ICrud<T> _crud;
        public CrudTransactional(ICrud<T> crud)
        {
            _crud = crud;
        }

        public void Create(T entity)
        {
            using (var tran = new TransactionScope())
            {
                _crud.Create(entity);
                tran.Complete();
            }
        }

        public void Delete(T entity)
        {
            using (var tran = new TransactionScope())
            {
                _crud.Delete(entity);
                tran.Complete();
            }
        }

        public IEnumerable<T> ReadAll()
        {
            IEnumerable<T> result;
            using (var tran = new TransactionScope())
            {
                result = _crud.ReadAll();
                tran.Complete();
            }
            return result;
        }

        public T ReadOne(Guid id)
        {
            T result;
            using (var tran = new TransactionScope())
            {
                result = _crud.ReadOne(id);
                tran.Complete();
            }
            return result;
        }

        public void Update(T entity)
        {
            using (var tran = new TransactionScope())
            {
                _crud.Update(entity);
                tran.Complete();
            }
        }
    }
}
