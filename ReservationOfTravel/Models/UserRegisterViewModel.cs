using System.ComponentModel.DataAnnotations;

namespace ReservationOfTravel.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen adınızı giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresi giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi tekrar giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler aynı değil !")]
        public string ConfirmPassword { get; set; }
    }
}
