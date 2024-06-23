using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace crud_interface.Models
{
    public class Student
    {
        [Key]
        [DisplayName("id")]
        public int id { get; set; }


        [Required(ErrorMessage ="Informe o nome")]
        [StringLength(80, ErrorMessage = "maximo 80 caracteres")]
        [MinLength(5, ErrorMessage ="minimo 5 caracteres")]
        [DisplayName("Nome Completo")]
        public string name { get; set; } = String.Empty;


        [Required(ErrorMessage = "informe o E-mail")]
        [EmailAddress(ErrorMessage = "E-mail invalido")]
        [DisplayName("E-mail")]
        public string Email { get; set; } = string.Empty;

        public List<Premium> Premiums { get; set; } = new();



    }
}
