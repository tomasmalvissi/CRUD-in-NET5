using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.MVC.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Titulo es obligatorio")]
        [StringLength(50, MinimumLength = 3)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "La Descripcion es obligatoria")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La Fecha es obligatoria")]
        [Display (Name = "Fecha de Lanzamiento")]
        [DataType(DataType.Date)]
        public DateTime FechaLanzamiento { get; set; }

        [Required(ErrorMessage = "El Autor es obligatorio")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El Precio es obligatorio")]
        public int Precio { get; set; }
    }
}
