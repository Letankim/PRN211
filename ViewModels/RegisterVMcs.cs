using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class RegisterVMcs

    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name = "Ho Va Ten")]
        [Required(ErrorMessage = "Vui Long nhap Ho Ten")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Vui long Nhap email")]
        [MaxLength(150)]
        [DataType(DataType.EmailAddress)]
        [Remote(action: "ValidateEmail", controller: "Accounts")]
        public string Email { get; set; }
        [MaxLength(11)]
        [Required(ErrorMessage ="Vui long nhap so dien thoai")]
        [Display(Name ="Dien Thoai")]
        [DataType(DataType.PhoneNumber)]
        [Remote(action:"ValidatePhone", controller:"Accounts")]
        public string Phone { get; set; }
        [Display(Name ="Mat Khau")]
        [Required(ErrorMessage ="Vui long nahp mat khau")]
        [MinLength(5, ErrorMessage ="Vui long dat mat khau toi thieu 5 ki tu")]
        public string Password { get; set; }
        [MinLength(5, ErrorMessage ="Ban can dat mat khau toi thieu 5 ki tu")]
        [Display(Name ="Nhap lai mat khau")]
        [Compare("Password", ErrorMessage="Vui long nhap mat khau giong nhau")]
        public string ConfirmPassword { get; set;}

    }
}
