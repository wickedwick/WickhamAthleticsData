namespace WickhamAthleticsData.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PageRow")]
    public partial class PageRow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PageRow()
        {
            RowPanel = new HashSet<RowPanel>();
        }

        [Key]
        public int PK_autRowId { get; set; }

        public int? FK_intPageId { get; set; }

        public int? intRenderOrder { get; set; }

        [StringLength(25)]
        public string strRowClassName { get; set; }

        public virtual WickPage WickPage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RowPanel> RowPanel { get; set; }
    }
}
