//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaVentasPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_VENTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_VENTA()
        {
            this.TB_DETALLEVENTA = new HashSet<TB_DETALLEVENTA>();
        }
    
        public int id_venta { get; set; }
        public Nullable<int> id_producto { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public Nullable<int> cantidad { get; set; }
    
        public virtual TB_CLIENTE TB_CLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_DETALLEVENTA> TB_DETALLEVENTA { get; set; }
        public virtual TB_PRODUCTO TB_PRODUCTO { get; set; }
    }
}
