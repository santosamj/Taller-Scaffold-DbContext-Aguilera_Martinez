using System;
using System.Collections.Generic;

namespace Taller_Scaffold_DbContext_Aguilera_Martinez.Modelos
{
    public partial class Producto
    {
        public Producto()
        {
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public int? EstadoId { get; set; }
        public int? MarcaProductoId { get; set; }
        public int? CategoriaProductoId { get; set; }
        public string? NombreProducto { get; set; }
        public string? Descripcion { get; set; }
        public int? Stock { get; set; }
        public string? UrlImg { get; set; }
        public decimal? PrecioAhora { get; set; }
        public decimal? PrecioAntes { get; set; }

        public virtual CategoriaProducto? CategoriaProducto { get; set; }
        public virtual Estado? Estado { get; set; }
        public virtual MarcaProducto? MarcaProducto { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
