using System.ComponentModel.DataAnnotations;

namespace LoginPageProject.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı gereklidir")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre gereklidir")]
        public string Password { get; set; }
    }

}
