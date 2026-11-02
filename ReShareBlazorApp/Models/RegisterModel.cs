using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ReShareBlazorApp.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="Podaj nazwe użytkownika!")]
        [MinLength(8,ErrorMessage="Minimum 8")]
        [MaxLength(24,ErrorMessage ="max 24")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Podaj adres e-mail!")]
        [EmailAddress(ErrorMessage ="Nieprawidłowy adres e-mail!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Podaj hasło!")]
        [MinLength(8,ErrorMessage ="Hasło musi mieć minimum 8 znaków.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Potwierdź hasło!")]
        [Compare(nameof(Password),ErrorMessage ="Hasła nie są identyczne.")]
        public string ConfirmPassword { get; set; }
        [Range(typeof(bool), "true", "true", ErrorMessage ="Musisz zaakceptować regulamin.")]
        public bool AcceptTerms { get; set; }
    }
}
