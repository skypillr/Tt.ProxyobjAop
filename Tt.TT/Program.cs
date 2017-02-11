using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tt.ProxyObj.Dynamic;
using Tt.TT.dynamic;

namespace Tt.TT
{
    class Program
    {

        static void Main(string[] args)
        {
            var proxy=ProxyFactry.Create(new Test());
            Console.Write(proxy.Add(3, 2));
            Console.Read();
           
        }
     

    }
}
