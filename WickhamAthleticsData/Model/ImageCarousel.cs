//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WickhamAthleticsData.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImageCarousel
    {
        public ImageCarousel()
        {
            this.Image = new HashSet<Image>();
        }
    
        public int PK_ImgCarID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> FK_Panel { get; set; }
    
        public virtual ICollection<Image> Image { get; set; }
        public virtual Panel Panel { get; set; }
    }
}
