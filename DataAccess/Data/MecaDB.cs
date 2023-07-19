using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Data
{
    internal class MecaDB : DbContext
    {
        #region Config
        public MecaDB() : base(){ }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlite(
                "Data Source=MecaDataBase.db");
            base.OnConfiguring(optionsBuilder);

        }
        #endregion
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Segment> Segments { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Refferal> Refferals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            #region Refferal
            modelBuilder.Entity<Refferal>().Navigation(e => e.Jobs).AutoInclude();
            modelBuilder.Entity<Job>().Navigation(e => e.Segment).AutoInclude();

            #endregion

            base.OnModelCreating(modelBuilder);

        }
    }
}
