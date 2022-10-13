using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8ISP
{
    public class ReadCaching<T> : IRead<T>
    {
        private T _cachedEntity;
        private IEnumerable<T> _cachedEntities;
        private ICrud<T> _crud;

        public ReadCaching(ICrud<T> crud)
        {
            _crud = crud;
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
    }
}
