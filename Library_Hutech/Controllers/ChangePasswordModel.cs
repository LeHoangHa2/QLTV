using System.ComponentModel.DataAnnotations;

namespace Library_Hutech.Models
{
    public class ChangePasswordModel
    {
        [Required(ErrorMessage = "Please enter current password.")]
        public string currentPassword { get; set; }

        [Required(ErrorMessage = "Please enter new password.")]
        public string newPassword { get; set; }

        [Compare("newPassword", ErrorMessage = "New password and confirm password do not match.")]
        public string confirmPassword { get; set; }
    }
}
