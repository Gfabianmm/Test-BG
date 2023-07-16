using BackEnd.DataBase.Entity;
using System.Linq.Expressions;

namespace BackEnd.DataAccess;

public static class IQueryableExtensions
{
    public static IQueryable<T> ApplyOrdering<T>(this IQueryable<T> query, IQueryObject queryObj, Dictionary<string, Expression<Func<T, object>>> columnsMap)
    {


        if (String.IsNullOrWhiteSpace(queryObj.SortBy) || !columnsMap.ContainsKey(queryObj.SortBy))
            return query;

        if (queryObj.IsSortAscending)
            return query = query.OrderBy(columnsMap[queryObj.SortBy]);
        else
            return query = query.OrderByDescending(columnsMap[queryObj.SortBy]);

    }


    public static IQueryable<T> ApplyPagging<T>(this IQueryable<T> query, IQueryObject queryObj)
    {
        if (queryObj.Page < 0)
            return query;

        if (queryObj.Page == 0)
            queryObj.Page = 1;

        if (queryObj.PageSize <= 0)
            queryObj.PageSize = 10;

        return query.Skip((queryObj.Page - 1) * queryObj.PageSize).Take(queryObj.PageSize);
    }
}
