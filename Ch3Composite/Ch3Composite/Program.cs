using System;
using System.Collections.Generic;
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
            // Compositeで条件違いの処理も可能
            var example = new PredicatedDecoratorExample(
                new PredicatedComponent(
                    new TrueComponent(),
                    new FalseComponent(),
                    new IsEventDate(new DateTester())));
            example.Run();
        }
    }
}
