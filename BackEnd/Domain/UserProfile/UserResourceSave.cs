using System.ComponentModel.DataAnnotations;

namespace BackEnd.Domain.UserProfile
{
    public class UserResourceSave
    {
        [Required(AllowEmptyStrings = false)]
        public string Mail { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Names { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }
    }
}
