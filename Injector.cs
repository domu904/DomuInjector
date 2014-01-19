using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomuInjector
{
    class Injector
    {
        public void Bind<T>(T instance)
        {
            providers[typeof(T)]= ()
        }

    }
}
