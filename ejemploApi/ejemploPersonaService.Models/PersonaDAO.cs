using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploPersonaService.Models
{
    internal class PersonaDAO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "El ID de la persona es requerido")]//NO PERMITE QUE EL STRING VENGA VACIO
        public string PersonaId { get; set; } = null!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "El tipo de persona es requerido")]
        [Range(1, 3, ErrorMessage = "El tipo de persona debe ser 1, 2 o 3")]
        public byte Tipo { get; set; }//

        public string? Telefono { get; set; } = null!;//?OPCIONAL

        [Required(AllowEmptyStrings = false, ErrorMessage = "El rol de la persona es requerido")]
        public string Rol { get; set; } = null!;
    }
}
