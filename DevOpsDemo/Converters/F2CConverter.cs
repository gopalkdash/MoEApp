using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSWebApiEmpty.Converters
{
    public class F2CConverter
    {
        public int F2C(int f)
        {
            return (f - 32) * 5 / 9;
        }
    }
}