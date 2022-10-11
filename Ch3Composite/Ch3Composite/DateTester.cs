using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ch3Composite
{
    public class DateTester
    {
        public bool IsEventDate 
        { 
            get { return DateTime.Now.Day % 2 == 0; } 
        }
    }

    public class IsEventDate : IPredicate
    {
        private readonly DateTester _datetester;
        public IsEventDate(DateTester dateTester)
        {
            _datetester = dateTester;
        }
        public bool Test()
        {
            return _datetester.IsEventDate;
        }
    }

    public interface IPredicate
    {
        bool Test();
    }

    public class ConcreteComponent : IComponent
    {
        public void Something()
        {
            Console.WriteLine("concrete do something");
        }
    }
    public class TrueComponent : IComponent
    {
        public void Something()
        {
            Console.WriteLine("trueComponent do something");
        }
    }
    public class FalseComponent : IComponent
    {
        public void Something()
        {
            Console.WriteLine("falseComponent do something");
        }
    }
    public class LazyComponent : IComponent
    {
        private readonly Lazy<IComponent> _component;
        public LazyComponent(Lazy<IComponent> component)
        {
            _component = component;
        }
        public void Something()
        {
            _component.Value.Something();
        }
    }

    /// <summary>
    /// 実行時間のかかるコンポーネント
    /// </summary>
    public class SlowComponent : IComponent
    {
        private readonly Random _random;
        public SlowComponent()
        {
            _random = new Random((int)DateTime.Now.Ticks);
        }
        public void Something()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(_random.Next(i));
            }
            Console.WriteLine("falseComponent do something");
        }
    }

    /// <summary>
    /// 計測用コンポーネント
    /// </summary>
    public class ProfilingComponent : IComponent
    {
        private readonly IComponent _component;
        private IStopwatch _stopwatch;
        public ProfilingComponent(
            IComponent component,
            IStopwatch stopwatch)
        {
            _component = component;
            _stopwatch = stopwatch;
        }
        public void Something()
        {
            _stopwatch.Start();
            _component.Something();
            _stopwatch.Stop();
        }
    }

    public interface IStopwatch
    {
        void Start();
        long Stop();
    }

    public class LoggingStopwatch : IStopwatch
    {
        private readonly IStopwatch _stopwatch;
        public LoggingStopwatch(IStopwatch stopwatch)
        {
            _stopwatch = stopwatch;
        }

        public void Start()
        {
            _stopwatch.Start();
            Console.WriteLine("Stopwatch started...");
        }

        public long Stop()
        {
            var elapsedMilliseconds = _stopwatch.Stop();
            Console.WriteLine("Stopwatch stopped after {0} seconds",
                TimeSpan.FromMilliseconds(elapsedMilliseconds).TotalSeconds);
            return elapsedMilliseconds;
        }
    }

    public class StopwatchAdapter : IStopwatch
    {
        private Stopwatch _stopwatch;
        public StopwatchAdapter(Stopwatch stopwatch)
        {
            _stopwatch = stopwatch;
        }
    
        public void Start()
        {
            _stopwatch.Start();
        }

        public long Stop()
        {
            _stopwatch.Stop();
            var elapsedMilliseconds = _stopwatch.ElapsedMilliseconds;
            _stopwatch.Reset();
            return elapsedMilliseconds;
        }
    }

    public class PredicatedComponent : IComponent
    {
        private readonly IComponent _trueComponent;
        private readonly IComponent _falseComponent;
        private readonly IPredicate _predicate;

        public PredicatedComponent(
            IComponent trueComponent,
            IComponent falseComponent,
            IPredicate predicate)
        {
            _trueComponent = trueComponent;
            _falseComponent = falseComponent;
            _predicate = predicate;
        }

        public void Something()
        {
            if (_predicate.Test())
            {
                _trueComponent.Something();
            }
            else
            {
                _falseComponent.Something();
            }
        }
    }

    public class PredicatedDecoratorExample
    {
        private readonly IComponent _component;
        public PredicatedDecoratorExample(IComponent component)
        {
            _component = component;
        }
        public void Run()
        {
            _component.Something();
        }
    }
}
