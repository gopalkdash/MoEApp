using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSWebApiEmpty.Converters
{
    public class C2FConverter
    {
        public int C2F(int c)
        {
            return (c / 5 * 9 + 32);
        }

    }

}