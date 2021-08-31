using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Estudiante.Models
{
    [Table("EstudianteCurso")]
    public class EstudianteCurso
    {
        [Key]
        public Int32 Id { get; set; }
        public Int32 IdEstudiante { get; set; }
        public Int32 IdCurso { get; set; }
        public Decimal NotaFinal { get; set; }
    }
}
