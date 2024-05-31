using System;
using System.Collections.Generic;

namespace ejemploPersonaService.DataAccess.Models;

public partial class Rol
{
    public int RolId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Persona> Persona { get; set; } = new List<Persona>();
}
