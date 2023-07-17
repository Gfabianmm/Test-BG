using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Domain.CategoryProfile
{
    public class CategoryResource
    {
        public int Id { get; set; }
        public string Description { get; set; }

    }
}
