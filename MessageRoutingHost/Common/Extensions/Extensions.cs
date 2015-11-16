using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageRoutingHub.Common.Extensions
{
    public static class Extensions
    {
        public static Stack<T> Clone<T>(this Stack<T> source)
        {
            return new Stack<T>(source.Reverse());
        }


        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
    }
}