using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tt.ProxyObj.Dynamic
{
    public class ProxyFactry
    {

        public static dynamic Create<T>(T obj)
        {
            return new DynamicProxy<T>(obj);
        }
    }
}
