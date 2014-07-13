using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reyx.Nfe
{
    internal static class Extensions
    {
        public static string Name(this Enum e)
        {
            return Enum.GetName(e.GetType(), e);
        }

        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }
    }
}