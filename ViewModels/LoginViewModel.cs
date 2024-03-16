using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class LoginViewModel
    {
        [Key]
        [MaxLength(100)]
        [Required(ErrorMessage ="Vui long Nhap So dien thoai hoac Email")]
        [Display(Name ="Dien thoai/ Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Username { get; set; }

        [Display(Name ="Mat Khau")]
        [Required(ErrorMessage = "Vui long nhap mat khau")]
        [MinLength(5, ErrorMessage = "Ban can dat mat khau toi thieu 5 ky tu")]
        public string Password { get; set; }    


    }
}
