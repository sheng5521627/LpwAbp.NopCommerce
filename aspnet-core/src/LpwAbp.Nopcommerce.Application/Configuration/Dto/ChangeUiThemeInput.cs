using System.ComponentModel.DataAnnotations;

namespace LpwAbp.Nopcommerce.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
