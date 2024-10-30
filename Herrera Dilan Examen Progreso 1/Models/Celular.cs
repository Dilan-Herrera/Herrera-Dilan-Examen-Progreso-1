using System.ComponentModel.DataAnnotations;

namespace Herrera_Dilan_Examen_Progreso_1.Models
{
    public class Celular
    {
        [Key]
        [MinLength(1), MaxLength(10)]
        [Required]
        public int Id { get; set; }
        [MinLength(1), MaxLength(100)]
        [Required]
        [DataType(DataType.Text)]
        public string Modelo { get; set; }
        [MinLength(1), MaxLength(10)]
        [Required]
        public int Año { get; set; }
        [Required]
        public decimal Precio { get; set; }

    }
}
