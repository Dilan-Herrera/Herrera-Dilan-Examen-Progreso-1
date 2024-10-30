using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Herrera_Dilan_Examen_Progreso_1.Models;

namespace Herrera_Dilan_Examen_Progreso_1.Data
{
    public class Herrera_Dilan_Examen_Progreso_1Context : DbContext
    {
        public Herrera_Dilan_Examen_Progreso_1Context (DbContextOptions<Herrera_Dilan_Examen_Progreso_1Context> options)
            : base(options)
        {
        }

        public DbSet<Herrera_Dilan_Examen_Progreso_1.Models.Herrera> Herrera { get; set; } = default!;
        public DbSet<Herrera_Dilan_Examen_Progreso_1.Models.Celular> Celular { get; set; } = default!;
    }
}
