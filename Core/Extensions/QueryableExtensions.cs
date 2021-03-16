using System;
using System.Linq;
using System.Linq.Expressions;

namespace Core.Extensions
{
    public  static    class QueryableExtensions
    {
        public static IQueryable<TSource> WhereIf<TSource>(this IQueryable<TSource> query, bool condition, Expression<Func<TSource, bool>> predicate)
        {
            if (condition)
                return query.Where(predicate);
            return query;
        }    
    }
}
