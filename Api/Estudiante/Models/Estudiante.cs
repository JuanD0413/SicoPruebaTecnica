using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Estudiante.Models
{
    [Table("Estudiante")]
    public class Estudiante
    {
        [Key]
        public Int32 Id { get; set; }
        public String TipoIdentificacion { get; set; }
        public String Identificacion { get; set; }
        public String Nombre1 { get; set; }
        public String Nombre2 { get; set; }
        public String Apellido1 { get; set; }
        public String Apellido2 { get; set; }
        public String Email { get; set; }
        public String Celular { get; set; }
        public String Direccion { get; set; }
        public String Ciudad { get; set; }
    }
}
