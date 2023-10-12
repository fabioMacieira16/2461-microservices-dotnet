using System.ComponentModel.DataAnnotations;

namespace RestauranteService.Dtos
{
    public class RestauranteCreateDto
    {
        [Required]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public string Endereco { get; set; } = string.Empty;

        [Required]
        public string Site { get; set; } = string.Empty;
    }
}