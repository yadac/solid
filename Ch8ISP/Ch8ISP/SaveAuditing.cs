using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8ISP
{
    public class SaveAuditing<T> : ISave<T>
    {
        private readonly ISave<T> _crud;
        private readonly ISave<AuditInfo> _audit;
        
        /// <summary>
        /// Factoryで取得するとクライアントはauditを知らない
        /// </summary>
        /// <param name="crud"></param>
        /// <param name="audit"></param>
        public SaveAuditing(ISave<T> crud, ISave<AuditInfo> audit)
        {
            _crud = crud;
            _audit = audit;
        }

        public void Save(T entity)
        {
            _crud.Save(entity);
            var auditInfo = new AuditInfo
            {
                UserName = "yadac",
                TimeStamp = DateTime.Now,
            };
            _audit.Save(auditInfo);
        }
    }

    public class SaveAudit<T> : ISave<T> where T : AuditInfo
    {
        public void Save(T entity)
        {
            Console.WriteLine("{0}, {1}"
                , entity.TimeStamp
                , entity.UserName);
        }
    }

    public class AuditInfo
    {
        public string UserName { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    public class SimpleSave<T> : ISave<T>
    {
        private readonly ICrud<T> _crud;
        public SimpleSave(ICrud<T> crud)
        {
            _crud = crud;
        }

        public void Save(T entity)
        {
            if (DateTime.Now.Ticks % 2 == 0)
            {
                _crud.Create(entity);
            }
            else
            {
                _crud.Update(entity);
            }
        }
    }
}
