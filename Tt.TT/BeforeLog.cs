using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tt.ProxyObj.Dynamic;
using Tt.TT.dynamic;

namespace Tt.TT
{
    public class BeforeLogAttribute:BeforeAttribute
    {
        public BeforeLogAttribute()
        {

        }
        public override void Handle()
        {
            Console.WriteLine("BeforeLogAttribute Handle:"+(this.Target as Test).StateTest);
        }
    }
}
