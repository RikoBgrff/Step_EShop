using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Step_EShop.Extensions
{
    public static class LinqExtension
    {
        public static IEnumerable<T> WhereIf<T>
            (this IEnumerable<T> query,bool condition, Func<T, bool> predicate)
        {
            if (condition)
            {
                query = query.Where(predicate);
            }
            return query;
        }
    }
}
