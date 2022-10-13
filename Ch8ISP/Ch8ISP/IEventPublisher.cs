using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8ISP
{
    public interface IEventPublisher
    {
        void Publish<T>(T @event) where T : IEvent;
    }

    public interface IEventSubscriber
    {
        void Subscribe<T>(T @event) where T : IEvent;
    }

    public interface IEvent
    {
        string Name { get; }
    }
}
