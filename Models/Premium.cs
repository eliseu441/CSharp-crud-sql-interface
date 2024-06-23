using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace crud_interface.Models
{
    public class Premium
    {

        [Key]
        [DisplayName("id")]
        public int id { get; set; }


        [Required(ErrorMessage = "Informe o titulo do premium")]
        [StringLength(80, ErrorMessage = "maximo 80 caracteres")]
        [MinLength(5, ErrorMessage = "minimo 5 caracteres")]
        [DisplayName("Titulo")]
        public string Title { get; set; } = String.Empty;

        [DataType(DataType.DateTime)]
        [DisplayName("Inicio")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Fim")]
        public DateTime EndDate { get; set; }

        [DisplayName("Aluno")]
        [Required(ErrorMessage ="Aluno invalido")]
        public int StudentId { get; set; }

        public Student? Student { get; set; }











    }
}
