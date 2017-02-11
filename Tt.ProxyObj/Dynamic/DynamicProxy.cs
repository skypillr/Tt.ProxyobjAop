using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tt.ProxyObj.Dynamic
{
    public interface IAdd
    {
        int Add(int x, int y);
    }
    public class DynamicProxy<T>:DynamicObject
    {
        Type type;
        object obj;

        public T Target { get; set; }
        public DynamicProxy(T obj)
        {
            this.type = typeof(T);
            this.obj = obj;
        }

  

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {

            if (type != null)
            {
                
                MethodInfo method=
                type.GetMethod(binder.Name);
                Attribute[] beforeattributes=
                Attribute.GetCustomAttributes(method,typeof(BeforeAttribute));
                if (beforeattributes != null)
                {
                    foreach (var item in beforeattributes)
                    {
                        BeforeAttribute b = (item as BeforeAttribute);
                        b.Target = obj;
                        b.Handle();
                    }
                }
                result =method.Invoke(obj,args);

                Attribute[] afterattributes =
               Attribute.GetCustomAttributes(method, typeof(AfterAttribute));
                if (afterattributes != null)
                {
                    foreach (var item in afterattributes)
                    {
                        AfterAttribute a = (item as AfterAttribute);
                        a.Target = obj;
                        a.Handle();
                    }
                }

                return true;
            }
            result = null;
            return true;
        }

        
    }

 


}
