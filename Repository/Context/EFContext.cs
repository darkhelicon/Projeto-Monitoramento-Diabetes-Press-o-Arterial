using Microsoft.EntityFrameworkCore;
using Repository.Entity;

namespace Repository.Context
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options):
            base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {

        }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PersonEntity> Persons { get; set; }
        public DbSet<MedEntity> Med { get; set; }
        public DbSet<HiperEntity> Hiper { get; set; }
        public DbSet<GlicoEntity> Glico { get; set; }
        public DbSet<ExtraEntity> Extra { get; set; }
    }
}
