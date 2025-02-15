using AplikacePojisteniBlazor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace AplikacePojisteniBlazor.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<ClientData> ClientDatas { get; set; }
        public DbSet<Insurance> Insurances { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //konfighurace vztahů a dalších vlastností
            modelBuilder.Entity<Insurance>()
                .HasOne(i => i.ClientData)
                .WithMany()
                .HasForeignKey(i => i.ClientId);

        }
    }
}
