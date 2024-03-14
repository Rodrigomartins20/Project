using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project.Models;

public class Student
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome")]
    [StringLength(100, ErrorMessage = "O nome deve conter ate 80 caracteres")]
    [MinLength(5, ErrorMessage = "O nome deve conter no minimo 5 caracteres")]
    [DisplayName("Nome Completo")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe o nome")]
    [EmailAddress(ErrorMessage = "E-mail invalido")]
    [DisplayName("E-mail")]
    public string Email { get; set; } = string.Empty;       

    public List<Premium> Premiums { get; set; } = new();
}
