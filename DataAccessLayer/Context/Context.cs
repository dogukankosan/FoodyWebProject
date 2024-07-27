using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context
{
    public class Context:DbContext
    {
        DbSet<About> Abouts {  get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Feature> Features { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Review> Reviews { get; set; }
        DbSet<Slider> Sliders { get; set; }
        DbSet<SocialMedia> SocialMedias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Initial Catalog=FoodyDB;Integrated Security=true;Encrypt=True;TrustServerCertificate=True");
        }
    }
}