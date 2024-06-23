using System.ComponentModel.DataAnnotations;

    


namespace календарь_задач.Models
{
    public class Feedback
    {
        [Display(Name ="Имя")]
        [Required(ErrorMessage ="Вам нужно заполнить поле")]
        public string? Name {get ; set ; }
        
        
        [Display(Name ="Фамилия")]
        [Required(ErrorMessage ="Вам нужно заполнить поле")]
        
        public string? SurName {get ; set ; }
        
        
        [Display(Name="Возраст")]
        [Required(ErrorMessage ="Вам нужно заполнить поле")]
        public int Age {get ; set ; }
        
        [Display(Name ="почта")]
        [Required(ErrorMessage ="Вам нужно заполнить поле")]
        public string? Email {get ; set ; }
        
        [Display(Name ="Собщение")]
        [Required(ErrorMessage ="Вам нужно заполнить поле")]
        [StringLength(30, ErrorMessage ="менее 30 символов")]
        public string? Message {get ; set ; }
    }
}
