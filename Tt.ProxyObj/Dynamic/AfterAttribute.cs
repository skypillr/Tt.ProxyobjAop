﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tt.ProxyObj.Interface;

namespace Tt.ProxyObj.Dynamic
{

    [AttributeUsage(AttributeTargets.Method)]
    public class AfterAttribute: AOPAttribute
    {
  
    }
}
