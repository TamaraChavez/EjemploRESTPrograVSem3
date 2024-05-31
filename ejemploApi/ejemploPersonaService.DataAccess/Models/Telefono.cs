using System;
using System.Collections.Generic;

namespace ejemploPersonaService.DataAccess.Models;

public partial class Telefono
{
    public int TelefonoId { get; set; }

    public string PersonaId { get; set; } = null!;

    public string Telefono1 { get; set; } = null!;

    public virtual Persona Persona { get; set; } = null!;
}
