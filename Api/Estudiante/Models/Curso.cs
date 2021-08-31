using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Estudiante.Models
{
    [Table("Curso")]
    public class Curso
    {
        [Key]
        public Int32 Id { get; set; }
        public String Nombre { get; set; }
        public Int32 NumeroCreditos { get; set; }
    }
}
