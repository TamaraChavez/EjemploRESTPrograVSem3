using System;
using System.Collections.Generic;

namespace ejemploPersonaService.DataAccess.Models;

public partial class Persona
{
    public string PersonaId { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public byte Tipo { get; set; }

    public virtual ICollection<Telefono> Telefono { get; set; } = new List<Telefono>();

    public virtual ICollection<Rol> Rol { get; set; } = new List<Rol>();
}
