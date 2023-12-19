using System;
using System.Collections.Generic;

namespace Taller_Scaffold_DbContext_Aguilera_Martinez.Modelos
{
    public partial class Item
    {
        public int Id { get; set; }
        public int? EstadoId { get; set; }
        public int? UsuarioId { get; set; }
        public int? ProductoId { get; set; }
        public int? OrdenId { get; set; }
        public int? Cantidad { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Estado? Estado { get; set; }
        public virtual Orden? Orden { get; set; }
        public virtual Producto? Producto { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }
}
