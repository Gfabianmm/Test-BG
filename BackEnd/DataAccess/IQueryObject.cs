using BackEnd.DataBase.Entity;

namespace BackEnd.DataAccess
{
    public interface IQueryObject
    {
        string SortBy { get; set; }
        bool IsSortAscending { get; set; }
        int Page { get; set; }

        int PageSize { get; set; }
    }
}
