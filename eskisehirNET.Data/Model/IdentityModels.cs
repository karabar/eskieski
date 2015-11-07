using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration.Conventions;
using eskisehirNET.Data.Migrations;
using System.Collections.Generic;

namespace eskisehirNET.Data.Model
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class Kullanici : IdentityUser
    {
        public virtual ICollection<Haber> Haberleri { get; set; }
        public virtual ICollection<Yasam> Yasam { get; set; }
        public virtual ICollection<Mekan> Mekanlari { get; set; }
        public virtual ICollection<Etkinlik> Etkinlikleri { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Kullanici> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;

        }

    }

    public class ApplicationDbContext : IdentityDbContext<Kullanici>
    {

        public ApplicationDbContext()
            : base("EskisehirNETContext", throwIfV1Schema: false)
        {
            Database.SetInitializer(new
                MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>("EskisehirNETContext"));

        }

        public DbSet<HaberKategori> HaberKategorileri { get; set; }
        public DbSet<Haber> Haberler { get; set; }
        public DbSet<HaberTip> HaberTipleri { get; set; }
        public DbSet<Eczane> Eczaneler { get; set; }
        public DbSet<NobetciEczane> NobetciEczaneler { get; set; }
        public DbSet<Yasam> Yasamlar { get; set; }
        public DbSet<YasamKategori> YasamKategorileri { get; set; }
        public DbSet<Mekan> Mekanlar { get; set; }
        public DbSet<MekanKategori> MekanKategorileri { get; set; }
        public DbSet<MekanReklam> MekanReklamlari { get; set; }
        public DbSet<Etkinlik> Etkinlikler { get; set; }
        public DbSet<EtkinlikKategori> EtkinlikKategorileri { get; set; }
        public DbSet<MekanResim> MekanResimleri { get; set; }
        public DbSet<Filmler> Filmler { get; set; }
        public DbSet<Seanslar> Seanslar { get; set; }
        public DbSet<Video> Videolar { get; set; }

  


        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //bu çok önemli cascade delete false için

            //identitiy model değişiklikleri//
            modelBuilder.Entity<Kullanici>().ToTable("Kullanici").Property(p => p.Id).HasColumnName("KullaniciId");
            modelBuilder.Entity<IdentityUserRole>().ToTable("KullaniciRol"); 
            modelBuilder.Entity<IdentityUserLogin>().ToTable("KullaniciLogin");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("KullaniciTalep").Property(p=>p.Id).HasColumnName("KullaniciTalepId");
            modelBuilder.Entity<IdentityRole>().ToTable("Rol").Property(p => p.Id).HasColumnName("RolId");
            
            modelBuilder.Entity<Haber>().ToTable("Haberler");
            modelBuilder.Entity<HaberKategori>().ToTable("HaberKategorileri");
            modelBuilder.Entity<HaberTip>().ToTable("HaberTipleri");
            modelBuilder.Entity<Eczane>().ToTable("Eczaneler");
            modelBuilder.Entity<NobetciEczane>().ToTable("NobetciEczaneler");

            modelBuilder.Entity<YasamKategori>().
               HasOptional(e => e.AnaKategori).
               WithMany().
               HasForeignKey(m => m.AnaKategoriNo);

            modelBuilder.Entity<YasamKategori>().ToTable("YasamKategorileri"); 
            modelBuilder.Entity<Yasam>().ToTable("Yasamlar");

            modelBuilder.Entity<MekanKategori>().
               HasOptional(e => e.AnaKategori).
               WithMany().
               HasForeignKey(m => m.AnaKategoriNo);

            modelBuilder.Entity<MekanKategori>().ToTable("MekanKategorileri");
            modelBuilder.Entity<Mekan>().ToTable("Mekanlar");
            modelBuilder.Entity<MekanResim>().ToTable("MekanResimleri");
            modelBuilder.Entity<MekanReklam>().ToTable("MekanReklamlari");

            modelBuilder.Entity<EtkinlikKategori>().ToTable("EtkinlikKategorileri");
            modelBuilder.Entity<Etkinlik>().ToTable("Etkinlikler");

            modelBuilder.Entity<Filmler>().ToTable("Filmler");
            modelBuilder.Entity<Seanslar>().ToTable("Seanslar");
            modelBuilder.Entity<Video>().ToTable("Videolar");

            
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}