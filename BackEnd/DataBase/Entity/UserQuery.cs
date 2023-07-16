using BackEnd.DataAccess;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.DataBase.Entity
{
    
    public class UserQuery: IQueryObject
    {
        public int? Id { get; set; }
        public string? Mail { get; set; }
        public string? Names { get; set; }
        public string? Password { get; set; }

        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }

    }
}
