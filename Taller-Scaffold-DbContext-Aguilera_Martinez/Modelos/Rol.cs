using System;
using System.Collections.Generic;

namespace Taller_Scaffold_DbContext_Aguilera_Martinez.Modelos
{
    public partial class Rol
    {
        public Rol()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
