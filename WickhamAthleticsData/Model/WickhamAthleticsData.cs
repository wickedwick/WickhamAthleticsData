namespace WickhamAthleticsData.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WickhamAthleticsData : DbContext
    {
        public WickhamAthleticsData()
            : base("name=WickhamAthleticsData")
        {
        }

        public virtual DbSet<PageRow> PageRow { get; set; }
        public virtual DbSet<RowPanel> RowPanel { get; set; }
        public virtual DbSet<WickPage> WickPage { get; set; }
        public virtual DbSet<PanelContent> PanelContent { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PanelContent>()
                .Property(e => e.strContentClassName)
                .IsUnicode(false);

            modelBuilder.Entity<PageRow>()
                .Property(e => e.strRowClassName)
                .IsUnicode(false);

            modelBuilder.Entity<PageRow>()
                .HasMany(e => e.RowPanel)
                .WithOptional(e => e.PageRow)
                .HasForeignKey(e => e.FK_intRowId);

            modelBuilder.Entity<RowPanel>()
                .Property(e => e.strPanelClassName)
                .IsUnicode(false);

            modelBuilder.Entity<RowPanel>()
                .HasMany(e => e.PanelContent)
                .WithOptional(e => e.RowPanel)
                .HasForeignKey(e => e.FK_intPanelId);

            modelBuilder.Entity<WickPage>()
                .Property(e => e.strPageName)
                .IsUnicode(false);

            modelBuilder.Entity<WickPage>()
                .Property(e => e.strPagePath)
                .IsUnicode(false);

            modelBuilder.Entity<WickPage>()
                .HasMany(e => e.PageRow)
                .WithOptional(e => e.WickPage)
                .HasForeignKey(e => e.FK_intPageId);
        }
    }
}
