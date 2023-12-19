using System;
using System.Collections.Generic;

namespace Taller_Scaffold_DbContext_Aguilera_Martinez.Modelos
{
    public partial class Companium
    {
        public int Id { get; set; }
        public int? EstadoId { get; set; }
        public string? NombreCompania { get; set; }
        public string? Ruc { get; set; }
        public string? Descripcion { get; set; }
        public string? RazonSocial { get; set; }
        public string? DireccionMatriz { get; set; }
        public string? UrlImg { get; set; }

        public virtual Estado? Estado { get; set; }
    }
}
