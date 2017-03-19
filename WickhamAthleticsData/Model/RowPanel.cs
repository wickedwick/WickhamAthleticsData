namespace WickhamAthleticsData.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RowPanel")]
    public partial class RowPanel
    {
        [Key]
        public int PK_autPanelId { get; set; }

        public int? FK_intRowId { get; set; }

        public int? intRenderOrder { get; set; }

        [StringLength(25)]
        public string strPanelClassName { get; set; }

        public int? intWidth { get; set; }

        public virtual PageRow PageRow { get; set; }

        public virtual ICollection<PanelContent> PanelContent { get; set; }
    }
}
