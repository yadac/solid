using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ch8ISP
{
    public class DeleteEventPublishing<T> : IDelete<T>, ISave<T>
    {
        private readonly IEventPublisher _eventPublisher;
        private readonly IDelete<T> _delete;
        private readonly ISave<T> _save;

        public DeleteEventPublishing(
            IDelete<T> delete
            , IEventPublisher eventPublisher
            , ISave<T> save)
        {
            _delete = delete;
            _eventPublisher = eventPublisher;
            _save = save;
        }

        public void Delete(T entity)
        {
            _delete.Delete(entity);
            var entityDeleted = new EntityDeletedEvent<T>(entity);
            _eventPublisher.Publish(entityDeleted);
        }

        public void Save(T entity)
        {
            _save.Save(entity);
            var entitySaved = new EntitySavedEvent<T>(entity);
            _eventPublisher.Publish(entitySaved);
        }
    }

    internal class EntitySavedEvent<T> : IEvent
    {
        private T entity;

        public EntitySavedEvent(T entity)
        {
            this.entity = entity;
        }
        public string Name { get { return "hello"; } }
    }

    internal class EntityDeletedEvent<T> : IEvent
    {
        private T entity;

        public EntityDeletedEvent(T entity)
        {
            this.entity = entity;
        }

        public string Name { get { return "hello"; } }
    }
}
