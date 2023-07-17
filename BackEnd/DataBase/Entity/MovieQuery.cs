using BackEnd.DataAccess;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.DataBase.Entity
{
    
    public class MovieQuery : IQueryObject
    {
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int GenreId { get; set; }
        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}

