using Microsoft.EntityFrameworkCore;
using sms_mvc_web_app.Models.Entities;

namespace sms_mvc_web_app.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {
        }

        public DbSet<Student> Students { get; set; }

    }
}
