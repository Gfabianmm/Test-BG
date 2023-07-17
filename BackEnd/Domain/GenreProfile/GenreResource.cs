using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace BackEnd.Domain.GenreProfile
{

    public class GenreResource
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
