using Microsoft.EntityFrameworkCore;

namespace WebAppMVCDotNetC1.Models
{
    public class AppDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HDC3-L-94S8B54;Initial Catalog=db_MvcDotNetC1;Integrated security=true;TrustServerCertificate=true");
        }   

        public DbSet<EmpModel> EmpModels { get; set; }  // Model object as a table --> fields

        // Add method dbcontext add data into a database

        public DbSet<UserModel> userModels { get; set; }  // Model object as a table --> fields 
    }
}
