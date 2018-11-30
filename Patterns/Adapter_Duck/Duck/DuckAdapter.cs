using Adapter_Duck.Turkey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Duck.Duck
{
    class DuckAdapter : ITurkey
    {
        IDuck _duck;

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
        }

        public void Fly()
        {
            _duck.Fly();
        }

        public void Gobble()
        {
            _duck.Quack();
        }
    }
}
