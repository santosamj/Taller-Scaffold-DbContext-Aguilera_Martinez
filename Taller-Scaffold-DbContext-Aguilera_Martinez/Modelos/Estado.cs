using System;
using System.Collections.Generic;

namespace Taller_Scaffold_DbContext_Aguilera_Martinez.Modelos
{
    public partial class Estado
    {
        public Estado()
        {
            CategoriaProductos = new HashSet<CategoriaProducto>();
            Compania = new HashSet<Companium>();
            Items = new HashSet<Item>();
            MarcaProductos = new HashSet<MarcaProducto>();
            Ordens = new HashSet<Orden>();
            Productos = new HashSet<Producto>();
            Usuarios = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<CategoriaProducto> CategoriaProductos { get; set; }
        public virtual ICollection<Companium> Compania { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<MarcaProducto> MarcaProductos { get; set; }
        public virtual ICollection<Orden> Ordens { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
