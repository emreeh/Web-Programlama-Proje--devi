using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PakHos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PakHos.Data
{
   public class DatabaseContext:DbContext

    {
        public DbSet<Doktor> Doktors { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Poliklinik> Polikliniks { get; set; }
        public DbSet<Hasta> Hastas { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Randevu> Randevus { get; set; }
        public DbSet<Muayane> Muayanes{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-OB66UN2;database=HospitalNetCore;Integrated Security=True; MultipleActiveResultSets=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluent Api
            modelBuilder.Entity<Rol>().HasData(new Rol
            {
                Id = 1,
                Adi = "Admin"
            });
            modelBuilder.Entity<Kullanici>().HasData(new Kullanici {
                Id = 2,


                    Adi = "Admin",
                AktifMi = true,
                EklenmeTarihi = DateTime.Now,
                Email = "admin@pashos.tc",
                KullaniciAdi = "admin",
                Sifre = "123456",
               // Rol = new Rol { Id = 1 },
                RolId = 1, Soyadi = "admin", Telefon = "123",
               

                
            }) ; 
            
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
