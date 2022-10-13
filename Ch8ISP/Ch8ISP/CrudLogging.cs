using log4net;
using System;
using System.Collections.Generic;

namespace Ch8ISP
{
    /// <summary>
    /// 横断的関心ログ
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CrudLogging<T> : ICrud<T>
    {
        private ICrud<T> _crud;
        private ILog _log;
        public CrudLogging(ICrud<T> crud, ILog log)
        {
            _crud = crud;
            _log = log;
        }

        public void Create(T entity)
        {
            _log.InfoFormat("Creating entity of type {0}",
                typeof(T).Name);
            _crud.Create(entity);
        }

        public void Delete(T entity)
        {
            _log.InfoFormat("Deleting entity of type {0}",
                typeof(T).Name);
            _crud.Delete(entity);
        }

        public IEnumerable<T> ReadAll()
        {
            _log.InfoFormat("Reading all entities of type {0}",
                typeof(T).Name);
            return _crud.ReadAll();
        }

        public T ReadOne(Guid id)
        {
            _log.InfoFormat("Reading entity of type {0}",
                typeof(T).Name);
            return _crud.ReadOne(id);
        }

        public void Update(T entity)
        {
            _log.InfoFormat("Updating entity of type {0}",
                typeof(T).Name);
            _crud.Update(entity);
        }
    }
}
