using System;
using System.Collections.Generic;

namespace Taller_Scaffold_DbContext_Aguilera_Martinez.Modelos
{
    public partial class MarcaProducto
    {
        public MarcaProducto()
        {
            Productos = new HashSet<Producto>();
        }

        public int Id { get; set; }
        public int? EstadoId { get; set; }
        public string? NombreMarca { get; set; }

        public virtual Estado? Estado { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
