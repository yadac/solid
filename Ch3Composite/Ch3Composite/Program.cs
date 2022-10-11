using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3Composite
{
    internal class Program
    {
        static IComponent component;
        static void Main(string[] args)
        {
            var composite = new CompositeComponent();
            composite.AddComponent(new Leaf());
            composite.AddComponent(new Leaf());
            composite.AddComponent(new Leaf());
            component = composite;
            component.Something();

            // 述語デコレーター：コードの実行付き条件をクライアントから隠蔽
            // 分岐デコレーター：
            // 遅延デコレーター
            // もろもろデコレーター
            // Compositeで条件違いの処理も可能
            var example = new PredicatedDecoratorExample(
                new PredicatedComponent(
                    // true
                    new ProfilingComponent(
                        new SlowComponent(),
                        new LoggingStopwatch(
                            new StopwatchAdapter(new Stopwatch()))),
                    // false
                    new FalseComponent(),
                    // predicate
                    new IsEventDate(new DateTester())));
            example.Run();
        }
    }
}
