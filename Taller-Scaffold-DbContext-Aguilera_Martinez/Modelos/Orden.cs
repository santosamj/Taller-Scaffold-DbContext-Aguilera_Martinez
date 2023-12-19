using System;
using System.Collections.Generic;

namespace Taller_Scaffold_DbContext_Aguilera_Martinez.Modelos
{
    public partial class Orden
    {
        public Orden()
        {
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public int? EstadoId { get; set; }
        public int? UsuarioId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public decimal? CostoEnvio { get; set; }
        public decimal? Total { get; set; }
        public string? TokenOrden { get; set; }
        public string? Direccion1 { get; set; }
        public string? Direccion2 { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Estado? Estado { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
