namespace WickhamAthleticsData.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WickPage")]
    public partial class WickPage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WickPage()
        {
            PageRow = new HashSet<PageRow>();
        }

        [Key]
        public int PK_autPageId { get; set; }

        [StringLength(25)]
        public string strPageName { get; set; }

        [StringLength(100)]
        public string strPagePath { get; set; }

        public int? FK_intParentPage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PageRow> PageRow { get; set; }
    }
}
