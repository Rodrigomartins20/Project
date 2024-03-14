using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Project.Models
{
    public class Premium
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o titulo do Premium")]
        [StringLength(69, ErrorMessage = "O nome deve conter ate 69 caracteres")]
        [MinLength(5, ErrorMessage = "O nome deve conter no minimo 5 caracteres")]
        [DisplayName("Titulo")]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        //[GreaterThanToday]
        [DisplayName("Inicio")]
        public DateTime StarDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Termino")]
        public DateTime EndDate { get; set; }

        [DisplayName("Aluno")]
        [Required(ErrorMessage = "Aluno invalido")]
        public int StudentId { get; set; }

        public Student? Student { get; set; }
    }
}
