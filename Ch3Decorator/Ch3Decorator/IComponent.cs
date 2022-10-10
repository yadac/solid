using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3Decorator
{
    public interface IComponent
    {
        void Something();
    }

    internal class ConcreteComponent : IComponent
    {
        public void Something()
        {
            throw new NotImplementedException();
        }
    }

    internal class DecoratorComponent : IComponent
    {
        private readonly IComponent _component;

        public DecoratorComponent(IComponent component)
        {
            // パラメータとして受け取る
            _component = component;
        }
        public void Something()
        {
            // 既存機能に追加する（decorate）機能
            SomethingElse();
            // 型の契約を満たす
            _component.Something();
        }

        private void SomethingElse()
        {
        }
    }
}
