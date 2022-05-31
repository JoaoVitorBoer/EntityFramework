using System;
using System.Collections.Generic;

namespace DemoScaffold.Models
{
    public partial class Administrador
    {
        public decimal CodAdministrador { get; set; }
        public decimal NivelPrivilegio { get; set; }

        public virtual Usuario CodAdministradorNavigation { get; set; } = null!;
    }
}
