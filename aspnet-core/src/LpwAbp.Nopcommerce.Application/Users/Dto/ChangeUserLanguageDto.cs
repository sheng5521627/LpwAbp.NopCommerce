using System.ComponentModel.DataAnnotations;

namespace LpwAbp.Nopcommerce.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}