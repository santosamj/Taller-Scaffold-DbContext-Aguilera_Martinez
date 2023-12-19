using System;
using System.Collections.Generic;

namespace Taller_Scaffold_DbContext_Aguilera_Martinez.Modelos
{
    public partial class Usuario
    {
        public Usuario()
        {
            Items = new HashSet<Item>();
            Ordens = new HashSet<Orden>();
        }

        public int Id { get; set; }
        public int? EstadoId { get; set; }
        public int? RolId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? Maxintentos { get; set; }
        public int? Intentosfallidos { get; set; }

        public virtual Estado? Estado { get; set; }
        public virtual Rol? Rol { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Orden> Ordens { get; set; }
    }
}
