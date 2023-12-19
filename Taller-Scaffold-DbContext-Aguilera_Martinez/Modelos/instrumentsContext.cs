using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Taller_Scaffold_DbContext_Aguilera_Martinez.Modelos
{
    public partial class instrumentsContext : DbContext
    {
        public instrumentsContext()
        {
        }

        public instrumentsContext(DbContextOptions<instrumentsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoriaProducto> CategoriaProductos { get; set; } = null!;
        public virtual DbSet<Companium> Compania { get; set; } = null!;
        public virtual DbSet<Estado> Estados { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<MarcaProducto> MarcaProductos { get; set; } = null!;
        public virtual DbSet<Orden> Ordens { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Rol> Rols { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQL2023;Database=instruments;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaProducto>(entity =>
            {
                entity.ToTable("categoria_producto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EstadoId).HasColumnName("estadoId");

                entity.Property(e => e.NombreCategoria)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_categoria");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.CategoriaProductos)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("FK__categoria__estad__4222D4EF");
            });

            modelBuilder.Entity<Companium>(entity =>
            {
                entity.ToTable("compania");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.DireccionMatriz)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion_Matriz");

                entity.Property(e => e.EstadoId).HasColumnName("estadoId");

                entity.Property(e => e.NombreCompania)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_compania");

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("razon_Social");

                entity.Property(e => e.Ruc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ruc");

                entity.Property(e => e.UrlImg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("url_img");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.Compania)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("FK__compania__estado__3F466844");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.ToTable("estado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.EstadoId).HasColumnName("estadoId");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.OrdenId).HasColumnName("ordenId");

                entity.Property(e => e.ProductoId).HasColumnName("productoId");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("FK__Items__estadoId__5070F446");

                entity.HasOne(d => d.Orden)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.OrdenId)
                    .HasConstraintName("FK__Items__ordenId__534D60F1");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ProductoId)
                    .HasConstraintName("FK__Items__productoI__52593CB8");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK__Items__usuarioId__5165187F");
            });

            modelBuilder.Entity<MarcaProducto>(entity =>
            {
                entity.ToTable("Marca_Producto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EstadoId).HasColumnName("estadoId");

                entity.Property(e => e.NombreMarca)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_marca");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.MarcaProductos)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("FK__Marca_Pro__estad__44FF419A");
            });

            modelBuilder.Entity<Orden>(entity =>
            {
                entity.ToTable("Orden");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.CostoEnvio)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("costo_envio");

                entity.Property(e => e.Direccion1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion_1");

                entity.Property(e => e.Direccion2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion_2");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EstadoId).HasColumnName("estadoId");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.TokenOrden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("token_orden");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.Ordens)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("FK__Orden__estadoId__4CA06362");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Ordens)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK__Orden__usuarioId__4D94879B");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("producto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoriaProductoId).HasColumnName("categoria_producto_Id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EstadoId).HasColumnName("estadoId");

                entity.Property(e => e.MarcaProductoId).HasColumnName("marca_producto_Id");

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_producto");

                entity.Property(e => e.PrecioAhora)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("precio_ahora");

                entity.Property(e => e.PrecioAntes)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("precio_antes");

                entity.Property(e => e.Stock).HasColumnName("stock");

                entity.Property(e => e.UrlImg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("url_Img");

                entity.HasOne(d => d.CategoriaProducto)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.CategoriaProductoId)
                    .HasConstraintName("FK__producto__catego__49C3F6B7");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("FK__producto__estado__47DBAE45");

                entity.HasOne(d => d.MarcaProducto)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.MarcaProductoId)
                    .HasConstraintName("FK__producto__marca___48CFD27E");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("rol");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EstadoId).HasColumnName("estadoId");

                entity.Property(e => e.Intentosfallidos).HasColumnName("intentosfallidos");

                entity.Property(e => e.Maxintentos).HasColumnName("maxintentos");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.RolId).HasColumnName("rolId");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("FK__usuario__intento__3B75D760");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK__usuario__rolId__3C69FB99");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
