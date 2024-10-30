using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Herrera_Dilan_Examen_Progreso_1.Models
{
    public class Herrera
    {
        [Key]
        [MinLength(1), MaxLength(10)]
        [Required]
        public int Cedula { get; set; }
        [Required]
        [Range(0, 60)]
        public double PesoKg { get; set; }
        [MinLength(1), MaxLength(100)]
        [Required]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
        [Required]
        public bool? Estudiante { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime? FechaNacimiento { get; set; }
        public Celular? Celular { get; set; }
        [ForeignKey("Celular")]
        public int IdCelular { get; set; }

    }
}
