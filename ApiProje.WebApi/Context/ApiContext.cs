using ApiProje.WebApi.Entity;
using Microsoft.EntityFrameworkCore;

namespace ApiProje.WebApi.Context
{
    public class ApiContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EVOPARTION;initial catalog=ApiYummyDb;integrated security=true;");
        }
        // Veritabanına yansıtmak istediğimiz sınıf ve tabloların tanımlanması
        // Best practice: tekil sınıf adı çoğul tablo adı
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
