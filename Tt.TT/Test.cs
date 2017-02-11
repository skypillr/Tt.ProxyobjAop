using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tt.TT.dynamic
{
    
    class Test
    {
        public string StateTest = "Test state";

        [BeforeLogAttribute]
        [AfterLogAttribute]
        public int Add(int  x,int y)
        {
            var s = x + y;
            Console.WriteLine("in Add sum=x+y:"+s);
            return s;
        }
    }
}
