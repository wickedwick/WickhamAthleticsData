﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Content> Content { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<ImageCarousel> ImageCarousel { get; set; }
        public DbSet<Panel> Panel { get; set; }
        public DbSet<TEXT_TYPE_REF> TEXT_TYPE_REF { get; set; }
        public DbSet<VarSet> VarSet { get; set; }
        public DbSet<Staff> Staff { get; set; }
    }
}
