using InstituteManagement.API.Model;
using Microsoft.EntityFrameworkCore;

namespace InstituteManagement.API.Data
{
    public class InstituteDbContext : DbContext
    {
        public InstituteDbContext(DbContextOptions<InstituteDbContext> dbContextOptions) : base(dbContextOptions) 
        {

        }

        DbSet<Student> Students { get; set; }   
    }
}
