using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tt.ProxyObj.Dynamic;
using Tt.TT.dynamic;

namespace Tt.TT
{
    public class AfterLogAttribute:AfterAttribute
    {
        public AfterLogAttribute()
        {

        }
        public override void Handle()
        {
            Console.WriteLine("AfterLogAttribute Handle:" + (this.Target as Test).StateTest);
        }
    }
}
