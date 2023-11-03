using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class Contact
    {
        [Display(Name="Введите имя:")]
        [Required(ErrorMessage ="Имя обязательно!")]
        public string? Name { get; set; }
        [Display(Name = "Введите фамилию:")]
        [Required(ErrorMessage = "Фамилия обязательна!")]
        public string? SurName { get; set; }
        [Display(Name = "Введите возраст:")]
        [Required(ErrorMessage = "Возраст обязателен!")]
        public int? Age { get; set; }
        [Display(Name = "Введите почту:")]
        [Required(ErrorMessage = "Почта обязательна!")]
        public string? Email { get; set; }
        [Display(Name = "Ваше сообщение:")]
        [Required(ErrorMessage = "Сообщение обязательно!")]
        public string? Message { get; set; }
    }
}
