using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ImageUpload.Models {
    public class ImageDbContext : DbContext{
        public ImageDbContext(DbContextOptions<ImageDbContext> options) : base(options)
        {
            
        }

        public DbSet<ImageModel> Images { get; set; }
    }
}
