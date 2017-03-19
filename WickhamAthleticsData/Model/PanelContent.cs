using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WickhamAthleticsData.Model
{
    [Table("PanelContent")]
    public partial class PanelContent
    {
        public PanelContent()
        {

        }

        [Key]
        public int PK_autContentId { get; set; }

        public int? FK_intPanelId { get; set; }

        public int? intRenderOrder { get; set; }

        [StringLength(25)]
        public string strContentClassName { get; set; }

        public virtual RowPanel RowPanel { get; set; }
    }
}
