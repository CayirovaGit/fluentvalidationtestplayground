using System.ComponentModel.DataAnnotations;

namespace fluentvalidationtestplayground.Models
{
    public class UserModel
    {
        [Required, StringLength(255)]
        public string Name { get; set; }

        [Required, StringLength(255)]
        public string Surname { get; set; }

        [Required, StringLength(11, MinimumLength = 11)]
        public string Tc { get; set; }

        [StringLength(20)]
        [Phone]
        public string Phone { get; set; }

        [Required, StringLength(255)]
        public string Username { get; set; }

        public string? Notes { get; set; }

        [Required, StringLength(255)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(11)]
        public string? VatId { get; set; }
    }
}
