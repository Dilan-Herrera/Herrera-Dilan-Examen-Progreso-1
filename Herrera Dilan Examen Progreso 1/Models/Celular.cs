using System.ComponentModel.DataAnnotations;

namespace Herrera_Dilan_Examen_Progreso_1.Models
{
    public class Celular
    {
        [Key]
        [Required]
        [Range(1, 9999999999)]
        public int Id { get; set; }

        [MinLength(1), MaxLength(100)]
        [Required]
        [DataType(DataType.Text)]
        public string Modelo { get; set; }

        [Required]
        [Range(1900, 2100)]
        public int Año { get; set; }

        [Required]
        public decimal Precio { get; set; }
    }
}
