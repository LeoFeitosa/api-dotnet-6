using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateFilmeDto
{
    [Required(ErrorMessage = "O Titulo do filme e obrigatório.")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O Genero do filme e obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do genero nao pode exceder 50 caracteres.")]
    public string Genero { get; set; }

    [Required]
    [Range(70, 600, ErrorMessage = "A duracao deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
